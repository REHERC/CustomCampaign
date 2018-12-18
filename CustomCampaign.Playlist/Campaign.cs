using static Campaign;
using System.Collections.Generic;
using System.IO;
using System;

public partial class Campaign
{
    public string Name;
    public string Description;

    public List<Level> Levels;
    
    public Campaign()
    {
        Levels = new List<Level>();
    }

    public void Load(string FileName)
    {
        if (File.Exists(FileName))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
            {
                Levels = new List<Level>();

                Name = reader.ReadStringSecure();
                Description = reader.ReadStringSecure();

                int _levelcount = reader.ReadInt32();
                
                for (int i = 0; i < _levelcount; i++)
                {
                    string levelpath = reader.ReadStringSecure();
                    string levelname = reader.ReadStringSecure();
                    string levelnamesub = reader.ReadStringSecure();

                    int len = (levelpath.Length + levelname.Length + levelnamesub.Length) % 32;
                    int len_rd = reader.ReadInt32();
                    
                    if (len == len_rd)
                    {
                        Levels.Add(new Level(levelpath, levelname, levelnamesub));
                    }
                    else
                    {
                        throw new FormatException("File content invalid !");
                    }
                }
            }
        }
    }
    
#if EDITOR
    public void Save(string FileName)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Create)))
        {
            writer.WriteStringSecure(Name);
            writer.WriteStringSecure(Description);
            writer.Write(Levels.Count);
            foreach (Level level in Levels)
            {
                writer.WriteStringSecure(level.file);
                writer.WriteStringSecure(level.levelname);
                writer.WriteStringSecure(level.levelname_sub);

                int len = (level.file.Length + level.levelname.Length + level.levelname_sub.Length) % 32;
                writer.Write(len);
            }
        }
    }
#endif
}
