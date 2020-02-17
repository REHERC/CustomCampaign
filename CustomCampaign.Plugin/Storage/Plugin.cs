#pragma warning disable SecurityIntelliSenseCS
#if API_SPECTRUM
using Spectrum.API.Logging;
using Spectrum.API.Storage;
#endif
#if API_CENTRIFUGE
using Reactor.API.Logging;
using Reactor.API.Storage;
#endif
using System.IO;
using CustomCampaign.Data;
using CustomCampaign.Systems;

namespace CustomCampaign.Storage
{
    internal static partial class Plugin
    {
        internal static FileSystem Files;
#if API_SPECTRUM
        internal static Logger Log { get; set; }
#endif
#if API_CENTRIFUGE
        internal static Log Log { get; set; }
#endif
        internal static void Init()
        {
            Files = new FileSystem();
#if API_SPECTRUM
            Log = new Logger("CustomCampaign")
            {
                WriteToConsole = true,
                ColorizeLines = true
            };
#endif
#if API_CENTRIFUGE
            Log = LogManager.GetForCurrentAssembly();
#endif
        }

        internal static void LoadCampaigns()
        {
            string campaign_root = Variables.CampaignsDataFolder();
            foreach (var campaign_directory in Directory.GetDirectories(campaign_root))
            {
                string campaign_json = $"{campaign_directory}/campaign.json".NormPath(true);
                Models.Campaign campaign = Models.Campaign.FromFile(campaign_json);
                if (campaign && campaign.Validate(campaign_directory))
                {
                    CampaignInfo campaign_info = new CampaignInfo(campaign_directory.NormPath(false), campaign);
                    foreach (var level in campaign.levels)
                        level.file = new FileInfo(Path.Combine(campaign_directory, level.file)).FullName;

                    foreach (var addon in campaign.addons)
                    {
                        addon.module = new FileInfo(Path.Combine(campaign_directory, addon.module)).FullName;
                        for (int i = 0; i < addon.dependencies.Count; i++)
                            addon.dependencies[i] = new FileInfo(Path.Combine(campaign_directory, addon.dependencies[i])).FullName;
                    }
                    AddonSystem.RegisterCampaign(campaign_info);
                    Campaigns.Add(campaign_info);
                }
            }
            AddonSystem.LoadAddons();
            LevelEditor.Initialize();
        }
    }
}
