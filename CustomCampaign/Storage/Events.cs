using CustomCampaign.Systems;

#pragma warning disable RCS1163
namespace CustomCampaign.Storage
{
    public static class EventSubscriber
    {
        public static void SubscribeAll()
        {
            Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Util.IsCustomCampaignLevel(level))
                    LockingSystem.UnlockLevel(level);
            });
            Events.Scene.StartLoad.Subscribe((data) =>
            {
                Plugin.Log.Warning(data.sceneName);
                //if (data.sceneName != "GameMode")
                    
            });
            Events.CampaignLevelStarted.Subscribe((data) =>
            {
                Plugin.Log.Warning($"CampaignLevelStarted {data.campaign.Id}");
            });
        }
    }
}
