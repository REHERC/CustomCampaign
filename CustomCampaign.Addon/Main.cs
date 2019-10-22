using CustomCampaign.Api;
using CustomCampaign.Data;
#if API_SPECTRUM
using Spectrum.API.Logging;
#endif
#if API_CENTRIFUGE
using Reactor.API.Logging;
#endif

namespace CustomCampaign.SampleAddon
{
    public class Main : Addon
    {
        public Logger Log = null;

        public override void OnInit(CampaignInfo info)
        {
            Log = Factory.Logger("Output");

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

        public override void OnLevelStart(Models.Level level, bool arcade)
        {
            Log.Success($"{arcade}\t{Info.Name} - OnLevelStart : {level.levelname}");
        }
    }
}
