using System;

#pragma warning disable RCS1110
namespace CustomCampaign.Storage
{
    internal static class Variables
    {
        internal static string CampaignsDataFolder()
        {
            string path = $"{Plugin.Files.RootDirectory}/Data/Campaigns";
            Utils.Common.MakeDirectory(path);
            return path;
        }
    }
}