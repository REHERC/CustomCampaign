using System;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    internal static class Variables
    {
        internal static string CampaignsDataFolder()
        {
            string path = $"{Plugin.Files.RootDirectory}/Data/Campaigns";
            Util.MakeDirectory(path);
            return path;
        }

        internal static string DistanceDocs()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/My Games/Distance".NormPath(false);
        }
    }
}