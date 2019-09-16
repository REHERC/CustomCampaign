using CustomCampaign.Data;
using CustomCampaign.Models;
using CustomCampaign.Storage;

namespace CustomCampaign.Systems
{
    internal static partial class AddonSystem
    {
        internal static void InitializeAddons()
        {
            Plugin.Log.Info($"Initializing addons...");

            GetAddons().ForEach((item) => {
                // Avoid multiple initialization calls
                if (item.Key.Object.Initialized) return;

                CampaignInfo info = Util.GetCampaign(item.Key);
                item.Key.Object.Info = info;
                item.Key.Object.OnInit(info);
                item.Key.Object.Initialized = true;
            });
        }

        internal static void EnableAddons(string guid)
        {
            Plugin.Log.Success($"Enabling addons for {guid}");
            //GetAddons(guid).ForEach((item) => item.Key.Object.Enable());
        }

        internal static void DisableAddons(string guid)
        {
            Plugin.Log.Success($"Disabling addons for {Util.GetCampaignByGuid(guid).Name}");
            //GetAddons(guid).ForEach((item) => item.Key.Object.Disable());
        }

        internal static void LevelLoaded(CampaignInfo campaign)
        {
            Plugin.Log.Success($"Sending level loaded notification for campaign {campaign.Name}");
            GetAddons(campaign.Id).ForEach((item) => {
                Plugin.Log.Warning($"The level path is {Util.LevelFile}");
                item.Key.Object.OnLevelStart(Util.GetLevelInfo(Util.LevelFile));
            });
        }
    }
}