#pragma warning disable RCS1163
namespace CustomCampaign
{
    public static class Event
    {
        public static void SubscribeAll()
        {
            global::Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Utils.IsCustomCampaignLevel(level))
                    LockingSystem.UnlockLevel(level);
            });
            global::Events.Scene.StartLoad.Subscribe((data) =>
            {
                Plugin.Log.Warning(data.sceneName);
                if (data.sceneName != "GameMode")
                    ModLoader.DestroyDomain();
            });
            Events.CampaignLevelStarted.Subscribe((data) =>
            {
                ModLoader.CreateDomain();
                ModLoader.LoadAddons(data.campaign.Id);
                AddonSystem.RaiseEvent(SDK.API.Event.Addon_Load, null);
            });
        }
    }
}
