using Spectrum.API.Logging;
using Spectrum.API.Storage;
using System.IO;
using CustomCampaign.Data;

namespace CustomCampaign.Storage
{
    public static partial class Plugin
    {
        public static FileSystem Files;
        public static Logger Log;

        public static void Init()
        {
            Files = new FileSystem();
            Log = new Logger("CustomCampaign")
            {
                WriteToConsole = true,
                ColorizeLines = true
            };
        }

        public static void LoadCampaigns()
        {
            string campaign_root = Variables.CampaignsDataFolder();
            foreach (string campaign_directory in Directory.GetDirectories(campaign_root))
            {
                string campaign_json = $"{campaign_directory}/campaign.json".NormPath(true);
                Models.Campaign campaign = Models.Campaign.FromFile(campaign_json);
                if (campaign)
                {
                    CampaignInfo campaign_info = new CampaignInfo(campaign_directory.NormPath(false), campaign);
                    foreach (Models.Level level in campaign.levels)
                    {
                        level.file = Resource.NormalizePath(new FileInfo(Path.Combine(campaign_directory, level.file)).FullName.NormPath(true));
                        campaign_info.Levels.Add(level);
                    }
                    CampaignDatabase.Add(campaign_info);
                }
            }
        }
    }
}
