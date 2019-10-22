#pragma warning disable IDE0060, RCS1163
using System;
using System.Reflection;
using CustomCampaign.Storage;
using Harmony;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;

namespace CustomCampaign
{
    [ModEntryPoint(MOD_ID)]
    public class Entry
    {
        public void Initialize(IManager manager)
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

        internal const string MOD_ID = "com.reherc.customcampaign";
    }
}
