#pragma warning disable IDE0060, RCS1163
using System;
using System.Reflection;
using CustomCampaign.Storage;
using Harmony;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using Reactor.API.Runtime.Patching;

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
                Plugin.Init();
                Plugin.LoadCampaigns();

                EventSubscriber.SubscribeAll();

                RuntimePatcher.AutoPatch();
            }
            catch (Exception e)
            {
                Plugin.Log.Exception(e);
            }
        }

        internal const string MOD_ID = "com.reherc.customcampaign";
    }
}
