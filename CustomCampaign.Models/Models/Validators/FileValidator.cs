using System.Collections.Generic;
using System.IO;

#pragma warning disable IDE0028

namespace CustomCampaign.Models.Validators
{
    public class FileValidator : IValidator
    {
        public List<string> DefaultInclude(Campaign campaign, string rootdirectory)
        {
            List<string> result = new List<string>();

            result.Add("campaign.json");
#if !LIMITED_COMPATIBILITY
            if (!string.IsNullOrEmpty(campaign.logopath))
                result.Add(campaign.logopath);
#endif
            foreach (Level level in campaign.levels)
            {
                result.Add(level.file);
                result.Add($"{level.file}.png");

                foreach (string extension in new string[] { "mp3", "wav", "aiff" })
                {
                    string musicfile = $"{level.file}.{extension}";
                    FileInfo file = new FileInfo(Path.Combine(rootdirectory, musicfile));
                    if (file.Exists)
                        result.Add(musicfile);
                }
#if !LIMITED_COMPATIBILITY
                if (!string.IsNullOrEmpty(level.loading_wallpaper))
                    result.Add(level.loading_wallpaper);
#endif
            }

            foreach (Addon addon in campaign.addons)
            {
                result.Add(addon.module);
                result.AddRange(addon.dependencies);
            }

            return result;
        }

        public bool Validate(Campaign campaign, string rootdirectory, ref List<string> missingfiles)
        {
            List<string> Files = new List<string>();
            Files.AddRange(DefaultInclude(campaign, rootdirectory));

            bool result = true;

            foreach (string file in Files)
            {
                FileInfo info = new FileInfo(Path.Combine(rootdirectory, file));
                result &= info.Exists;
                if (!info.Exists) missingfiles.Add(info.FullName);
            }

            return result;
        }
    }
}
