namespace CustomCampaign
{
    public struct CampaignLevelInfo
    {
        public string name;
        public string sector;
        public string wallpaper;

        public CampaignLevelInfo(string _name, string _sector, string _wallpaper = "")
        {
            this.name = _name;
            this.sector = _sector;
            this.wallpaper = _wallpaper;
        }
    }
}
