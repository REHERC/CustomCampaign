using Spectrum.API.Experimental;
using Spectrum.API.Logging;
using Spectrum.API.Storage;

namespace CustomCampaign
{
    public static class SharedResources
    {
        public static void Init()
        {
            Log = new Logger("CustomCampaignDev");
            Log.WriteToConsole = true;

            EmbeddedResources = new Assets("resources.pak");

            File = new FileSystem();
        }

        public static string GetLevelsFolder()
        {
            string Documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string LevelPath = $@"{Documents}/My Games/Distance/Levels/MyLevels";

            return LevelPath.Replace("\\", "/");
        }

        public static string GetResourcesFolder()
        {
            string Data = UnityEngine.Application.dataPath;
            return $@"{Data}/Resources".Replace("\\", "/");
        }

        public static string GetPluginFolder()
        {
            return File.RootDirectory.Replace("\\", "/");
        }

        public static FileSystem File;
        public static Logger Log;
        public static Assets EmbeddedResources;
    }
}
