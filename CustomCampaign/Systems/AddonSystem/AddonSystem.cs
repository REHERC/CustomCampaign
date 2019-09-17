using CustomCampaign.Data;
using CustomCampaign.Models;
using CustomCampaign.Storage;
using System;
using System.Collections.Generic;
using System.Reflection;

#pragma warning disable IDE0044

namespace CustomCampaign.Systems
{
    internal static partial class AddonSystem
    {
        #region Important Data
        private static Dictionary<ObjectWithGUID<Assembly>, string> Assemblies = new Dictionary<ObjectWithGUID<Assembly>, string>();
        private static Dictionary<ObjectWithGUID<Api.Addon>, string> Addons = new Dictionary<ObjectWithGUID<Api.Addon>, string>();
        #endregion
        #region Temporary Lists
        private static Dictionary<string, string> Modules = new Dictionary<string, string>();
        private static Dictionary<string, string> Requisites = new Dictionary<string, string>();
        private static Dictionary<string, string> Dependencies = new Dictionary<string, string>();
        #endregion

        internal static void RegisterCampaign(CampaignInfo campaign)
        {
            Plugin.Log.Warning($"Registering campaign {campaign.Name}");

            if (campaign.Addons.Count < 1) return;

            Plugin.Log.Info($"This campaign has {campaign.Addons.Count} addon{(campaign.Addons.Count > 1 ? "s" : "")}");
            foreach (var addon in campaign.Addons)
                Plugin.Log.Info($"{addon.name}");

            var modules = new List<string>();
            var requisites = new List<string>(); 
            var dependencies = new List<string>();

            foreach (var addon in campaign.Addons)
            {
                modules.Add(addon.module);
                dependencies.AddRange(addon.dependencies);
            }

            foreach (var dependency in dependencies)
            {
                if (modules.Contains(dependency))
                {
                    modules.Remove(dependency);
                    dependencies.Remove(dependency);
                    requisites.Add(dependency);
                }
            }

            FillList(campaign, modules, Modules);
            FillList(campaign, requisites, Requisites);
            FillList(campaign, dependencies, Dependencies);
        }
        private static void FillList(CampaignInfo campaign, List<string> source, Dictionary<string, string> dest)
        {
            foreach (var item in source)
                if (!dest.ContainsKey(item))
                    dest.Add(item, campaign.Id);
        }
        private static void AddAssembly(Assembly assembly, string id) => Assemblies.Add(ObjectWithGUID<Assembly>.Create(assembly), id);
        internal static void LoadAddons()
        {
            LoadAddons(Dependencies);
            LoadAddons(Requisites);
            LoadAddons(Modules);

            InitializeAddons();
        }
        private static void LoadAddons(Dictionary<string, string> files)
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
                        Plugin.Log.Error($"Couldn't load target module assembly \"{item.Key}\" for campaign \"{info.Name}\". The exception has been silently logged and the campaign has been disabled.");
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
            foreach(var type in assembly.GetExportedTypes())
                if (type.IsSubclassOf(typeof(Api.Addon)))
                    if (Activator.CreateInstance(type) is Api.Addon addon)
                        Addons.Add(ObjectWithGUID<Api.Addon>.Create(addon), id);
        }
    }
}
