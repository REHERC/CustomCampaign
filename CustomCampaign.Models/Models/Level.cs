#pragma warning disable SecurityIntelliSenseCS
using System;
using System.Drawing;
using System.IO;

namespace CustomCampaign.Models
{
    [Serializable]
    public class Level
    {
        public string file = "";

        public double countdown;

        public bool display_intro_title = true;
        public string levelname = "";
        public string levelname_sub = "";

#if !LIMITED_COMPATIBILITY
        public string loading_wallpaper = "";
#endif
        public bool overwrite_loading_text;
        public string loading_text = "";

        public bool hide_in_sprint;

        public Image GetThumbnail(string current_path)
        {
            string file_path = $"{Path.Combine(current_path, file)}.png";
            return File.Exists(file_path) ? Image.FromFile(file_path) : null;
        }

        public override string ToString() => levelname;
    }
}
