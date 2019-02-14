using static Campaign;
using System.Collections.Generic;
using System.IO;
using System;
using CustomCampaign.SDK.Data;
using Photon.Serialization;

#pragma warning disable CS0168
public partial class Campaign
{
    public string Name;
    public string Description;
    public string LogoPath;

    public string Authors;

    public UnlockStyle LockMode;
    
    public List<Level> Levels;

    public List<string> Addons;
    
    public Campaign()
    {
        Levels = new List<Level>();
        Addons = new List<string>();
    }

    public static Campaign FromFile(string FileName)
    {
        Campaign c = new Campaign();
        c.Load(FileName);
        return c;
    }

    public void Load(string FileName)
    {
        if (File.Exists(FileName))
            using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
            {
                Levels = new List<Level>();
                Addons = new List<string>();
                Name = reader.ReadStringSecure();
                Description = reader.ReadStringSecure();
                LogoPath = reader.ReadStringSecure();
                Authors = reader.ReadStringSecure();
                LockMode = (UnlockStyle)reader.ReadInt32();
                int _levelcount = reader.ReadInt32();
                for (int i = 0; i < _levelcount; i++)
                {
                    string levelpath = reader.ReadStringSecure();
                    string levelname = reader.ReadStringSecure();
                    string levelnamesub = reader.ReadStringSecure();
                    string levelwallpaper = reader.ReadStringSecure();
                    int len = (levelpath.Length + levelname.Length + levelnamesub.Length + levelwallpaper.Length) % 32;
                    int len_rd = reader.ReadInt32();
                    if (len == len_rd)
                        Levels.Add(new Level(levelpath, levelname, levelnamesub, levelwallpaper));
                    else
                        throw new FormatException("File content invalid !");
                }
                int _addoncount = reader.ReadInt32();
                for (int i = 0; i < _addoncount; i++)
                    Addons.Add(reader.ReadStringSecure());
            }
    }
    
    public static bool Validate(string path)
    {
        string root = Path.GetDirectoryName(path);
        if (File.Exists(path))
        {
            Campaign c = new Campaign();
            try { c.Load(path); } catch (Exception pizza) { Console.WriteLine(path + " : file format error"); return false; }
            if (c.LogoPath != "" && !Campaign.FileExists(root, c.LogoPath)) return false;
            foreach (Level level in c.Levels)
            {
                if (!Campaign.FileExists(root, level.file) 
                ||  !Campaign.FileExists(root, level.file + ".png") 
                ||  (!Campaign.FileExists(root, level.loading_wallpaper) 
                  && level.loading_wallpaper != ""))
                return false;
            }
            foreach (string addon in c.Addons)
            {
                string addonfile = Path.GetFullPath(Path.Combine(root, addon));
                AddOnManifest manifest;
                try {
                    manifest = new Serializer<AddOnManifest>(SerializerType.Json, addonfile, true).Data; 
                    string filename = $"/{addon}".Substring($"/{addon}".Replace(@"\", @"/").LastIndexOf("/") + 1);
                    string fileroot = addon.Substring(0, addon.Length - filename.Length);
                    string addonroot = Path.GetFullPath(Path.Combine(root, fileroot));
                    if (!Campaign.FileExists(addonroot, manifest.ModuleFile)) return false;
                    foreach (string dependency in manifest.Dependencies)
                        if (!Campaign.FileExists(addonroot, dependency)) return false;
                } catch (Exception pizza){
                    Console.WriteLine(addonfile + " : file format error");
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    public static bool FileExists(string root, string file)
    {
        return File.Exists(Path.GetFullPath(Path.Combine(root,file)));
    }

#if EDITOR
    public void Save(string FileName)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Create)))
        {
            writer.WriteStringSecure(Name);
            writer.WriteStringSecure(Description);
            writer.WriteStringSecure(LogoPath);
            writer.WriteStringSecure(Authors);
            writer.Write((int)LockMode);
            writer.Write(Levels.Count);
            foreach (Level level in Levels)
            {
                writer.WriteStringSecure(level.file);
                writer.WriteStringSecure(level.levelname);
                writer.WriteStringSecure(level.levelname_sub);
                writer.WriteStringSecure(level.loading_wallpaper);
                int len = (level.file.Length + level.levelname.Length + level.levelname_sub.Length + level.loading_wallpaper.Length) % 32;
                writer.Write(len);
            }
            writer.Write(Addons.Count);
            foreach (string addon in Addons)
                writer.WriteStringSecure(addon);
        }
    }
#endif
}
