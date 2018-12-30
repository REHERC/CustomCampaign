using Harmony;
using Spectrum.API.Storage;
using System;
using System.IO;
using static CustomCampaign.SharedResources;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(File), "Exists")]
    internal class File__Exists
    {
        static void Postfix(ref bool __result, string path)
        {
            string filepath = Resource.NormalizePath(path).ToLower();
            string workshop = Resource.NormalizePath($@"{LevelsFolder()}/WorkshopLevels").ToLower();

            bool flag_overwrite = filepath.StartsWith(workshop) && filepath.Contains(".bytes");

            __result |= flag_overwrite;
        }
    }

    // try to patch FileStream.cs:672 instead

    [HarmonyPatch(typeof(File), "Open", new Type[] { typeof(string) , typeof(FileMode) , typeof(FileAccess) , typeof(FileShare) })]
    internal class File_Open
    {
        static bool Prefix(ref FileStream __result, string path, FileMode mode, FileAccess access, FileShare share)
        {
            string file = Resource.NormalizePath(path);
            string redirect = Resource.NormalizePath(new FileSystem().RootDirectory + @"\Data\file.txt").ToLower();
            
            bool flag_redirect = file.ToLower() == @"c:/file.txt";
            //Console.WriteLine($"path: {path}");
            //Console.WriteLine($"file: {file}");
            //Console.WriteLine($"flag_redirect: {flag_redirect}");
            
            __result = flag_redirect ? File.Open(redirect, mode, access, share) : new FileStream(path, mode, access, share);
            
            return false;
        }
    }
}
