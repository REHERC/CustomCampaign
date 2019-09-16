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
            Plugin.Log.Info($"Addons initialized!");
        }

        internal static void EnableAddons(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Object.Enable());
        }

        internal static void DisableAddons(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Object.Disable());
        }

        internal static void LevelLoaded(CampaignInfo campaign)
        {
            GetAddons(campaign.Id).ForEach((item) => {
                try
                {
                    item.Key.Object.OnLevelStart(Util.GetLevelInfo(Util.LevelFile));
                }
                catch (System.Exception error)
                {
                    Plugin.Log.Exception(error);
                }
            });
        }
    }
}