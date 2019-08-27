using CustomCampaign.Data;

namespace CustomCampaign.Systems
{
    internal static partial class AddonSystem
    {
        internal static void InitializeAddons()
        {
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
            GetAddons(guid).ForEach((item) => item.Key.Object.Enable());
        }

        internal static void DisableAddons(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Object.Disable());
        }

        internal static void LevelLoaded(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Object.OnLevelStart(Util.GetLevelInfo(Util.LevelFile)));
        }
    }
}