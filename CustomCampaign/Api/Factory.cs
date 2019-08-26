using CustomCampaign.Storage;
using Spectrum.API.Configuration;
using Spectrum.API.Storage;
using System.IO;

namespace CustomCampaign.Api
{
    public static class Factory
    {
        public static Settings LoadSettings(string path)
        {
            string id = Util.GetCampaignId();
            string directory = $"common/{id}";
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, directory));
            return new Settings($"{directory}/{path}");
        }

        public static Assets LoadAssets(string path) => Assets.FromUnsafePath(Util.GetFilePath(path));
    }
}
