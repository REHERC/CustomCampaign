using CustomCampaign.Data;

#pragma warning disable CA1034, CA1405, CA1815

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
