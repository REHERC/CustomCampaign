using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.IO;
using CustomCampaign.Data;
using CustomCampaign.API.Events;
using Harmony;

namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        private static bool Initialized = false;

        public static void Init()
        {
            Current.Assemblies = new List<Assembly>();
            Current.AddonInfos = new List<AddonInfo>();
            Current.EventListeners = new Dictionary<ListenerAttribute, IEvent>();
        }

        public static void AddAddon(AddonInfo addon)
        {
            Current.AddonInfos.Add(addon);
        }

        public static void LoadAddons(string id)
        {
            foreach (AddonInfo addon in from item in Current.AddonInfos where item.Id == id select item)
            {
                foreach (string dependency in addon.Dependencies)
                    Current.Assemblies.Add(LoadAssembly(Path.Combine(addon.RootDirectory, dependency)));
                Current.Assemblies.Add(LoadAssembly(Path.Combine(addon.RootDirectory, addon.Module)));
            }
            foreach (Assembly assembly in Current.Assemblies)
                foreach (Type type in assembly.GetTypes())
                    if (type.IsAssignableFrom(typeof(IEvent)))
                    {
                        ListenerAttribute attribute = Attribute.GetCustomAttribute(type, typeof(ListenerAttribute)) as ListenerAttribute;
                        if (!(attribute is null))
                            Current.EventListeners.Add(attribute, Activator.CreateInstance(type) as IEvent);
                    }
            Initialized = true;
        }

        public static void CreateDomain()
        {
            Current.Domain = AppDomain.CreateDomain("customcampaign.addons");
        }

        public static void DestroyDomain()
        {
            Current.Assemblies.Clear();
            Current.EventListeners.Clear();
            AppDomain.Unload(Current.Domain);
            Initialized = false;
        }

        private static Assembly LoadAssembly(string path)
        {
            return Current.Domain.Load(path);
        }
    }
}
