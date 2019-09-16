using CustomCampaign.Data;
using CustomCampaign.Systems;

#pragma warning disable RCS1163
namespace CustomCampaign.Storage
{
    internal static class EventSubscriber
    {
        internal static void SubscribeAll()
        {
            Events.Level.PostLoad.Subscribe((data) =>
            {
                Plugin.Log.Warning("Events.Level.PostLoad");
            });

            Events.Game.LevelLoaded.Subscribe((data) => {
                string level = G.Sys.GameManager_.LevelPath_;
                if (Util.IsCustomCampaignLevel(level))
                {
                    LockingSystem.UnlockLevel(level);
                    CampaignInfo campaign = Util.GetCampaign(level);
                    Plugin.Log.Warning("IsCustomCampaignLevel");

                    try
                    {
                        Events.Mod.CampaignLevelStarted.Broadcast(new Events.Mod.CampaignLevelStarted.Data(campaign));
                    }
                    catch (System.Exception error)
                    {
                        Plugin.Log.Exception(error);
                    }
                }
            });
            Events.Mod.CampaignLevelStarted.Subscribe((data) =>
            {
                Plugin.Log.Warning("Events.Mod.CampaignLevelStarted");
                AddonSystem.LevelLoaded(data.campaign);
            });
            Events.Mod.CampaignLoaded.Subscribe((data) =>
            {
                Plugin.Log.Warning("Events.Mod.CampaignLoaded");

                if (CampaignEventsSystem.Current != null)
                    AddonSystem.EnableAddons(CampaignEventsSystem.Current.Id);
                else if (CampaignEventsSystem.Last != null)
                    AddonSystem.DisableAddons(CampaignEventsSystem.Last.Id);
            });
        }
    }
}
