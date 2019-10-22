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
                CampaignInfo campaign = Util.GetCampaign(Util.LevelFile);
                CampaignSystem.Current = campaign;
            });

            Events.Game.LevelLoaded.Subscribe((data) => {
                string level = Util.LevelFile;
                if (Util.IsCustomCampaignLevel(level))
                {
                    LockingSystem.UnlockLevel(level);
                    CampaignInfo campaign = Util.GetCampaign(level);

                    Events.Mod.CampaignLevelStarted.Broadcast(new Events.Mod.CampaignLevelStarted.Data(campaign));
                }
            });
            Events.Mod.CampaignLevelStarted.Subscribe((data) =>
            {
                AddonSystem.LevelLoaded(data.campaign);
            });
            Events.Mod.CampaignLoaded.Subscribe((data) =>
            {
                if (CampaignSystem.Current != null)
                    AddonSystem.EnableAddons(CampaignSystem.Current.Id);
                else if (CampaignSystem.Last != null)
                    AddonSystem.DisableAddons(CampaignSystem.Last.Id);
            });
        }
    }
}
