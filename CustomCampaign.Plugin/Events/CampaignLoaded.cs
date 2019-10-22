using CustomCampaign.Data;

#pragma warning disable CA1405

namespace Events.Mod
{
    public class CampaignLoaded : StaticEvent<CampaignLoaded.Data>
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
