using System;
using System.Reflection;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;

#pragma warning disable RCS1163
namespace CustomCampaign
{
    public class Entry : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            try
            {
                Plugin.Init();
                CampaignDatabase.Init();
                Plugin.LoadCampaigns();

                EventSubscriber.SubscribeAll();

                HarmonyInstance Harmony = HarmonyInstance.Create($"com.CustomCampaign.{ipcIdentifier}");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
