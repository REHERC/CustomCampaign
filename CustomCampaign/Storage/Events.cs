using CustomCampaign.Data;
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
                {
                    LockingSystem.UnlockLevel(level);
                    CampaignInfo campaign = Util.GetCampaign(level);
                    Events.Mod.CampaignLevelStarted.Broadcast(new Events.Mod.CampaignLevelStarted.Data(campaign));
                }

            });
            Events.Mod.CampaignLevelStarted.Subscribe((data) =>
            {
                AddonSystem.LevelLoaded(CampaignEventsSystem.Current.Id);
            });

            Events.Mod.CampaignLoaded.Subscribe((data) =>
            {
                if (CampaignEventsSystem.Current != null)
                    AddonSystem.EnableAddons(CampaignEventsSystem.Current.Id);
                else if (CampaignEventsSystem.Last != null)
                    AddonSystem.DisableAddons(CampaignEventsSystem.Last.Id);

            });
        }
    }
}
