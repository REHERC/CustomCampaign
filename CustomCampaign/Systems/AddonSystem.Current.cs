using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CustomCampaign.Data;
using CustomCampaign.API.Events;

namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        public static class Current
        {
            public static AppDomain Domain;
            public static List<Assembly> Assemblies;
            public static Dictionary<ListenerAttribute, IEvent> EventListeners;
            public static List<AddonInfo> AddonInfos;

            public static void RaiseEvent(Event target, EventParams args = null)
            {
                foreach (var listener in EventListeners.Where((KeyValuePair<ListenerAttribute, IEvent> item) => item.Key.Event == target))
                    listener.Value.EventRaised(args);
            }
        }
    }
}
