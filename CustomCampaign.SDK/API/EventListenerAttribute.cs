using System;

namespace CustomCampaign.SDK.API
{
    [AttributeUsage(AttributeTargets.Class)]
    class ListenerAttribute : Attribute
    {
        public Event Event { get; set; }

        public ListenerAttribute(Event _event)
        {
            this.Event = _event;
        }
    }
}
