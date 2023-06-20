using Akka.Actor;
using System;

namespace AkkaLib.CommMsg
{
    public class IntermalMsg
    {
        public class ConnectInfo
        {
            public string Ip { get; private set; } = string.Empty;

            public int Port { get; private set; } = default;

            public ConnectInfo(string ip, int port) => (Ip, Port) = (ip, port);
        }

        public class WriteText
        {
            public string Text { get; private set; } = string.Empty;

            public WriteText(string text) => Text = text;
        }

        public class UWriteText
        {
            public string Text { get; private set; } = string.Empty;

            public UWriteText(string text) => Text = text;
        }

        public class AddWriteTextDelegate
        {
            public Action<long, string> Act { get; private set; } = null;

            public AddWriteTextDelegate(Action<long, string> act) => Act = act;
        }

        public class AddChildActor
        {
            public Action<IUntypedActorContext> Act { get; private set; } = null;

            public AddChildActor(Action<IUntypedActorContext> act) => Act = act;
        }
    }
}
