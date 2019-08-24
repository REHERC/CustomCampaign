using CustomCampaign.Api;
using CustomCampaign.Data;
using CustomCampaign.Storage;
using System;
using System.Collections.Generic;
using System.Reflection;

#pragma warning disable IDE0044

namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        #region Important Data
        private static Dictionary<Assembly, string> Assemblies = new Dictionary<Assembly, string>();
        private static Dictionary<Addon, string> Addons = new Dictionary<Addon, string>();
        #endregion
        #region Temporary Lists
        private static Dictionary<string, string> Modules = new Dictionary<string, string>();
        private static Dictionary<string, string> Requisites = new Dictionary<string, string>();
        private static Dictionary<string, string> Dependencies = new Dictionary<string, string>();
        #endregion

        public static void RegisterCampaign(CampaignInfo campaign)
        {
            List<string> modules = new List<string>(), 
                         requisites = new List<string>(), 
                         dependencies = new List<string>();

            campaign.Addons.ForEach((addon) => {
                modules.Add(addon.module);
                dependencies.AddRange(addon.dependencies);
            });

            foreach (string dependency in dependencies.ToArray())
            {
                if (modules.Contains(dependency))
                {
                    modules.Remove(dependency);
                    dependencies.Remove(dependency);
                    requisites.Add(dependency);
                }
            }

            FillList(campaign, ref modules, ref Modules);
            FillList(campaign, ref requisites, ref Requisites);
            FillList(campaign, ref dependencies, ref Dependencies);
        }
        private static void FillList(CampaignInfo campaign, ref List<string> source, ref Dictionary<string, string> dest)
        {
            foreach (string item in source)
                if (!dest.ContainsKey(item))
                    dest.Add(item, campaign.Id);
        }
        private static void AddAssembly(Assembly assembly, string id) => Assemblies.Add(assembly, id);
        public static void LoadAddons()
        {
            LoadAddons(ref Dependencies);
            LoadAddons(ref Requisites);
            LoadAddons(ref Modules);
        }
        private static void LoadAddons(ref Dictionary<string, string> files)
        {
            foreach (var item in files)
            {
                CampaignInfo info = Util.GetCampaignByGuid(item.Value);

                try
                {
                    if (info.Enabled)
                        AddAssembly(Assembly.LoadFrom(item.Key), item.Value);
                }
                catch (Exception e)
                {
                    if (info != null && info.Enabled)
                    {
                        Plugin.Log.Error($"Couldn't load target module assembly \"{item.Key}\" for campaign \"{info.Name}\". The exception has been silently logged and the campaign is disabled.");
                        Plugin.Log.ExceptionSilent(e);

                        info.SetEnabled(false);
                    }
                }
            }

            foreach (var item in Assemblies)
            {
                CampaignInfo info = Util.GetCampaignByGuid(item.Value);

                if (info.Enabled)
                    LoadAddons(item.Key, item.Value);
            }
        }
        private static void LoadAddons(Assembly assembly, string id)
        {
            foreach(Type type in assembly.GetExportedTypes())
            {
                if (type.IsSubclassOf(typeof(Addon)))
                    if (Activator.CreateInstance(type) is Addon addon)
                        Addons.Add(addon, id);
            }
        }
    }
}
