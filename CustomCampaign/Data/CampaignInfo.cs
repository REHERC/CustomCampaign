using CustomCampaign.Storage;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

#pragma warning disable RCS1001

namespace CustomCampaign.Data
{
    public class CampaignInfo
    {
        internal bool Enabled { get; private set; } = true;
        private Models.Campaign Data { get; set; }
        public string Location { get; set; }
        public List<Models.Level> Levels => Data.levels;
        public List<Models.Addon> Addons => Data.addons;
        public List<string> LevelPaths => Levels.Select((Level) => Level.file.NormPath(true)).ToList();
        public Texture2D Logo { get; set; }
        public string Id => Data.guid;
        public string Name => Data.name;
        public string Description => Data.description;
        public string[] Authors => Data.authors.Split(';');
        public Models.Campaign.UnlockStyle LockMode => (Models.Campaign.UnlockStyle)Data.lockmode;
        public GameModeID GameMode => (GameModeID)Data.gamemode;

        public CampaignInfo(string data_dir, Models.Campaign data)
        {
            Data = data;
            Location = data_dir.NormPath(false);
            string logo_path = Path.Combine(Location, Data.logopath).NormPath(true);
            if (File.Exists(logo_path))
                Logo = Util.LoadTexture(logo_path) as Texture2D;
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
            LevelSet set = new LevelSet()
            {
                gameModeID_ = gamemode
            };
            foreach (string level in LevelPaths)
                set.AddLevel(level, level, LevelType.Official);
            return set;
        }

        public void SetEnabled(bool value) => Enabled = value;
    }
}
