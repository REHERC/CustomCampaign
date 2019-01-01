using Spectrum.API.Logging;
using System.Collections.Generic;

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

            LevelData = new Dictionary<string, CampaignLevelInfo>();
        }

        public static string LevelsFolder()
        {
            string Documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string LevelPath = $@"{Documents}/My Games/Distance/Levels";

            return Resource.NormalizePath(LevelPath);
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

        public static Dictionary<string, CampaignLevelInfo> LevelData;
    }
}
