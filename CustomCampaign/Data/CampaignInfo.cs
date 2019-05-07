using CustomCampaign.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

#pragma warning disable RCS1001
namespace CustomCampaign.Data
{
    public class CampaignInfo
    {
        public string DataDirectory { get; set; }
        public string DocsDirectory { get; set; }
        public List<Campaign.Level> Levels { get; set; }
        public Texture2D Logo { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Authors { get; set; }
        public Campaign.UnlockStyle LockMode { get; set; }
        public GameModeID GameMode;

        public CampaignInfo(string data_dir, string docs_dir, Campaign pak)
        {
            this.Id = new List<string>(data_dir.Split(new char[] { '/', '\\' })).Last().LowerCase();
            this.DataDirectory = data_dir;
            this.DocsDirectory = $"{docs_dir}/{this.Id}";
            this.Name = pak.name;
            this.Description = pak.description;
            this.Authors = pak.authors.Split(';');
            this.LockMode = pak.lockmode;
            string logo_path = $"{this.DataDirectory}/{pak.logopath}".NormPath();
            if (File.Exists(logo_path))
            {
                byte[] image = File.ReadAllBytes(logo_path);
                this.Logo = new Texture2D(2, 2);
                this.Logo.LoadImage(image);
            }
            this.Levels = new List<Campaign.Level>();
            this.GameMode = pak.gamemode;
        }

        public void Print()
        {
            Plugin.Log.Info("--------------------");
            Plugin.Log.Info($"Campaign loaded: {this.Name}");
            Plugin.Log.Info($"\"{this.Description}\"");
            Plugin.Log.Info($"Made by:");
            foreach (string author in this.Authors)
                Plugin.Log.Info($"\t  - {author}");
        }

        public string GetDocsPath()
        {
            return $"{this.DocsDirectory}".NormPath(false);
        }

        public LevelSet GetLevelSet(GameModeID gamemode = GameModeID.Nexus)
        {
            LevelSet set = new LevelSet()
            {
                gameModeID_ = gamemode
            };
            string workspace = GetWorkspace();
            foreach (var level in this.Levels)
                if (level.file.NormPath(true).StartsWith(workspace.NormPath(false)))
                {
                    string level_file = $"{workspace}/{new List<string>(level.file.Split(new char[] { '/', '\\'})).Last()}".Replace("\\","/");
                    set.AddLevel(level_file, level_file, LevelType.Official);
                }
            return set;
        }

        private string GetWorkspace()
        {
            return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/My Games/Distance/Levels/{Variables.DocumentsFolder}/{this.Id}".Replace("\\","/");
        }
    }
}
