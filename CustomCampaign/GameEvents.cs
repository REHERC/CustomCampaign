namespace CustomCampaign
{
    public static class GameEvents
    {
        public static void SubscribeAll()
        {
            Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Mod.IsCustomCampaignLevel(level))
                    LockingManager.UnlockLevel(level);
            });
        }
    }
}
