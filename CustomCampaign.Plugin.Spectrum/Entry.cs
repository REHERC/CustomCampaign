#pragma warning disable IDE0060, RCS1163, CA1031
using CustomCampaign.Storage;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using System;
using System.Reflection;

namespace CustomCampaign
{
    public class Entry : IPlugin
    {
        public static IManager Manager = null;

        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Manager = manager;
            try
            {
                HarmonyInstance Harmony = HarmonyInstance.Create(MOD_ID);
                Harmony.PatchAll(Assembly.GetExecutingAssembly());

                Plugin.Init();
                Plugin.LoadCampaigns();

                EventSubscriber.SubscribeAll();
            }
            catch (Exception e)
            {
                Plugin.Log.Exception(e);
            }
        }

        internal const string MOD_ID = "com.reherc.customcampaign";
    }
}
