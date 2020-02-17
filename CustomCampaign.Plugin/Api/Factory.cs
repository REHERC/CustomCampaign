#pragma warning disable SecurityIntelliSenseCS
using CustomCampaign.Storage;
#if API_SPECTRUM
using Spectrum.API.Configuration;
using Spectrum.API.Logging;
using API_Storage = Spectrum.API.Storage;
#endif
#if API_CENTRIFUGE
using Reactor.API.Configuration;
using Reactor.API.Logging;
using API_Storage = Reactor.API.Storage;
#endif
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

        public static API_Storage.Assets Assets(string path) => API_Storage.Assets.FromUnsafePath(Util.GetFilePath(path));

#if API_SPECTRUM
        public static Logger Logger(string file, bool output = true)
        {
            string directory = $"{GetCommonPath(Assembly.GetCallingAssembly())}/Logs";
            Util.MakeDirectory(Path.Combine(Plugin.Files.RootDirectory, "Data/" + directory));
            return new Logger($"../Data/{directory}/{file}")
            {
                WriteToConsole = output
            };
        }
#endif
        private static string GetCommonPath(Assembly assembly) => $"Common/{Util.GetCampaign(assembly).Id}";
    }
}
