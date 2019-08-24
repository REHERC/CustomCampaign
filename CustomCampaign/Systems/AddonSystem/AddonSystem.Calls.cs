namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        public static void InitializeAddons()
        {
            GetAddons().ForEach((item) => item.Key.OnInit(Util.GetCampaign(item.Key)));
        }

        public static void EnableAddons(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Enable());
        }

        public static void DisableAddons(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.Disable());
        }

        public static void LevelLoaded(string guid)
        {
            GetAddons(guid).ForEach((item) => item.Key.OnLevelStart(Util.GetLevelInfo(Util.LevelFile)));
        }
    }
}