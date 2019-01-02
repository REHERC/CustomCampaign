using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CustomCampaign
{
    public static class Storage
    {
        public static List<Storage.CampaignInfo> Campaigns;
        public static Dictionary<string, CampaignLevelInfo> Levelnfos;

        public static void Init()
        {
            Campaigns = new List<CampaignInfo>();
            Levelnfos = new Dictionary<string, CampaignLevelInfo>();
        }

        public struct CampaignInfo
        {
            public CampaignInfo(string dir,Campaign c)
            {
                this.Name = c.Name;
                this.Description = c.Description;
                this.Authors = c.Authors;
                this.LogoPath = c.LogoPath;

                this.Levels = new LevelSet();

                this.Directory = dir;
                this.DirectoryName = new DirectoryInfo(dir).Name;
            }

            public string Name;
            public string Description;
            public string LogoPath;

            public string Authors;

            public string Directory;
            public string DirectoryName;

            public LevelSet Levels;
        }
    }
}
