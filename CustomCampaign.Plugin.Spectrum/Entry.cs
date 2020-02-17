#pragma warning disable IDE0060, RCS1163
using System;
using System.Reflection;
using CustomCampaign.Storage;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;

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
                Plugin.Init();
                Plugin.LoadCampaigns();

                EventSubscriber.SubscribeAll();

                HarmonyInstance Harmony = HarmonyInstance.Create(MOD_ID);
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Plugin.Log.Exception(e);
            }
        }

        internal const string MOD_ID = "com.reherc.customcampaign";
    }
}
