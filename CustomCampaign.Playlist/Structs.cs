using System.Collections.Generic;

public partial class Campaign
{
    public struct Level
    {
        public string file;
        public string levelname;
        public string levelname_sub;

        public Level(string _file, string _name, string _name_sub)
        {
            this.file = _file;
            this.levelname = _name;
            this.levelname_sub = _name_sub;
        }
    }
}
