using Akka.Actor;
using Akka.Configuration;
using AkkaLib.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AkkaLib.Model
{
    public class AkkaManager : IAkkaManager
    {
        private Lazy<ActorSystem> _lazyAkkaSystem = null;

        public ActorSystem AkkaSystem { get => _lazyAkkaSystem.Value; private set => AkkaSystem = value; }

        //public ActorSystem AkkaSystem { get; private set; }

        public IDictionary<long, IActorRef> DicActor { get; private set; } = null;

        public AkkaManager(string name, Config config = null)
        {
            DicActor = new Dictionary<long, IActorRef>();

            CreateActorSystem(name, config);
        }

        public IActorRef CreateActor<T>(params object[] args)
        {
            var actor = AkkaSystem.ActorOf(Props.Create(typeof(T), args));
            var uid = actor.Path.Uid;

            DicActor.Add(uid, actor);

            return DicActor[uid];
        }

        public IActorRef CreateActor<T>(IUntypedActorContext context, params object[] args)
        {
            var actor = context.ActorOf(Props.Create(typeof(T), args));
            var uid = actor.Path.Uid;

            DicActor.Add(uid, actor);

            return DicActor[uid];
        }

        public IActorRef GetActorRef(long uid)
        {
            if (!DicActor.ContainsKey(uid))
                return null;

            return DicActor[uid];
        }

        public IActorRef GetActorRef(string path)
        {
            try
            {
                var a = AkkaSystem.ActorSelection(path).ResolveOne(TimeSpan.FromSeconds(5)).Result;

                return a;
            }
            catch
            {
                return null;
            }
        }

        private void CreateActorSystem(string sysName, Config config)
        {
            if (config != null)
                _lazyAkkaSystem = new Lazy<ActorSystem>(() => ActorSystem.Create(sysName, config));
            else
                _lazyAkkaSystem = new Lazy<ActorSystem>(() => ActorSystem.Create(sysName));

            //if (config != null)
            //    AkkaSystem = ActorSystem.Create(sysName, config);
            //else
            //    AkkaSystem = ActorSystem.Create(sysName);
        }
    }
}
