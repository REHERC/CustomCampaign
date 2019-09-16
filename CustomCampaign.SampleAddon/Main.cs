using CustomCampaign.Api;
using CustomCampaign.Data;
using CustomCampaign.Models;
using Spectrum.API.Logging;
using System;

namespace CustomCampaign.SampleAddon
{
    public class Main : Api.Addon
    {
        public Logger Log = null;

        public override void OnInit(CampaignInfo info)
        {
            Log = Factory.Logger("Output.log");

            Log.Success($"Hello World from {info.Name}");

            Log.Success($"{Info.Name} - OnInit");
        }

        public override void OnEnable()
        {
            Log.Success($"{Info.Name} - OnEnable");
        }

        public override void OnDisable()
        {
            Log.Success($"{Info.Name} - OnDisable");
        }

        public override void OnLevelStart(Models.Level level)
        {
            Log.Warning($"{level is null}");
            Log.Success($"{Info.Name} - OnLevelStart : {level.levelname}");
        }
    }
}
