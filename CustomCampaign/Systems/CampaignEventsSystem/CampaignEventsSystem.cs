using CustomCampaign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCampaign.Systems
{
    public static class CampaignEventsSystem
    {
        public static CampaignInfo Last { get; set; } = null;
        private static CampaignInfo _current = null;
        public static CampaignInfo Current {
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
