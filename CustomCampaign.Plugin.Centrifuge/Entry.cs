#pragma warning disable IDE0060, RCS1163, CA1822, CA1031, RCS1129
using CustomCampaign.Storage;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using Reactor.API.Runtime.Patching;
using System;

namespace CustomCampaign
{
    [ModEntryPoint(MOD_ID)]
    public class Entry
    {
        public static IManager Manager = null;

        public void Initialize(IManager manager)
        {
            Manager = manager;
        }

        public void Start()
        {
            try
            {
                RuntimePatcher.AutoPatch();

                Plugin.Init();
                Events.Managers.GameManagerLoaded.Subscribe(OnGameManagerLoaded);

                EventSubscriber.SubscribeAll();
            }
            catch (Exception e)
            {
                Plugin.Log.Exception(e);
            }
        }

        public void OnGameManagerLoaded(Events.Managers.GameManagerLoaded.Data data)
        {
            // TL;DR Delayed initialization of campaigns so the unity subsystems can load
            // This is to avoid fatal errors when using Texture2D instances
            // This is due to Centrifuge hooking to some unity call 
            // and initializing mods when unity hasn't finished loading

            Events.Managers.GameManagerLoaded.Unsubscribe(OnGameManagerLoaded);
            Plugin.LoadCampaigns();
        }

        internal const string MOD_ID = "com.reherc.customcampaign";
    }
}
