using System.Collections.Generic;
using System.Reflection;

namespace CustomCampaign
{
    public static class ModLoader
    {
        public static List<AddonInfo> AddonInfos;
        public static Dictionary<string, Assembly> Assemblies;

        public static void Init()
        {
            Assemblies = new Dictionary<string, Assembly>();
            AddonInfos = new List<AddonInfo>();
        }

        public static void AddAddon(AddonInfo addon)
        {
            AddonInfos.Add(addon);
        }

        public static void LoadAddons()
        {
            foreach (AddonInfo addon in AddonInfos)
            {
                foreach (string dependency in addon.Dependencies)
                    LoadAssembly(dependency, addon.Id);
                LoadAssembly(addon.Module, addon.Id);
            }
        }

        private static void LoadAssembly(string path, string id)
        {
            Assemblies.Add(id, Assembly.LoadFrom(path));
        }
    }
}
