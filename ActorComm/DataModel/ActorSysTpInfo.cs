using AkkaLib.Interface;

namespace ActorComm.DataModel
{
    public class ActorSysTpInfo
    {
        public string SysName { get; private set; } = string.Empty;

        public string SysTpName { get; private set; } = string.Empty;

        public IAkkaManager Manager { get; private set; } = null;

        public ActorSysTpInfo(string sysName, string sysTpName, IAkkaManager manager)
            => (SysName, SysTpName, Manager) = (sysName, sysTpName, manager);
    }
}
