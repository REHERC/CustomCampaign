using CustomCampaign.Data;

namespace CustomCampaign.Systems
{
    internal static class CampaignEventsSystem
    {
        internal static CampaignInfo Last { get; set; } = null;
        private static CampaignInfo _current = null;
        internal static CampaignInfo Current {
            get => _current;
            set
            {
                Last = Current;
                _current = value;
                BroadcastEvent();
            }
        }

        private static void BroadcastEvent()
        {
            if (Current != Last)
                Events.Mod.CampaignLoaded.Broadcast(new Events.Mod.CampaignLoaded.Data(Current));
        }
    }
}
