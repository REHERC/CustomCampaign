using Spectrum.API.Logging;
using System.Collections.Generic;
using static CustomCampaign.Storage;

namespace CustomCampaign
{
    public static partial class Plugin
    {
        public static void Init()
        {
            Log = new Logger("CustomCampaign")
            {
                WriteToConsole = true
            };
            LevelData = new Dictionary<string, CustomCampaign.Storage.CampaignLevelInfo>();
        }

        public static string LevelsFolder()
        {
            string Documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            return $@"{Documents}/My Games/Distance/Levels";
        }

        public static string ProfilesFolder()
        {
            string Documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            return $@"{Documents}/My Games/Distance/Profiles";
        }

        public static string ResourcesFolder()
        {
            string Data = UnityEngine.Application.dataPath;
            return Resource.NormalizePath($@"{Data}/Resources");
        }

        public static string GetPluginFolder()
        {
            return Resource.NormalizePath(Plugin.Files.RootDirectory);
        }

        public static Logger Log;
        public static Dictionary<string, Storage.CampaignLevelInfo> LevelData;
    }
}
