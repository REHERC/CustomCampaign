using System;
using System.Reflection;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Storage;

namespace CustomCampaign
{
    public class Entry : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            try
            {
                Plugin.Files = new FileSystem();
                SharedResources.Init();
                HarmonyInstance Harmony = HarmonyInstance.Create($"com.CustomCampaign.{ipcIdentifier}");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());

                Tests.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static class Plugin
    {
        public static FileSystem Files;
    }
}
