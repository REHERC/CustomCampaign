using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spectrum.API.Experimental;
using Spectrum.API.Logging;
using Spectrum.API.Storage;

namespace CustomCampaign
{
    public static class SharedResources
    {
        public static string GetLevelFullPath(string file)
        {
            return $@"{File.RootDirectory}\Levels\{file}".Replace(@"\","/");
        }

        public static void Init()
        {
            Log = new Logger("CustomCampaignDev");
            Log.WriteToConsole = true;

            File = new FileSystem();
        }

        public static FileSystem File;
        public static Logger Log;
    }
}
