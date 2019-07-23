namespace CustomCampaign.Models.Validators
{
    public interface IValidator
    {
        bool Validate(Campaign campaign, string rootdirectory);
    }
}
