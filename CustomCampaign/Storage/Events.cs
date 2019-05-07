using CustomCampaign.API;
using CustomCampaign.API.Events;
using CustomCampaign.Systems;

#pragma warning disable RCS1163
namespace CustomCampaign.Storage
{
    public static class EventSubscriber
    {
        public static void SubscribeAll()
        {
            global::Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Util.IsCustomCampaignLevel(level))
                    LockingSystem.UnlockLevel(level);
            });
            global::Events.Scene.StartLoad.Subscribe((data) =>
            {
                Plugin.Log.Warning(data.sceneName);
                if (data.sceneName != "GameMode")
                    AddonSystem.DestroyDomain();
            });
            Events.CampaignLevelStarted.Subscribe((data) =>
            {
                AddonSystem.CreateDomain();
                AddonSystem.LoadAddons(data.campaign.Id);
                AddonSystem.Current.RaiseEvent(Event.Addon_Load, null);
            });
        }
    }
}
