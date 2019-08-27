using CustomCampaign.Api;
using CustomCampaign.Data;
using Spectrum.API.Logging;

namespace CustomCampaign.SampleAddon
{
    public class Main : Addon
    {
        public Logger Log = null;

        public override void OnInit(CampaignInfo info)
        {
            Log = Factory.Logger("Output.log");

            Log.Success($"Hello World from {info.Name}");
        }

        public override void OnEnable()
        {
            
        }

        public override void OnDisable()
        {
            
        }
    }
}
