using CustomCampaign.Data;
using System.Collections.Generic;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    internal static class CampaignDatabase
    {
        internal static Dictionary<string, CampaignInfo> Campaigns { get; private set; } = new Dictionary<string, CampaignInfo>();

        internal static Dictionary<CampaignInfo, Models.Level> Levels
        {
            get
            {
                Dictionary<CampaignInfo, Models.Level> result = new Dictionary<CampaignInfo, Models.Level>();
                foreach (CampaignInfo campaign in Campaigns.Values)
                    foreach (Models.Level level in campaign.Levels)
                        if (!result.ContainsKey(campaign))
                            result.Add(campaign, level);
                return result;
            }
        }

        internal static List<string> LevelPaths
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

        internal static void Add(CampaignInfo campaign) => Campaigns.Add(campaign.Location.NormPath(false), campaign);
    }
}
