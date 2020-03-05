#pragma warning disable SecurityIntelliSenseCS, RCS1001, CA1819
using CustomCampaign.Storage;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace CustomCampaign.Data
{
    public class CampaignInfo
    {
        internal bool Enabled { get; private set; } = true;

        public Models.Campaign Data { get; internal set; }

        public string Location { get; set; }

        public List<Models.Level> Levels => Data.levels;

        public List<Models.Addon> Addons => Data.addons;

        public List<string> LevelPaths => Levels.Select((Level) => Level.file.NormPath(true)).ToList();

#if !LIMITED_COMPATIBILITY
        public Texture2D Logo { get; set; }
#endif

        public string Id => Data.guid;

        public string Name => Data.name;

        public string Description => Data.description;

        public string[] Authors => Data.authors.Split(';');

        public bool ShowInArcade => Data.sprint_playlist;

        public Models.Campaign.UnlockStyle LockMode => (Models.Campaign.UnlockStyle)Data.lockmode;

        public GameModeID GameMode => (GameModeID)Data.gamemode;

        public CampaignInfo(string data_dir, Models.Campaign data)
        {
            Data = data;
            Location = data_dir.NormPath(false);
#if !LIMITED_COMPATIBILITY
            string logo_path = Path.Combine(Location, Data.logopath).NormPath(true);
            if (File.Exists(logo_path))
            {
                Logo = Utils.Common.LoadTexture(logo_path) as Texture2D;
            }
#endif
        }

        public void Print()
        {
            Plugin.Log.Info("--------------------");
            Plugin.Log.Info($"Campaign loaded: {Name}");
            Plugin.Log.Info($"\"{Description}\"");
            Plugin.Log.Info($"Made by:");
            foreach (var author in Authors)
            {
                Plugin.Log.Info($"\t  - {author}");
            }
        }

        public LevelSet GetLevelSet(GameModeID gamemode = GameModeID.Nexus, bool sprint = false)
        {
            LevelSet set = new LevelSet()
            {
                gameModeID_ = gamemode
            };
            foreach (var level in Levels)
            {
                if (sprint && level.hide_in_sprint)
                {
                    continue;
                }

                string file = level.file.NormPath(true);
                set.AddLevel(file, file, LevelType.Official);
            }
            return set;
        }

        public void SetEnabled(bool value)
        {
            Enabled = value;
        }
    }
}
