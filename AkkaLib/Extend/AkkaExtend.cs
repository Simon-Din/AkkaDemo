using Akka.Actor;
using static AkkaLib.CommMsg.IntermalMsg;

namespace AkkaLib.Extend
{
    public static class AkkaExtend
    {
        public static IActorRef AddDelegate(this IActorRef actor, AddWriteTextDelegate msg)
        {
            actor?.Tell(msg);

            return actor;
        }
    }
}
