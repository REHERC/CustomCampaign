using CustomCampaign;
using CustomCampaign.Data;
using System.Collections.Generic;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    public static class CampaignDatabase
    {
        public static List<CampaignInfo> Campaigns;

        public static void Init()
        {
            Campaigns = new List<CampaignInfo>();
        }
    }
}
