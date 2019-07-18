using CustomCampaign.Data;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

#pragma warning disable CS0168, RCS1003, RCS1001, IDE0051
namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    public class LevelGridMenuCreateEntries
    {
        public const LevelGridMenu.PlaylistEntry.UnlockStyle unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;

        public static void Postfix(LevelGridMenu __instance)
        {
            if (__instance.isCampaignMode_)
            {
                LevelSet set = new LevelSet()
                {
                    gameModeID_ = GameModeID.Nexus
                };
                foreach (string level in CampaignDatabase.LevelPaths)
                    set.AddLevel(level, level, LevelType.Official);

                __instance.CreateAndAddCampaignLevelSet(set, "All", true, unlock_mode, GameModeID.Nexus);
                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }
            LockingSystem.CreateProfile();
        }
    }


    [HarmonyPatch(typeof(LevelInfos), "LoadPersonalLevelInfos")]
    public class LoadPersonalLevelInfos
    {
        static void Postfix(ref LevelInfos __result)
        {
            foreach (string path in CampaignDatabase.LevelPaths)
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
                if (!CampaignDatabase.LevelPaths.Contains(level.Key))
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
            if (CampaignDatabase.LevelPaths.Contains(levelPath))
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
            if (CampaignDatabase.LevelPaths.Contains(normalizedLevelPath))
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
            if (CampaignDatabase.LevelPaths != null && CampaignDatabase.LevelPaths.Contains(absoluteLevelPath))
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
            foreach (string path in CampaignDatabase.LevelPaths)
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
            if (CampaignDatabase.LevelPaths.Contains(absoluteLevelPath))
            {
                __result.labelText_ = $"CustomCampaign/{__result.labelText_}";
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
            if (CampaignDatabase.LevelPaths.Contains(levelPath))
            {
                __result.relativePath_ = levelPath;
                __result.fileNameWithoutExtension_ = Path.GetFileNameWithoutExtension(levelPath);
                __result.levelType_ = LevelType.My;
            }
        }
    }

    //[HarmonyPatch(typeof(LevelGridMenu), "CreateAndAddLevelSet", new Type[] { typeof(LevelSet), typeof(string), typeof(LevelGridMenu.PlaylistEntry.Type), typeof(LevelGroupFlags) })]
    public class CreateAndAddLevelSet
    {
        public static void Prefix(
            ref LevelSet set, ref LevelGridMenu.PlaylistEntry.Type type)
        {
            if (type != LevelGridMenu.PlaylistEntry.Type.Campaign)
                foreach (LevelNameAndPathPair level in set.GetAllLevelNameAndPathPairs())
                    if (CampaignDatabase.LevelPaths.Contains(level.levelPath_))
                        set.RemoveLevel(level.levelPath_.Normalize());
        }
    }

}