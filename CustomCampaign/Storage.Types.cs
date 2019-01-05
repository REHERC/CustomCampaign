using System.IO;

namespace CustomCampaign
{
    public class CampaignLevelInfo
    {
        public string name;
        public string sector;
        public string wallpaper;

        public CampaignLevelInfo(string campaigndir, string _name, string _sector, string _wallpaper = "")
        {
            this.name = _name;
            this.sector = _sector;
            this.wallpaper = (_wallpaper != "") ? Resource.NormalizePath(Path.GetFullPath(Path.Combine(campaigndir, _wallpaper))) : "";
        }

        public CampaignLevelInfo(string campaigndir, Campaign.Level level) : this(campaigndir, level.levelname, level.levelname_sub, level.loading_wallpaper) { }
    }
}
