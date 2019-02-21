using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

#pragma warning disable RCS1110
public partial class Campaign
{
    public void PakLoad(string FileName)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
        {
            levels = new List<Level>();
            addons = new List<string>();
            name = reader.ReadStringSecure();
            description = reader.ReadStringSecure();
            logopath = reader.ReadStringSecure();
            authors = reader.ReadStringSecure();
            lockmode = (UnlockStyle)reader.ReadInt32();
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
                    levels.Add(new Level(levelpath, levelname, levelnamesub, levelwallpaper));
                else
                    throw new FormatException("File content invalid !");
            }
            int _addoncount = reader.ReadInt32();
            for (int i = 0; i < _addoncount; i++)
                addons.Add(reader.ReadStringSecure());
        }
    }

#if EDITOR
    public void PakSave(string FileName)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Create)))
        {
            writer.WriteStringSecure(name);
            writer.WriteStringSecure(description);
            writer.WriteStringSecure(logopath);
            writer.WriteStringSecure(authors);
            writer.Write((int)lockmode);
            writer.Write(levels.Count);
            foreach (Level level in levels)
            {
                writer.WriteStringSecure(level.file);
                writer.WriteStringSecure(level.levelname);
                writer.WriteStringSecure(level.levelname_sub);
                writer.WriteStringSecure(level.loading_wallpaper);
                int len = (level.file.Length + level.levelname.Length + level.levelname_sub.Length + level.loading_wallpaper.Length) % 32;
                writer.Write(len);
            }
            writer.Write(addons.Count);
            foreach (string addon in addons)
                writer.WriteStringSecure(addon);
        }
    }
#endif

    public void JsonLoad(string FileName)
    {
        Campaign data = new Serializer<Campaign>(SerializerType.Json,FileName, true).Data;
        name = data.name;
        description = data.description;
        logopath = data.logopath;
        authors = data.authors;
        lockmode = data.lockmode;
        levels = data.levels;
        addons = data.addons;
        gamemode = data.gamemode;
    }

#if EDITOR
    public void JsonSave(string FileName)
    {
        Serializer<Campaign> serializer = new Serializer<Campaign>(SerializerType.Json, FileName, true);
        serializer.Data = this;
        serializer.Save();
    }
#endif
}
