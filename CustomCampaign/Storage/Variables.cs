using System;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    internal static class Variables
    {
        public const string DocumentsFolder = "WorkshopLevels";

        public static string CampaignsDataFolder()
        {
            string path = $"{Plugin.Files.RootDirectory}/Data/Campaigns";
            Util.MakeDirectory(path);
            return path;
        }

        public static string DistanceDocs()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/My Games/Distance".NormPath(false);
        }

        public static string LevelsDirectory()
        {
            return $"{DistanceDocs()}/Levels/{DocumentsFolder}".NormPath(false);
        }
    }
}