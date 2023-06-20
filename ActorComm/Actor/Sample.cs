using Akka.Actor;
using AkkaLib.Base;
using System;
using static AkkaLib.CommMsg.IntermalMsg;

namespace ActorComm.Actor
{
    public class Sample : BaseActor
    {
        private readonly long _uid = default;

        private Action<long, string> _action = null;

        public Sample()
        {
            _uid = Self.Path.Uid;

            Receive<WriteText>(Handle_WriteText);
            Receive<AddWriteTextDelegate>(Handle_AddWriteTextDelegate);
            Receive<AddChildActor>(Handle_AddChildActor);
            ReceiveAny(Handle_Any);
        }

        /// <summary>
        ///     寫入 log
        /// </summary>
        private void Handle_WriteText(WriteText msg)
        {
            _action?.Invoke(_uid, msg.Text);

            foreach (var child in Context.GetChildren())
                child.Tell(new WriteText($"Father say : {msg.Text}"));

            //if (Context.Parent.Path.Uid == 0)
            //    Sender.Tell(new WriteText($"Child say : FQ"));
        }

        /// <summary>
        ///     加入寫入委派
        /// </summary>
        private void Handle_AddWriteTextDelegate(AddWriteTextDelegate msg) => _action = msg?.Act;

        /// <summary>
        ///     加入添加子 Actor 委派
        /// </summary>
        private void Handle_AddChildActor(AddChildActor msg) => msg.Act.Invoke(Context);

        /// <summary>
        ///     未定義訊息處理
        /// </summary>
        private void Handle_Any(object msg) => _action?.Invoke(_uid, $"The message isn't defined, type name={msg.GetType().Name}");
    }
}
