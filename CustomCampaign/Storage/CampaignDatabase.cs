﻿using CustomCampaign;
using System.Collections.Generic;

#pragma warning disable RCS1110
public static class CampaignDatabase
{
    public static List<CampaignInfo> Campaigns;

    public static void Init()
    {
        Campaigns = new List<CampaignInfo>();
    }
}