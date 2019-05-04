using System;

namespace CustomCampaign.SDK.API
{
    [Flags]
    public enum Event
    {
        Addon_Load,
        Addon_Update,
        Addon_Unload
    }
}
