using System;

class Variables
{
    public const string DocumentsFolder = "WorkshopLevels";

    public static string CampaignsDataFolder()
    {
        string path = $"{CustomCampaign.Plugin.Files.RootDirectory}/Data/Campaigns".NormPath(false);
        Extensions.MakeDirectory(path);
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
