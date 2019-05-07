namespace CustomCampaign.API.Events
{
    public interface IEvent
    {
        void EventRaised(EventParams parameters);
    }
}
