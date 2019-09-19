using System.Drawing;
using System.IO;

namespace CustomCampaign.Models
{
    public class Level
    {
        public string file = "";

        public double countdown = 0.0d;

        public bool display_intro_title = true;
        public string levelname = "";
        public string levelname_sub = "";

        public string loading_wallpaper = "";

        public bool overwrite_loading_text = false;
        public string loading_text = "";

        public bool hide_in_sprint = false;

        public Image GetThumbnail(string current_path)
        {
            string file_path = $"{Path.Combine(current_path, file)}.png";
            return File.Exists(file_path) ? Image.FromFile(file_path) : null;
        }

        public override string ToString() => levelname;
    }
}
