using CustomCampaign.Storage;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using Spectrum.API.Storage;
using System.IO;
using System.Reflection;

namespace CustomCampaign.Api
{
    public static class Factory
    {
        public static Settings Settings(string file)
        {
            string id = Util.GetCampaignId();
            string directory = $"common/{id}";
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, directory));
            return new Settings($"{directory}/{file}");
        }

        public static Assets Assets(string path) => Spectrum.API.Storage.Assets.FromUnsafePath(Util.GetFilePath(path));

        public static Logger Logger(string file, bool output = true)
        {
            string directory = GetCommonPath(Assembly.GetCallingAssembly());
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, directory));
            return new Logger($"{directory}/{file}")
            {
                WriteToConsole = output
            };
        }

        private static string GetCommonPath(Assembly assembly) => $"common/{Util.GetCampaign(assembly)}";
    }
}
