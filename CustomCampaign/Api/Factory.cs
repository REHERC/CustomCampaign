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
            string directory = $"{GetCommonPath(Assembly.GetCallingAssembly())}/Settings";
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, "Data/" + directory));
            return new Settings($"../Data/{directory}/{file}");
        }

        public static Assets Assets(string path) => Spectrum.API.Storage.Assets.FromUnsafePath(Util.GetFilePath(path));

        public static Logger Logger(string file, bool output = true)
        {
            string directory = $"{GetCommonPath(Assembly.GetCallingAssembly())}/Logs";
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, "Data/" + directory));
            return new Logger($"../Data/{directory}/{file}")
            {
                WriteToConsole = output
            };
        }

        private static string GetCommonPath(Assembly assembly) => $"Common/{Util.GetCampaign(assembly).Id}";
    }
}
