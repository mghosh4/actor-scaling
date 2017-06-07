/**
  * Copyright (C) 2009-2017 Lightbend Inc. <http://www.lightbend.com>
  */
package sample.distributeddata

import scala.concurrent.duration._
import akka.remote.testkit.MultiNodeConfig
import akka.remote.testkit.MultiNodeSpec
import akka.testkit.{ImplicitSender, TestProbe}
import akka.actor.{PoisonPill, Props, RootActorPath}
import akka.cluster.Cluster
import akka.cluster.ddata.DistributedData
import akka.cluster.ddata.Replicator.{GetReplicaCount, ReplicaCount}
import akka.cluster.singleton.{ClusterSingletonManager, ClusterSingletonManagerSettings, ClusterSingletonProxy, ClusterSingletonProxySettings}
import akka.remote.testconductor.RoleName
import com.typesafe.config.ConfigFactory
import org.scalatest.{BeforeAndAfterAll, Matchers, WordSpecLike}

object ReplicatedCacheResizerSpec extends MultiNodeConfig {
  // register the named roles (nodes) of the test
  val node1 = role("node-1")
  val node2 = role("node-2")
  val node3 = role("node-3")

  def nodeList = Seq(node1, node2, node3)

  // Extract individual sigar library for every node.
  nodeList foreach { role =>
    nodeConfig(role) {
      ConfigFactory.parseString(s"""
      # Disable legacy metrics in akka-cluster.
      akka.cluster.metrics.enabled=off
      # Enable metrics extension in akka-cluster-metrics.
      akka.extensions=["akka.cluster.metrics.ClusterMetricsExtension"]
      # Sigar native library extract location during tests.
      akka.cluster.metrics.native-library-extract-folder=target/native/${role.name}
      """)
    }
  }

  // this configuration will be used for all nodes
  // note that no fixed host names and ports are used
  commonConfig(ConfigFactory.parseString("""
    akka.actor.provider = "cluster"
    akka.remote.log-remote-lifecycle-events = off
    akka.cluster.roles = [compute]
    akka.log-dead-letters-during-shutdown = off
    akka.loglevel = INFO

    #//#router-deploy-config
    akka.actor.deployment {
      /cachingService/singleton/replicatedCache {
        router = round-robin-pool
        cluster {
          enabled = on
          max-nr-of-instances-per-node = 15
          allow-local-routees = on
          use-role = compute
        }
      }
    }
    #//#router-deploy-config
    """))

}

class ReplicatedCacheResizerSpecMultiJvmNode1 extends ReplicatedCacheResizerSpec
class ReplicatedCacheResizerSpecMultiJvmNode2 extends ReplicatedCacheResizerSpec
class ReplicatedCacheResizerSpecMultiJvmNode3 extends ReplicatedCacheResizerSpec

class ReplicatedCacheResizerSpec extends MultiNodeSpec(ReplicatedCacheResizerSpec)
  with WordSpecLike with Matchers with BeforeAndAfterAll with STMultiNodeSpec with ImplicitSender {
  override def initialParticipants = roles.size

  override def beforeAll() = multiNodeSpecBeforeAll()

  override def afterAll() = multiNodeSpecAfterAll()

  def context = system

  import ReplicatedCache._
  import ReplicatedCacheSpec._

  val cluster = Cluster(system)

  system.actorOf(ClusterSingletonManager.props(
    Props[CachingService],
    terminationMessage = PoisonPill,
    settings = ClusterSingletonManagerSettings(system)),
    name = "cachingService")

  system.actorOf(ClusterSingletonProxy.props("/user/cachingService",
    ClusterSingletonProxySettings(system).withRole("compute")), "cachingServiceProxy")

  def join(from: RoleName, to: RoleName): Unit = {
    runOn(from) {
      cluster join node(to).address
    }
    enterBarrier(from.name + "-joined")
  }


  "Demo of a replicated cache" must {
    "join cluster" in within(20.seconds) {
      join(node1, node1)
      join(node2, node1)
      join(node3, node1)

      awaitAssert {
        DistributedData(system).replicator ! GetReplicaCount
        expectMsg(ReplicaCount(roles.size))
      }
      enterBarrier("after-1")
    }

    "replicate cached entry" in within(10.seconds) {
      runOn(node1) {
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy ! new PutInCache("key1", "A")
      }

      awaitAssert {
        val probe = TestProbe()
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy.tell(new GetFromCache("key1"), probe.ref)
        probe.expectMsg(new Cached("key1", "A"))
      }

      enterBarrier("after-2")
    }

    "replicate many cached entries" in within(10.seconds) {
      runOn(node1) {
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        for (i ← 100 to 200)
          proxy ! new PutInCache("key" + i, i)
      }

      awaitAssert {
        val probe = TestProbe()
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        for (i ← 100 to 200) {
          proxy.tell(new GetFromCache("key" + i), probe.ref)
          probe.expectMsg(new Cached("key" + i, Integer.valueOf(i)))
        }
      }

      enterBarrier("after-3")
    }

    "replicate evicted entry" in within(15.seconds) {
      runOn(node1) {
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy ! new PutInCache("key2", "B")
      }

      awaitAssert {
        val probe = TestProbe()
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy.tell(new GetFromCache("key2"), probe.ref)
        probe.expectMsg(new Cached("key2", "B"))
      }
      enterBarrier("key2-replicated")

      runOn(node3) {
        val proxy = system.actorSelection(RootActorPath(node(node3).address) / "user" / "cachingServiceProxy")
        proxy ! new Evict("key2")
      }

      awaitAssert {
        val probe = TestProbe()
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy.tell(new GetFromCache("key2"), probe.ref)
        probe.expectMsg(new Cached("key2", null))
      }

      enterBarrier("after-4")
    }

    "replicate updated cached entry" in within(10.seconds) {
      runOn(node2) {
        val proxy = system.actorSelection(RootActorPath(node(node2).address) / "user" / "cachingServiceProxy")
        proxy ! new PutInCache("key1", "A2")
        proxy ! new PutInCache("key1", "A3")
      }

      awaitAssert {
        val probe = TestProbe()
        val proxy = system.actorSelection(RootActorPath(node(node1).address) / "user" / "cachingServiceProxy")
        proxy.tell(new GetFromCache("key1"), probe.ref)
        probe.expectMsg(new Cached("key1", "A3"))
      }

      enterBarrier("after-5")
    }
  }
}