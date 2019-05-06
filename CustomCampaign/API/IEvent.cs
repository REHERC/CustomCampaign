namespace CustomCampaign.API
{
    public interface IEvent
    {
        void EventRaised(EventParams parameters);
    }
}
