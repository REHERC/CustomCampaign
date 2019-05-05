using CustomCampaign.SDK.API;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace CustomCampaign
{
    public static class AddonSystem
    {
        public static AppDomain Domain;
        public static List<Assembly> Assemblies;
        public static Dictionary<ListenerAttribute, IEvent> EventListeners;
        public static List<AddonInfo> AddonInfos;

        public static void RaiseEvent(SDK.API.Event target, EventParams args = null)
        {
            foreach (var listener in EventListeners.Where((KeyValuePair<ListenerAttribute, IEvent> item) => item.Key.Event == target))
                listener.Value.EventRaised(args);
        }
    }
}
