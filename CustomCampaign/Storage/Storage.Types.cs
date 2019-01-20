using System.IO;

namespace CustomCampaign
{
    public static partial class Storage
    {
        public class CampaignLevelInfo
        {
            public string name;
            public string sector;
            public string wallpaper;
            public int index = -1;

            public CampaignLevelInfo(string campaigndir, string _name, string _sector, string _wallpaper = "")
            {
                this.name = _name;
                this.sector = _sector;
                this.wallpaper = (_wallpaper != "") ? Resource.NormalizePath(Path.GetFullPath(Path.Combine(campaigndir, _wallpaper))) : "";
            }

            public CampaignLevelInfo(string campaigndir, Campaign.Level level, int _index) : this(campaigndir, level.levelname, level.levelname_sub, level.loading_wallpaper) {
                this.index = _index;
            }
        }
    }
}
