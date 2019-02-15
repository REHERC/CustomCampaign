#pragma warning disable RCS1110
public partial class Campaign
{
    public struct Level
    {
        public string file;
        public string levelname;
        public string levelname_sub;
        public string loading_wallpaper;

        public Level(string _file, string _name, string _name_sub, string _wallpaper = "")
        {
            this.file = _file;
            this.levelname = _name;
            this.levelname_sub = _name_sub;
            this.loading_wallpaper = _wallpaper;
        }
    }
}
