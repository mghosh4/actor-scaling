package sample.distributeddata;

import akka.routing.FromConfig;
import akka.actor.AbstractActor;
import akka.actor.ActorRef;

/**
 * Created by Mainak Ghosh on 6/1/2017.
 */

public class CachingService extends AbstractActor {

    // This router is used both with lookup and deploy of routees. If you
    // have a router with only lookup of routees you can use Props.empty()
    // instead of Props.create(StatsWorker.class).
    ActorRef workerRouter = getContext().actorOf(
            FromConfig.getInstance().props(ReplicatedCache.props()),
            "replicatedCache");

    @Override
    public Receive createReceive() {
        return receiveBuilder()
                .match(ReplicatedCache.PutInCache.class, cmd -> workerRouter.tell(cmd, sender()))
                .match(ReplicatedCache.Evict.class, cmd -> workerRouter.tell(cmd, sender()))
                .match(ReplicatedCache.GetFromCache.class, cmd -> workerRouter.tell(cmd, sender()))
                .build();
    }
}