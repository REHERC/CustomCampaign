using System.Collections.Generic;
using System.IO;

namespace CustomCampaign.Models.Validators
{
    class FileValidator : IValidator
    {
        public List<string> DefaultInclude(Campaign campaign, string rootdirectory)
        {
            List<string> result = new List<string>();

            foreach (Level level in campaign.levels)
            {
                result.Add(level.file);
                result.Add($"{level.file}.png");

                foreach (string extension in new string[] { "mp3", "wav", "aiff"})
                {
                    string musicfile = $"{level.file}.{extension}";
                    FileInfo file = new FileInfo(Path.Combine(rootdirectory, musicfile));
                    if (file.Exists)
                        result.Add(musicfile);
                }

                if (!string.IsNullOrEmpty(level.loading_wallpaper))
                    result.Add(level.loading_wallpaper);
            }

            return result;
        }

        public bool Validate(Campaign campaign, string rootdirectory)
        {
            List<string> Files = new List<string>();
            Files.AddRange(DefaultInclude(campaign, rootdirectory));

            bool result = true;

            foreach (string file in Files)
            {
                FileInfo info = new FileInfo(Path.Combine(rootdirectory, file));
                result &= info.Exists;
                if (!result) return result;
            }

            return result;
        }
    }
}
