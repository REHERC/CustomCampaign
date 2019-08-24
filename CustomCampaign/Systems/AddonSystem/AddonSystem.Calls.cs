using CustomCampaign.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        public static void InitializeAddons()
        {
            GetAddons().ForEach((addon) => addon.Key.OnInit());
        }

        public static void EnableAddons(string guid)
        {
            GetAddons(guid).ForEach((addon) => addon.Key.Enable());
        }

        public static void DisableAddons(string guid)
        {
            GetAddons(guid).ForEach((addon) => addon.Key.Disable());
        }
    }
}