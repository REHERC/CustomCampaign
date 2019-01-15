using Spectrum.API.Interfaces.Systems;

namespace CustomCampaign.SDK.API
{
    public interface IAddOn
    {
        void Setup(IManager manager, string workspace);
    }
}
