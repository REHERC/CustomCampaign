using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CustomCampaign.SDK.API;
using System.IO;

namespace CustomCampaign
{
    public static class ModLoader
    {
        private static bool Initialized = false;

        public static void Init()
        {
            AddonSystem.Assemblies = new List<Assembly>();
            AddonSystem.AddonInfos = new List<AddonInfo>();
            AddonSystem.EventListeners = new Dictionary<ListenerAttribute, IEvent>();
        }

        public static void AddAddon(AddonInfo addon)
        {
            AddonSystem.AddonInfos.Add(addon);
        }

        public static void LoadAddons(string id)
        {
            foreach (AddonInfo addon in from item in AddonSystem.AddonInfos where item.Id == id select item)
            {
                foreach (string dependency in addon.Dependencies)
                    AddonSystem.Assemblies.Add(LoadAssembly(Path.Combine(addon.RootDirectory, dependency)));
                AddonSystem.Assemblies.Add(LoadAssembly(Path.Combine(addon.RootDirectory, addon.Module)));
            }
            foreach (Assembly assembly in AddonSystem.Assemblies)
                foreach (Type type in assembly.GetTypes())
                    if (type.IsAssignableFrom(typeof(IEvent)))
                    {
                        ListenerAttribute attribute = Attribute.GetCustomAttribute(type, typeof(ListenerAttribute)) as ListenerAttribute;
                        if (!(attribute is null))
                            AddonSystem.EventListeners.Add(attribute, Activator.CreateInstance(type) as IEvent);
                    }
            Initialized = true;
        }

        private static void CreateDomain()
        {
            AddonSystem.Domain = AppDomain.CreateDomain("customcampaign.addons");
        }

        private static void DestroyDomain()
        {
            AddonSystem.Assemblies.Clear();
            AddonSystem.EventListeners.Clear();
            AppDomain.Unload(AddonSystem.Domain);
            Initialized = false;
        }

        private static Assembly LoadAssembly(string path)
        {
            return AddonSystem.Domain.Load(path);
        }
    }
}
