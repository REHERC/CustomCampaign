using System;
using System.IO;
using System.Reflection;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;

namespace CustomCampaign
{
    public class Entry : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            SharedResources.Init();
            HarmonyInstance Harmony = HarmonyInstance.Create($"com.CustomCampaign.{ipcIdentifier}");
            Harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
