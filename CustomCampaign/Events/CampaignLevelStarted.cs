﻿using CustomCampaign.Data;

namespace Events.Mod
{
    public class CampaignLevelStarted : StaticEvent<CampaignLevelStarted.Data>
    {
        public struct Data
        {
            public CampaignInfo campaign;

            public Data(CampaignInfo _campaign)
            {
                campaign = _campaign;
            }
        }
    }
}
