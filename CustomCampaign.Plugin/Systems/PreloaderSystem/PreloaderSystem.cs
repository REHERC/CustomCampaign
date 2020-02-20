#pragma warning disable SecurityIntelliSenseCS, CS0436, CA1031
using CustomCampaign.Models;
using CustomCampaign.Storage;
using Photon.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpCompress.Archives.Zip;
using static SharpCompress.Archives.IArchiveExtensions;
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
                }
            }

            // List packaged campaigns
            foreach (FileInfo packaged in campaign_root.GetFiles("*.campaign", SearchOption.TopDirectoryOnly))
            {
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
                                        packaged_campaigns[manifest.guid] = new KeyValuePair<long, string>(manifest.build, packaged.FullName);
                                    }
                                }
                                else
                                {
                                    packaged_campaigns.Add(manifest.guid, new KeyValuePair<long, string>(manifest.build, packaged.FullName));
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

            // Extract campaigns and update already installed ones if needed
            foreach (var package in packaged_campaigns)
            {
                if (installed_campaigns.ContainsKey(package.Key))
                {
                    if (package.Value.Key > installed_campaigns[package.Key].Key)
                    {
                        using (ZipArchive archive = ZipArchive.Open(package.Value.Value))
                        {
                            archive.WriteToDirectory(installed_campaigns[package.Key].Value);
                        }
                    }
                }
                else
                {
                    using (ZipArchive archive = ZipArchive.Open(package.Value.Value))
                    {
                        archive.WriteToDirectory(installed_campaigns[package.Key].Value);
                    }
                }
            }
        }
    }
}