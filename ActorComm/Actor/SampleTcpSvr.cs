using Akka.Actor;
using Akka.IO;
using AkkaLib.Base;
using System;
using System.Net;
using static AkkaLib.CommMsg.IntermalMsg;

namespace ActorComm.Actor
{
    public class SampleTcpSvr : BaseActor
    {
        private readonly long _uid = default;

        private Action<long, string> _action = null;

        public SampleTcpSvr()
        {
            _uid = Self.Path.Uid;

            Receive<Tcp.Bound>(msg => Handle_Tcp_Bound(msg));
            Receive<Tcp.Received>(msg => Handle_Tcp_Received(msg));
            Receive<Tcp.Connected>(msg => Handle_Tcp_Connected(msg));
            Receive<Tcp.CommandFailed>(msg => Handle_Tcp_CommandFailed(msg));
            Receive<Tcp.ConnectionClosed>(msg => Handle_Tcp_ConnectionClosed(msg));
            Receive<WriteText>(Handle_WriteText);
            Receive<AddWriteTextDelegate>(Handle_AddWriteTextDelegate);
            Receive<AddChildActor>(Handle_AddChildActor);
            ReceiveAny(Handle_Any);

            Context.System.Tcp().Tell(new Tcp.Bind(Self, new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3065)));
        }

        /// <summary>
        ///     Tcp 綁定完成
        /// </summary>
        private void Handle_Tcp_Bound(Tcp.Bound msg)
        {
            var s = "";
        }

        /// <summary>
        ///     Tcp 接收
        /// </summary>
        private void Handle_Tcp_Received(Tcp.Received msg)
        {
            _action?.Invoke(_uid, msg.Data.ToString());
        }

        /// <summary>
        ///     Tcp 連線
        /// </summary>
        private void Handle_Tcp_Connected(Tcp.Connected msg)
        {
            Sender.Tell(new Tcp.Register(Self));
        }

        /// <summary>
        ///     Tcp 連線異常
        /// </summary>
        private void Handle_Tcp_CommandFailed(Tcp.CommandFailed msg)
        {
            var s = "";
        }

        /// <summary>
        ///     Tcp 連線關閉
        /// </summary>
        private void Handle_Tcp_ConnectionClosed(Tcp.ConnectionClosed msg)
        {
            var s = "";
        }

        /// <summary>
        ///     寫入 log
        /// </summary>
        private void Handle_WriteText(WriteText msg) => _action?.Invoke(_uid, msg.Text);

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
