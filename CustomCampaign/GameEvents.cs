using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCampaign
{
    public static class GameEvents
    {
        public static void SubscribeAll()
        {
            Events.Game.LevelLoaded.Subscribe((data) => {
                //TODO: add level unlock code here
                string level = G.Sys.GameManager_.LevelPath_;
                if (Mod.IsCustomCampaignLevel(level))
                    LockingManager.UnlockLevel(level);
            });
        }
    }
}
