using CustomCampaign.Data;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;
using LevelEditorTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

#pragma warning disable CS0168, RCS1003, RCS1001, IDE0051, IDE0060, IDE0059
namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    public class LevelGridMenuCreateEntries
    {
        public const LevelGridMenu.PlaylistEntry.UnlockStyle unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
        public const LevelGridMenu.PlaylistEntry.UnlockStyle sprint_unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.SprintCampaign;

        public static void Postfix(LevelGridMenu __instance)
        {
            if (__instance.DisplayType_ == LevelSelectMenuAbstract.DisplayType.GameLobby) return;

            LockingSystem.CreateProfile();
            if (__instance.isCampaignMode_)
            {
                foreach (var campaign in Campaigns.Items)
                    if (campaign.Value.Enabled)
                        __instance.CreateAndAddCampaignLevelSet(campaign.Value.GetLevelSet(campaign.Value.GameMode, false), campaign.Value.Name, true, unlock_mode, campaign.Value.GameMode);
            }
            else if (__instance.modeID_ == GameModeID.Sprint)
            {
                foreach (var campaign in Campaigns.Items)
                    if (campaign.Value.Enabled)
                    {
                        LevelSet set = campaign.Value.GetLevelSet(GameModeID.Sprint, true);

                        LevelPlaylist playlist = LevelPlaylist.Create(set, $"{Constants.Strings.CampaignEntry_Color}{campaign.Value.Name}[-]");

                        bool unlocked = LockingSystem.IsCampaignComplete(campaign.Value.Id);
                        __instance.CreateAndAddEntry(playlist, LevelGridMenu.PlaylistEntry.Type.Campaign, unlocked, sprint_unlock_mode);
                    }
            }
            __instance.buttonList_.SortAndUpdateVisibleButtons();
        }
    }

    [HarmonyPatch(typeof(LevelInfos), "LoadPersonalLevelInfos")]
    public class LoadPersonalLevelInfos
    {
        static void Postfix(ref LevelInfos __result)
        {
            foreach (var path in Campaigns.LevelPaths)
            {
                if (__result.LevelPathsToLevelInfos_.ContainsKey(path))
                    __result.LevelPathsToLevelInfos_.Remove(path);
                __result.LevelPathsToLevelInfos_.Add(path, Util.LevelInfoFromPath(path));
            }
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager), "SaveLevelInfos")]
    public class SaveLevelInfos
    {
        static bool Prefix(ref LevelSetsManager __instance)
        {
            if (!__instance.communityLevelInfos_)
                return true;
            LevelInfos temp = LevelInfos.Create();
            foreach (var level in __instance.communityLevelInfos_.LevelPathsToLevelInfos_)
                if (!Campaigns.LevelPaths.Contains(level.Key))
                    temp.levelPathsToLevelInfos_.Add(level.Key, level.Value);
            temp.SavePersonalLevelInfos();
            temp.Destroy();
            return false;
        }
    }

    [HarmonyPatch(typeof(Resource), "IsWorkshopLevelPath")]
    public class IsWorkshopLevelPath
    {
        static bool Prefix(string levelPath, ref bool __result)
        {
            if (Campaigns.LevelPaths.Contains(levelPath))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Resource), "GetLevelType")]
    public class GetLevelType
    {
        static bool Prefix(string normalizedLevelPath, ref LevelType __result)
        {
            if (Campaigns.LevelPaths.Contains(normalizedLevelPath))
            {
                __result = LevelType.My;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Resource), "GetRelativeLevelPath", new Type[] { typeof(string), typeof(bool) })]
    public class GetRelativeLevelPath
    {
        static bool Prefix(ref string absoluteLevelPath, ref string __result)
        {
            if (Campaigns.LevelPaths != null && Campaigns.LevelPaths.Contains(absoluteLevelPath))
            {
                __result = absoluteLevelPath;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager), "Start")]
    public class LevelSetsManagerStart
    {
        static void Postfix(LevelSetsManager __instance)
        {
            foreach (var path in Campaigns.LevelPaths)
            {
                __instance.allLevelPaths_.Add(path);
                __instance.myLevelsLevelFilePaths_.Add(path);
                LevelInfo info = Util.LevelInfoFromPath(path);
                __instance.AddLevelNameAndPathPair(path, info, __instance.allLevelNameAndPathPairs_);
                __instance.AddLevelNameAndPathPair(path, info, __instance.myLevelsLevelNameAndPathPairs_);
            }
        }
    }

    [HarmonyPatch(typeof(Resource), "GetAbsoluteLevelPath")]
    public class GetAbsoluteLevelPath
    {
        static bool Prefix(string relativeLevelPath, ref string __result)
        {
            if (!string.IsNullOrEmpty(relativeLevelPath))
            {
                FileInfo info = new FileInfo(relativeLevelPath);
                if (info.Exists)
                {
                    __result = Resource.NormalizePath(relativeLevelPath);
                    return false;
                }
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(LevelEditorLevelNameSelectMenuLogic.LevelPathEntry), "Create")]
    public class CreateLevelPathEntry
    {
        static void Postfix(string absoluteLevelPath, ref LevelEditorLevelNameSelectMenuLogic.LevelPathEntry __result)
        {
            if (Campaigns.LevelPaths.Contains(absoluteLevelPath))
            {
                __result.labelText_ = $"CustomCampaignLevel/{__result.labelText_}";
                __result.relativeLevelPath_ = absoluteLevelPath;
                __result.color_ = Colors.yellow;
            }
        }
    }

    [HarmonyPatch(typeof(LevelInfo), "Create")]
    public class CreateLevelInfo
    {
        static void Postfix(string levelPath, ref LevelInfo __result)
        {
            if (Campaigns.LevelPaths.Contains(levelPath))
            {
                __result.relativePath_ = levelPath;
                __result.fileNameWithoutExtension_ = Path.GetFileNameWithoutExtension(levelPath);
                __result.levelType_ = LevelType.My;
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "CreateAndAddLevelSet", new Type[] { typeof(LevelSet), typeof(string), typeof(LevelGridMenu.PlaylistEntry.Type), typeof(LevelGroupFlags) })]
    public class CreateAndAddLevelSet
    {
        public static void Prefix(
            ref LevelSet set, ref LevelGridMenu.PlaylistEntry.Type type)
        {
            if (type != LevelGridMenu.PlaylistEntry.Type.Campaign)
                foreach (var level in set.GetAllLevelNameAndPathPairs())
                    if (Campaigns.LevelPaths.Contains(level.levelPath_.NormPath(true)))
                        set.RemoveLevel(level.levelPath_.Normalize());
        }
    }

    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    public class LevelIntroTitleLogic__Update__Patch
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            string path = G.Sys.GameManager_.LevelPath_;
            if (Util.IsCustomCampaignLevel(path))
            {
                __instance.titleLabel_.text = Util.GetLevelTitle(path).Space(1);
                __instance.subtitleText_.text = Util.GetLevelSubTitle(path).Space(1);
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
            }
        }
    }

#if !LIMITED_COMPATIBILITY
    [HarmonyPatch(typeof(LevelGridMenu), "SetDisplayedInfoForSelectedPlaylist")]
    public class LevelGridMenuSetDisplayedInfoForSelectedPlaylist
    {
        public static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.isCampaignMode_;
            if (flag_campaignmode)
            {
                if (__instance.isActiveAndEnabled)
                {
                    try
                    {
                        LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
                        string level = playlist.GetLevelSet()[0].levelPath_.NormPath(true);
                        if (Util.IsCustomCampaignLevel(level))
                        {
                            __instance.modeDescription_.text = __instance.gridDescription_.text = Util.GetCampaignDescription(level);
                            __instance.campaignLogo_.mainTexture = Util.GetCampaignLogo(level);
                        }
                    }
                    catch (Exception pizza) { Plugin.Log.Exception(pizza); }
                }
            }
        }
    }
#endif

    [HarmonyPatch(typeof(LevelGridCell), "OnDisplayedVirtual")]
    public class LevelGridCellOnDisplayedVirtual
    {
        public static void Postfix(LevelGridCell __instance, ref UIButton ___button_)
        {
            try
            {
                LevelGridGrid.LevelEntry entry = __instance.entry_ as LevelGridGrid.LevelEntry;
                string path = entry.AbsolutePath_;
                if (Util.IsCustomCampaignLevel(path))
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
                            leveltitle += c.ToString() == " " ? " " : "?";
                        __instance.soloTitleLabel_.text = leveltitle;
                    }
                    else
                        __instance.soloTitleLabel_.text = entry.LevelInfo_.levelName_;
                }
            }
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
        }
    }

#if !LIMITED_COMPATIBILITY
    [HarmonyPatch(typeof(BlackFadeLogic), "FinishFadeOut")]
    public class BlackFadeLogicFinishFadeOut
    {
        public static void Postfix(BlackFadeLogic __instance)
        {
            string path = G.Sys.GameManager_.NextLevelPath_;
            if (Util.IsCustomCampaignLevel(path) && __instance.storedSceneToLoad_ != "MainMenu")
            {
                Texture background = Util.GetLevelWallpaper(path);
                if (background != null)
                    __instance.menu_.loadingTexture_.mainTexture = background;
                if (Util.GetLevelLoadingTextState(path))
                    __instance.menu_.loadingLabel_.text = Util.GetLevelLoadingText(path);
            }
        }
    }
#endif

    [HarmonyPatch(typeof(PauseMenuLogic), "Update")]
    public class PauseMenuLogicUpdate
    {
        public static void Postfix(PauseMenuLogic __instance)
        {
            string path = Util.LevelFile.NormPath(true);
            if (G.Sys.GameManager_.PauseMenuOpen_ && Util.IsCustomCampaignLevel(path))
            {
                __instance.gameMode_.text = Util.GetCampaignName(path) + "...";
                __instance.gameModeDescription_.text = Util.GetCampaignDescription(path) + "...";
                __instance.upperRightGroup_.SetActive(false);
                __instance.levelName_.text = "[AAAAAA]Level:[-] [FFFFFF]" + G.Sys.GameManager_.LevelName_;
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "OnGridCellClicked")]
    public class LevelGridMenuOnGridCellClicked
    {
        public static bool Prefix(LevelGridMenu __instance, ref int index)
        {
            bool result = false;
            LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
            string level = playlist.Playlist_[index].levelNameAndPath_.levelPath_;
            if (Util.GetCampaignUnlockMode(level) == Models.Campaign.UnlockStyle.LevelSet)
                result = true;
            else
            {
                bool flag = Util.IsCustomCampaignLevel(level) && LockingSystem.IsLevelLocked(level);
                if (flag)
                    G.Sys.MenuPanelManager_.ShowTimedOk(10, Constants.Strings.LevelLocked_Message, Constants.Strings.LevelLocked_Title);
                result = !flag;
            }
            return result;
        }
    }

    [HarmonyPatch(typeof(GameManager), "GetModeShowInLevelEditor")]
    internal static class GetModeShowInLevelEditor
    {
        public static List<GameModeID> Modes = new List<GameModeID>() {
            GameModeID.Challenge,
            GameModeID.ReverseTag,
            GameModeID.Adventure,
            GameModeID.Sprint,
            GameModeID.Stunt,
            GameModeID.LostToEchoes,
            GameModeID.MainMenu,
            GameModeID.Nexus
        };

        public static void Postfix(ref bool __result, GameModeID ID)
        {
            __result |= Modes.Contains(ID);
        }
    }

    [HarmonyPatch(typeof(DiscordController), "OnEventPostLoad")]
    internal static class OnEventPostLoad
    {
        public static bool Prefix(DiscordController __instance, Events.Level.PostLoad.Data data)
        {
            bool rpc_overwrite = Util.IsCustomCampaignLevel(Util.LevelFile);
            if (!rpc_overwrite) return true;

            CampaignInfo info = Util.GetCampaign(Util.LevelFile);
            Models.Level level = Util.GetLevelInfo(Util.LevelFile);

            string rpc_imagekey = G.Sys.GameManager_.ModeID_ == GameModeID.Sprint ? "community_level" : "official_level";
            string rpc_mode = rpc_imagekey == "community_level" ? "Sprint" : info.Name;
            
            __instance.presence.state = "Custom Campaign";
            __instance.presence.largeImageKey = rpc_imagekey;

            __instance.presence.startTimestamp = 0L;
            __instance.presence.endTimestamp = 0L;
            __instance.presence.partySize = 0;
            __instance.presence.partyMax = 0;
            __instance.presence.smallImageKey = string.Empty;
            __instance.presence.smallImageText = string.Empty;
            __instance.presence.largeImageText = string.Empty;

            if (true || rpc_imagekey == "official_level")
            {
                __instance.presence.details = $"{rpc_mode} | {__instance.GetGameTypeString()}";
            }
            
            DiscordRpc.UpdatePresence(ref __instance.presence);

            return false;
        }
    }

    [HarmonyPatch(typeof(GUtils), "GetExportedTypesOfType")]
    public class GetExportedTypesOfType
    {
        static void Postfix(Type baseType, ref Type[] __result)
        {
            List<Type> types = __result.ToList();

            if (new List<Type>() {
                typeof(ISerializable),
                typeof(LevelEditorTool)
            }.Contains(baseType))
                types.AddRange(Util.GetExportedTypesOfType(baseType));

            __result = types.ToArray();
        }
    }
}