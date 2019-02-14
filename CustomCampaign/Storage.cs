using CustomCampaign;
using System.Collections.Generic;

public static class Storage
{
    public static List<CampaignInfo> Campaigns;

    public static void Init()
    {
        Campaigns = new List<CampaignInfo>();
    }
}
