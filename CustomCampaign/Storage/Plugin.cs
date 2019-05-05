using Spectrum.API.Logging;
using Spectrum.API.Storage;
using System.Collections.Generic;
using System.IO;

namespace CustomCampaign
{
    public static partial class Plugin
    {
        public static FileSystem Files;
        public static Logger Log;

        public static void Init()
        {
            Files = new FileSystem();
            Log = new Logger("CustomCampaign.log")
            {
                WriteToConsole = false,
                ColorizeLines = true
            };
        }

        public static void LoadCampaigns()
        {
            string campaign_root = Variables.CampaignsDataFolder();
            string extract_root = Variables.LevelsDirectory();
            foreach (string campaign_directory in Directory.GetDirectories(campaign_root))
            {
                string campaign_pak = $"{campaign_directory}/Campaign.json";
                if (File.Exists(campaign_pak) && Campaign.Validate(campaign_pak))
                {
                    Campaign campaign_data = Campaign.FromFile(campaign_pak);
                    CampaignInfo campaign_info = new CampaignInfo(campaign_directory, extract_root, campaign_data);
                    foreach (Campaign.Level level in campaign_data.levels)
                    {
                        string level_filename = new List<string>(level.file.NormPath().Split('/')).Last().LowerCase();
                        string data_filename = $"{campaign_directory}/{level.file}".NormPath();
                        string docs_filename = $"{campaign_info.GetDocsPath()}/{level_filename}".NormPath();
                        Extensions.MakeDirectory(campaign_info.GetDocsPath());
                        Extensions.CopyFile(data_filename, docs_filename);
                        Extensions.CopyFile(data_filename + ".png", docs_filename + ".png");
                        Campaign.Level level_info = new Campaign.Level(
                            docs_filename,
                            level.levelname,
                            level.levelname_sub,
                            $"{campaign_directory}/{level.loading_wallpaper}".NormPath(),
                            level.loading_text
                        );
                        campaign_info.Levels.Add(level_info);
                    }
                    foreach (string addon in campaign_data.addons)
                    {
                        AddonInfo addon_info = AddonInfo.Load(campaign_info, addon);
                        ModLoader.AddAddon(addon_info);
                    }
                    campaign_info.Print();
                    CampaignDatabase.Campaigns.Add(campaign_info);
                }
            }
        }
    }
}
