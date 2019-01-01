using System;
using System.Collections.Generic;
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
            public CampaignInfo(Campaign c)
            {
                this.Name = c.Name;
                this.Description = c.Description;
                this.Authors = c.Authors;
                this.LogoPath = c.LogoPath;

                this.Levels = new LevelSet();
            }

            public string Name;
            public string Description;
            public string LogoPath;

            public string Authors;

            public LevelSet Levels;
        }
    }
}
