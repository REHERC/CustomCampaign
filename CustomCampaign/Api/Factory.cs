﻿using Spectrum.API.Configuration;
using Spectrum.API.Storage;

namespace CustomCampaign.Api
{
    public static class Factory
    {
        public static Settings LoadSettings(string path)
        {
            if (false)
                return new Settings($"<id>/<path>");

            return null;
        }

        public static Assets LoadAssets(string path)
        {
            return Assets.FromUnsafePath(path);
        }
    }
}
