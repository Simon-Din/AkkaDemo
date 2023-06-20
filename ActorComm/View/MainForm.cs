using ActorComm.Actor;
using ActorComm.Model;
using Akka.Actor;
using AkkaLib.Extend;
using AkkaLib.Interface;
using AkkaLib.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static AkkaLib.CommMsg.IntermalMsg;

namespace ActorComm.View
{
    public partial class MainForm : Form
    {
        private enum Mode
        {
            General,
            Server,
            Client
        }

        private readonly IAkkaManager _akkaManager = null;
        private readonly UIBuilder _uiBuild = null; 

        public MainForm()
        {
            InitializeComponent();

            _akkaManager = new AkkaManager("Akka");
            _uiBuild = new UIBuilder();

            //AddServer();
            AddClient();
        }

        private void AddServer() => DoAddActor<SampleTcpSvr>(Mode.Server);

        private void AddClient() => DoAddActor<SampleTcpCli>(Mode.Client);

        private void btn_AddActor_Click(object sender, EventArgs e) => DoAddActor<Sample>();

        #region -- 邏輯處理 --

        /// <summary>
        ///     添加 Actor
        /// </summary>
        private void DoAddActor<T>(Mode mode = Mode.General)
        {
            var actor = _akkaManager.CreateActor<T>();

            actor.Tell(new AddWriteTextDelegate(WriteLog));

            CreateActorTp(actor, mode);
        }

        /// <summary>
        ///     輸出 Actor
        /// </summary>
        private void OutputActorAndConnMsg(out IActorRef actor, out ConnectInfo connInfo, object sender)
        {
            var actorTp = (sender as Button).Parent as TabPage;
            var actorUid = long.Parse(actorTp.Name.Replace($"tp_", ""));
            var ip = (actorTp.Controls.Find($"txt_{actorUid}_Ip", true)[0] as TextBox).Text;
            int.TryParse((actorTp.Controls.Find($"txt_{actorUid}_port", true)[0] as TextBox).Text, out var port);

            actor = GetActor(actorUid, actorTp);
            connInfo = new ConnectInfo(ip, port);
        }

        /// <summary>
        ///     輸出 Actor 與發送的文字訊息
        /// </summary>
        private void OutputActorAndStrMsg(out IActorRef actor, out WriteText writeText, object sender)
        {
            var actorTp = (sender as Button).Parent as TabPage;
            var actorUid = long.Parse(actorTp.Name.Replace($"tp_", ""));
            var text = (actorTp.Controls.Find($"txt_{actorUid}_StrMsg", true)[0] as TextBox).Text;

            actor = GetActor(actorUid, actorTp);
            writeText = new WriteText(text);
        }

        /// <summary>
        ///     輸出 Actor 與建立子 Actor 的訊息
        /// </summary>
        private void OutputActorAndAddChildMsg(out IActorRef actor, out AddChildActor addChildActor, object sender)
        {
            var actorTp = (sender as Button).Parent as TabPage;
            var actorUid = long.Parse(actorTp.Name.Replace($"tp_", ""));

            actor = GetActor(actorUid, actorTp);
            addChildActor = new AddChildActor(AfterCreateChildActor);
        }

        /// <summary>
        ///     依照是否使用路徑決定使用的 Actor 參考
        /// </summary>
        private IActorRef GetActor(long actorUid, TabPage actorTp)
        {
            var path = (actorTp.Controls.Find($"txt_{actorUid}_TargetPath", true)[0] as TextBox).Text;

            if (string.IsNullOrEmpty(path))
                return _akkaManager.GetActorRef(actorUid);
            else
                return _akkaManager.GetActorRef(path);
        }

        #endregion

        #region -- 繪製 UI --

        /// <summary>
        ///     建立 Actor 的 TabPage
        /// </summary>
        private void CreateActorTp(IActorRef actor, Mode mode = Mode.General)
        {
            var actorUid = actor.Path.Uid;
            var actorPath = $"{actor.Path}#{actorUid}";

            var actorTp = _uiBuild.CreateTabPage($"tp_{actorUid}", $"{actorUid}");

            if (mode == Mode.Server || mode == Mode.Client)
            {
                var isRead = mode == Mode.Server;
                var ip = "127.0.0.1";
                var port = mode == Mode.Server ? "3065" : "";

                actorTp.Controls.Add(_uiBuild.CreateLabel($"lb_{actorUid}_Ip", "位址", 6, 9, 70, 23));
                actorTp.Controls.Add(_uiBuild.CreateTextBox($"txt_{actorUid}_Ip", 80, 9, 100, 22, ip, isRead));
                actorTp.Controls.Add(_uiBuild.CreateLabel($"lb_{actorUid}_Port", "通訊埠", 186, 9, 70, 23));
                actorTp.Controls.Add(_uiBuild.CreateTextBox($"txt_{actorUid}_Port", 260, 9, 40, 22, port, isRead));

                if (mode == Mode.Client)
                    actorTp.Controls.Add(_uiBuild.CreateButton($"btn_{actorUid}_Connect", "連線", 304, 8, 100, 23, new EventHandler(Connect)));
            }
            else
            {
                actorTp.Controls.Add(_uiBuild.CreateButton($"btn_{actorUid}_AddActor", "添加Actor", 3, 3, 80, 23, new EventHandler(AddChildActor)));
                //actorTp.Controls.Add(_uiBuild.CreateButton($"btn_{sysName}_{actorUid}_StopActor", "關閉Actor", 82, 3, 80, 23, null));
            }

            actorTp.Controls.Add(_uiBuild.CreateLabel($"lb_{actorUid}_ActorPath", "Actor位址", 6, 32, 70, 23));
            actorTp.Controls.Add(_uiBuild.CreateTextBox($"txt_{actorUid}_ActorPath", 80, 32, 658, 22, actorPath, true));

            actorTp.Controls.Add(_uiBuild.CreateLabel($"lb_{actorUid}_TargetPath", "目標位址", 6, 55, 70, 23));
            actorTp.Controls.Add(_uiBuild.CreateTextBox($"txt_{actorUid}_TargetPath", 80, 55, 658, 22, ""));

            actorTp.Controls.Add(_uiBuild.CreateLabel($"lb_{actorUid}_StrMsg", "文字訊息", 6, 78, 70, 23));
            actorTp.Controls.Add(_uiBuild.CreateTextBox($"txt_{actorUid}_StrMsg", 80, 78, 459, 22, ""));
            actorTp.Controls.Add(_uiBuild.CreateButton($"btn_{actorUid}_Tell", "發送(Tell)", 539, 78, 100, 23, new EventHandler(TellActor)));
            actorTp.Controls.Add(_uiBuild.CreateButton($"btn_{actorUid}_Forward", "發送(Forward)", 638, 78, 100, 23, new EventHandler(TellActor)));
            
            actorTp.Controls.Add(_uiBuild.CreateRichTextBox($"rtb_{actorUid}_Log", 8, 106, 738, 370, ""));

            tc_ActorInfos.Controls.Add(actorTp);
        }

        #endregion

        #region -- 委派事件 --

        private void Connect(object sender, EventArgs e)
        {
            OutputActorAndConnMsg(out var actor, out var connInfo, sender);

            actor.Tell(connInfo);
        }

        /// <summary>
        ///     添加子 Actor
        /// </summary>
        private void AddChildActor(object sender, EventArgs e)
        {
            OutputActorAndAddChildMsg(out var actor, out var addChildActor, sender);

            actor.Tell(addChildActor);
        }

        /// <summary>
        ///     Tell
        /// </summary>
        private void TellActor(object sender, EventArgs e)
        {
            OutputActorAndStrMsg(out var actor, out var writeText, sender);

            actor?.Tell(writeText);
        }

        /// <summary>
        ///     Forward
        /// </summary>
        private void ForwardActor(object sender, EventArgs e)
        {
            OutputActorAndStrMsg(out var actor, out var writeText, sender);

            actor?.Forward(writeText);
        }

        #endregion

        #region -- 異步處理 --

        /// <summary>
        ///     建立子 Actor 後新增 TabPage 及其 UI
        /// </summary>
        private void AfterCreateChildActor(IUntypedActorContext context)
        {
            Invoke(new Action(() => {
                var actor = _akkaManager.CreateActor<Sample>(context);
                var actorUid = actor.Path.Uid;

                actor.Tell(new AddWriteTextDelegate(WriteLog));

                CreateActorTp(actor);
            }));
        }

        /// <summary>
        ///     寫入文字訊息
        /// </summary>
        private void WriteLog(long actorUid, string text)
        {
            Invoke(new Action(() => {
                var rtb = tc_ActorInfos.Controls.Find($"rtb_{actorUid}_Log", true)[0] as RichTextBox;

                rtb.AppendText($"{text}\n");
            }));
        }

        #endregion
    }
}
