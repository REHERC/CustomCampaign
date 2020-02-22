#pragma warning disable SecurityIntelliSenseCS, CS0436, CA1031
using CustomCampaign.Models;
using CustomCampaign.Storage;
using Photon.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpCompress.Archives.Zip;
using System;
#if JSON_NEWTONSOFT
using Newtonsoft.Json;
#endif
#if JSON_LITJSON
using LitJson;
#endif

namespace CustomCampaign.Systems
{
    internal static class PreloaderSystem
    {
        internal static void PrepareCampaigns()
        {
            Dictionary<string, KeyValuePair<long, string>> installed_campaigns = new Dictionary<string, KeyValuePair<long, string>>();
            Dictionary<string, KeyValuePair<long, string>> packaged_campaigns = new Dictionary<string, KeyValuePair<long, string>>();

            DirectoryInfo campaign_root = new DirectoryInfo(Variables.CampaignsDataFolder());

            // List installed campaigns
            foreach (DirectoryInfo installed in campaign_root.GetDirectories())
            {
                FileInfo manifest_file = new FileInfo(Path.Combine(installed.FullName, "campaign.json"));
                if (manifest_file.Exists)
                {
                    Serializer<Campaign> manifest = new Serializer<Campaign>(SerializerType.Json, manifest_file.FullName, true);
                    installed_campaigns[manifest.Data.guid] = new KeyValuePair<long, string>(manifest.Data.build, installed.FullName);
                    Plugin.Log.Warning($"Campaign installation detected: {manifest.Data.name} ({manifest.Data.guid}_{manifest.Data.build})");
                }
            }
            Plugin.Log.Error($"{installed_campaigns.Count} installed campaign(s) detected");

            // List packaged campaigns
            foreach (FileInfo packaged in campaign_root.GetFiles("*.campaign", SearchOption.TopDirectoryOnly))
            {
                Plugin.Log.Warning($"Reading {packaged.Name}");

                try
                {
                    using (ZipArchive archive = ZipArchive.Open(packaged))
                    {
                        foreach (ZipArchiveEntry entry in from item in archive.Entries where string.Equals(item.Key, "manifest", StringComparison.InvariantCultureIgnoreCase) select item)
                        {
                            string manifest_data = entry.ReadContent();
                            Manifest manifest = null;
#if JSON_NEWTONSOFT
                            manifest = JsonConvert.DeserializeObject<Manifest>(manifest_data);
#endif
#if JSON_LITJSON
                            manifest = JsonMapper.ToObject<Manifest>(manifest_data);
#endif
                            Plugin.Log.Warning($"Campaign package: {packaged.Name} ({manifest.guid}_{manifest.build})");
                            if (manifest is null)
                            {
                                break;
                            }
                            else
                            {
                                if (packaged_campaigns.ContainsKey(manifest.guid))
                                {
                                    long listed_version = packaged_campaigns[manifest.guid].Key;
                                    if (manifest.build > listed_version)
                                    {
                                        Plugin.Log.Warning($"Updating {manifest.name} ({manifest.guid}_{manifest.build})");
                                        packaged_campaigns[manifest.guid] = new KeyValuePair<long, string>(manifest.build, packaged.FullName);
                                        break;
                                    }
                                }
                                else
                                {
                                    if (!installed_campaigns.ContainsKey(manifest.guid) || manifest.build > installed_campaigns[manifest.guid].Key)
                                    {
                                        Plugin.Log.Warning($"Adding {manifest.name} ({manifest.guid}_{manifest.build})");
                                        packaged_campaigns[manifest.guid] = new KeyValuePair<long, string>(manifest.build, packaged.FullName);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Plugin.Log.Exception(e);
                }
            }
            Plugin.Log.Error($"{packaged_campaigns.Count} packaged campaign(s) registered");

            // Extract campaigns and update already installed ones if needed
            foreach (var package in packaged_campaigns)
            {
                FileInfo campaign_package = new FileInfo(package.Value.Value);
                if (installed_campaigns.ContainsKey(package.Key))
                {
                    if (package.Value.Key > installed_campaigns[package.Key].Key)
                    {
                        DirectoryInfo extract_dir = new DirectoryInfo(installed_campaigns[package.Key].Value);

                        ExtractCampaign(campaign_package, extract_dir, package.Value.Key);
                    }
                }
                else
                {
                    string extract_dir = Path.Combine(campaign_root.FullName, package.Key);

                    ExtractCampaign(campaign_package, new DirectoryInfo(extract_dir), package.Value.Key);
                }
            }
        }

        internal static void ExtractCampaign(FileInfo archive_path, DirectoryInfo extract_path, long package_build = 0)
        {
            Plugin.Log.Info($"Extracting \"{archive_path.FullName}\" to \"{extract_path.FullName}\"");

            FileInfo campaign_manifest_file = new FileInfo(Path.Combine(extract_path.FullName, "campaign.json"));

            Plugin.Log.Info($"Searching for file: \"{campaign_manifest_file.FullName}\"");

            if (campaign_manifest_file.Exists)
            {
                Plugin.Log.Warning($"Campaign manifest file found: \"{campaign_manifest_file.FullName}\"");

                Serializer<Campaign> campaign_manifest = new Serializer<Campaign>(SerializerType.Json, campaign_manifest_file.FullName, true);

                Plugin.Log.Warning($"Installed version: {campaign_manifest.Data.build}");
                Plugin.Log.Warning($"Packaged version  : {package_build}");

                if (package_build <= campaign_manifest.Data.build)
                {
                    Plugin.Log.Error($"Package build inferior to installed version, skipping extraction.");
                }
            }

            if (!extract_path.Exists)
            {
                extract_path.Create();
            }

            using (ZipArchive archive = ZipArchive.Open(archive_path.FullName))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (!entry.IsDirectory && entry.Key.StartsWith("data/", StringComparison.OrdinalIgnoreCase))
                    {
                        string relative_name = entry.Key.Substring("data/".Length);
                        FileInfo extract = new FileInfo(Path.Combine(extract_path.FullName, $"{relative_name}"));

                        if (!extract.Directory.Exists)
                        {
                            extract.Directory.Create();
                        }

                        Plugin.Log.Info($"Extracting file: \"{entry.Key}\" to \"{extract.FullName}\"");
                        entry.ExtractToFile(extract.FullName, true);
                    }
                }
            }
        }
    }
}