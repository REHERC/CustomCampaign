using System;
using System.Reflection;
using CustomCampaign.Storage;
using Harmony;
#if API_SPECTRUM
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
#endif
#if API_CENTRIFUGE
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
#endif
#pragma warning disable RCS1163
namespace CustomCampaign
{
#if API_CENTRIFUGE
    [ModEntryPoint(MOD_ID)]
#endif
    public class Entry
#if API_SPECTRUM
        : IPlugin
#endif
    {
        const string MOD_ID = "com.reherc.customcampaign";
#if API_SPECTRUM
        public void Initialize(IManager manager, string ipcIdentifier)
#endif
#if API_CENTRIFUGE
        public void Initialize(IManager manager)
#endif
        {
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
                Console.WriteLine(e.Message);
            }
        }
    }
}
