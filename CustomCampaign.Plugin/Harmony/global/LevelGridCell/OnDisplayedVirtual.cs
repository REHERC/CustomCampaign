using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;
using System;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelGridCell), "OnDisplayedVirtual")]
    internal static class LevelGridCellOnDisplayedVirtual
    {
        public static void Postfix(LevelGridCell __instance, ref UIButton ___button_)
        {
            try
            {
                LevelGridGrid.LevelEntry entry = __instance.entry_ as LevelGridGrid.LevelEntry;
                string path = entry.AbsolutePath_;
                if (Utils.Campaign.IsCustomCampaignLevel(path))
                {
                    __instance.titleLabel_.enabled = false;
                    __instance.authorLabel_.enabled = false;
                    __instance.soloTitleLabel_.enabled = true;
                    if (LockingSystem.IsLevelLocked(path))
                    {
                        __instance.lockedIcon_.SetActive(true);
                        ___button_.onClick.Clear();
                        string leveltitle = "";
                        foreach (var c in entry.LevelInfo_.levelName_)
                        {
                            leveltitle += c.ToString() == " " ? " " : "?";
                        }
                        __instance.soloTitleLabel_.text = leveltitle;
                    }
                    else
                    {
                        __instance.soloTitleLabel_.text = entry.LevelInfo_.levelName_;
                    }
                }
            }
            catch (NullReferenceException nre)
            {
                Plugin.Log.Exception(nre);
            }
        }
    }
}
