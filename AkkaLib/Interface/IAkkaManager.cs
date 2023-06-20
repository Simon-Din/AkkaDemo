using Akka.Actor;
using System.Collections.Generic;

namespace AkkaLib.Interface
{
    public interface IAkkaManager
    {
        ActorSystem AkkaSystem { get; }

        IDictionary<long, IActorRef> DicActor { get; }

        IActorRef CreateActor<T>(params object[] args);

        IActorRef CreateActor<T>(IUntypedActorContext context, params object[] args);

        IActorRef GetActorRef(long uid);

        IActorRef GetActorRef(string path);
    }
}
