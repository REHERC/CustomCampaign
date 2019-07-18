using CustomCampaign.Data;
using System.Collections.Generic;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    public static class CampaignDatabase
    {
        public static Dictionary<string, CampaignInfo> Campaigns { get; private set; } = new Dictionary<string, CampaignInfo>();

        public static Dictionary<string, Models.Level> Levels
        {
            get
            {
                Dictionary<string, Models.Level> result = new Dictionary<string, Models.Level>();
                foreach (CampaignInfo campaign in Campaigns.Values)
                    foreach (Models.Level level in campaign.Levels)
                        result.Add(campaign.DataDirectory.NormPath(false), level);
                return result;
            }
        }

        public static List<string> LevelPaths
        {
            get
            {
                List<string> result = new List<string>();
                foreach (var campaign in Campaigns)
                    foreach (Models.Level level in campaign.Value.Levels)
                        result.Add(level.file.NormPath(true));
                return result;
            }
        }

        public static void Add(CampaignInfo campaign) => Campaigns.Add(campaign.DataDirectory.NormPath(false), campaign);
    }
}
