using static Campaign;
using System.Collections.Generic;
using System.IO;
using System;
using CustomCampaign.SDK.Data;
using Photon.Serialization;
using System.Linq;

#pragma warning disable CS0168, RCS1001, RCS1110
public partial class Campaign
{
    public string name;
    public string description;
    public string logopath;
    public string authors;
    public UnlockStyle lockmode;
    public GameModeID gamemode;
    public List<Level> levels;
    public List<string> addons;

    public Campaign()
    {
        levels = new List<Level>();
        addons = new List<string>();
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
            switch (new List<string>(FileName.Split('.')).Last().ToLowerInvariant())
            {
                case "pak":
                    PakLoad(FileName);
                    break;
                case "json":
                    JsonLoad(FileName);
                    break;
            }
    }

    public static bool Validate(string path)
    {
        string root = Path.GetDirectoryName(path);
        if (File.Exists(path))
        {
            Campaign c = new Campaign();
            try { c.Load(path); } catch (Exception) { Console.WriteLine(path + " : file format error"); return false; }
            if (c.logopath != "" && !FileExists(root, c.logopath)) return false;
            foreach (Level level in c.levels)
            {
                if (!FileExists(root, level.file)
                ||  !FileExists(root, level.file + ".png")
                ||  (!FileExists(root, level.loading_wallpaper)
                  && level.loading_wallpaper != ""))
                return false;
            }
            foreach (string addon in c.addons)
            {
                string addonfile = Path.GetFullPath(Path.Combine(root, addon));
                AddOnManifest manifest;
                try {
                    manifest = new Serializer<AddOnManifest>(SerializerType.Json, addonfile, true).Data;
                    string filename = $"/{addon}".Substring($"/{addon}".Replace(@"\", "/").LastIndexOf("/") + 1);
                    string fileroot = addon.Substring(0, addon.Length - filename.Length);
                    string addonroot = Path.GetFullPath(Path.Combine(root, fileroot));
                    if (!FileExists(addonroot, manifest.ModuleFile)) return false;
                    foreach (string dependency in manifest.Dependencies)
                        if (!FileExists(addonroot, dependency)) return false;
                } catch (Exception){
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
        switch (new List<string>(FileName.Split('.')).Last().ToLowerInvariant())
        {
            case "pak":
                PakSave(FileName);
                break;
            case "json":
                JsonSave(FileName);
                break;
        }
    }
#endif
}
