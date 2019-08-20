using System.Collections.Generic;

namespace CustomCampaign.Models.Validators
{
    public interface IValidator
    {
        bool Validate(Campaign campaign, string rootdirectory, ref List<string> missingfiles);
    }
}
