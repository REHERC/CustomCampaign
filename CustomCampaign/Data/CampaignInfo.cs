using CustomCampaign.Storage;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

#pragma warning disable RCS1001
namespace CustomCampaign.Data
{
    public class CampaignInfo
    {
        public string DataDirectory { get; set; }
        public List<Models.Level> Levels { get; set; }
        public Texture2D Logo { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Authors { get; set; }
        public /*Campaign.UnlockStyle*/int LockMode { get; set; }
        public /*GameModeID*/int GameMode { get; set; }

        public CampaignInfo(string data_dir, Models.Campaign data)
        {
            Id = data.guid;
            DataDirectory = data_dir.NormPath(false);
            Name = data.name;
            Description = data.description;
            Authors = data.authors.Split(';');
            LockMode = data.lockmode;
            string logo_path = $"{DataDirectory}/{data.logopath}".NormPath(true);
            if (File.Exists(logo_path))
            {
                byte[] image = File.ReadAllBytes(logo_path);
                Logo = new Texture2D(2, 2);
                Logo.LoadImage(image);
            }
            Levels = new List<Models.Level>();
            GameMode = data.gamemode;
        }

        public void Print()
        {
            Plugin.Log.Info("--------------------");
            Plugin.Log.Info($"Campaign loaded: {Name}");
            Plugin.Log.Info($"\"{Description}\"");
            Plugin.Log.Info($"Made by:");
            foreach (string author in Authors)
                Plugin.Log.Info($"\t  - {author}");
        }

        public LevelSet GetLevelSet(GameModeID gamemode = GameModeID.Nexus)
        {
            LevelPlaylist playlist = LevelPlaylist.Create(false);
            foreach (Models.Level level in Levels)
                playlist.Add(new LevelPlaylist.ModeAndLevelInfo(
                    gamemode, new LevelNameAndPathPair(
                    level.file,
                    level.file)));
            LevelSet set = new LevelSet()
            {
                gameModeID_ = gamemode
            };
            foreach (var level in playlist.GetLevelSet())
                set.AddLevel(level.levelName_, level.levelPath_, LevelType.Official);
            return set;
        }
    }
}
