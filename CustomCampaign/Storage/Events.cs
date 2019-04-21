#pragma warning disable RCS1163
namespace CustomCampaign
{
    public static class Events
    {
        public static void SubscribeAll()
        {
            global::Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Utils.IsCustomCampaignLevel(level))
                    LockingSystem.UnlockLevel(level);
            });
        }
    }
}
