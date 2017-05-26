/**
  * Copyright (C) 2009-2017 Lightbend Inc. <http://www.lightbend.com>
  */
package sample.distributeddata

import java.util.Optional

import scala.concurrent.duration._
import akka.remote.testkit.MultiNodeConfig
import akka.remote.testkit.MultiNodeSpec
import akka.testkit.{ImplicitSender, TestProbe}
import akka.actor.ActorRef
import akka.cluster.Cluster
import akka.cluster.ddata.DistributedData
import akka.cluster.ddata.Replicator.{GetReplicaCount, ReplicaCount}
import akka.remote.testconductor.RoleName
import akka.routing.FromConfig
import com.typesafe.config.ConfigFactory

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
      # akka.extensions=["akka.cluster.metrics.ClusterMetricsExtension"]
      # Sigar native library extract location during tests.
      akka.cluster.metrics.native-library-extract-folder=target/native/${role.name}
      """)
    }
  }

  // this configuration will be used for all nodes
  // note that no fixed host names and ports are used
  commonConfig(ConfigFactory.parseString("""
    akka.actor.provider = cluster
    akka.remote.log-remote-lifecycle-events = off
    akka.cluster.roles = [compute]
    akka.log-dead-letters-during-shutdown = off
    akka.loglevel = INFO

    #//#router-lookup-config
    akka.actor.deployment {
      /replicatedCache {
          router = round-robin-group
          routees.paths = ["/user/replicatedCache"]
          cluster {
            enabled = on
            allow-local-routees = on
            use-role = compute
          }
        }
    }
    #//#router-lookup-config
    """))

}

class ReplicatedCacheResizerSpecMultiJvmNode1 extends ReplicatedCacheResizerSpec
class ReplicatedCacheResizerSpecMultiJvmNode2 extends ReplicatedCacheResizerSpec
class ReplicatedCacheResizerSpecMultiJvmNode3 extends ReplicatedCacheResizerSpec

class ReplicatedCacheResizerSpec extends MultiNodeSpec(ReplicatedCacheResizerSpec)
  with STMultiNodeSpec with ImplicitSender {
  override def initialParticipants = roles.size

  def context = system

  import ReplicatedCache._
  import ReplicatedCacheSpec._

  val cluster = Cluster(system)
  val replicatedCache: ActorRef =
    context.actorOf(FromConfig.props(ReplicatedCache.props()), name = "replicatedCache")

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
        replicatedCache ! new PutInCache("key1", "A")
      }

      awaitAssert {
        val probe = TestProbe()
        replicatedCache.tell(new GetFromCache("key1"), probe.ref)
        probe.expectMsg(new Cached("key1", Optional.of("A")))
      }

      enterBarrier("after-2")
    }

    "replicate many cached entries" in within(10.seconds) {
      runOn(node1) {
        for (i ← 100 to 200)
          replicatedCache ! new PutInCache("key" + i, i)
      }

      awaitAssert {
        val probe = TestProbe()
        for (i ← 100 to 200) {
          replicatedCache.tell(new GetFromCache("key" + i), probe.ref)
          probe.expectMsg(new Cached("key" + i, Optional.of(Integer.valueOf(i))))
        }
      }

      enterBarrier("after-3")
    }

    "replicate evicted entry" in within(15.seconds) {
      runOn(node1) {
        replicatedCache ! new PutInCache("key2", "B")
      }

      awaitAssert {
        val probe = TestProbe()
        replicatedCache.tell(new GetFromCache("key2"), probe.ref)
        probe.expectMsg(new Cached("key2", Optional.of("B")))
      }
      enterBarrier("key2-replicated")

      runOn(node3) {
        replicatedCache ! new Evict("key2")
      }

      awaitAssert {
        val probe = TestProbe()
        replicatedCache.tell(new GetFromCache("key2"), probe.ref)
        probe.expectMsg(new Cached("key2", Optional.empty()))
      }

      enterBarrier("after-4")
    }

    "replicate updated cached entry" in within(10.seconds) {
      runOn(node2) {
        replicatedCache ! new PutInCache("key1", "A2")
        replicatedCache ! new PutInCache("key1", "A3")
      }

      awaitAssert {
        val probe = TestProbe()
        replicatedCache.tell(new GetFromCache("key1"), probe.ref)
        probe.expectMsg(new Cached("key1", Optional.of("A3")))
      }

      enterBarrier("after-5")
    }
  }
}