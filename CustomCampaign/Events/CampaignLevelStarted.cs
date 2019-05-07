using CustomCampaign.Data;

namespace CustomCampaign.Events
{
    public class CampaignLevelStarted : global::Events.StaticEvent<CampaignLevelStarted.Data>
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
