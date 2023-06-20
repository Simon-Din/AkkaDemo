using Akka.Actor;
using System;

namespace AkkaLib.Base
{
    public class BaseActor : ReceiveActor
    {
        public BaseActor()
        {
        }

        /// <summary>
        ///     實例化執行
        /// </summary>
        protected override void PreStart()
        {
            base.PreStart();
        }

        /// <summary>
        ///     正常終止後執行
        /// </summary>
        protected override void PostStop()
        {
            base.PostStop();
        }

        /// <summary>
        ///     異常重啟前保存當前狀態
        /// </summary>
        protected override void PreRestart(Exception reason, object message)
        {
            base.PreRestart(reason, message);
        }

        /// <summary>
        ///     異常重啟後恢復重啟前保存的狀態
        /// </summary>
        protected override void PostRestart(Exception reason)
        {
            base.PostRestart(reason);
        }
    }
}
