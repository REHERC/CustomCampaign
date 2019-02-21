using CustomCampaign.SDK.Data;
using System.Collections.Generic;

namespace CustomCampaign
{
    public class AddonInfo
    {
        public string Id { get; set; }
        public List<string> Dependencies { get; set; }
        public string Module { get; set; }
        public string Name { get; set; }
        public List<Author> Authors { get; set; }

        public AddonInfo(CampaignInfo campaign, string manifest)
        {
            this.Id = campaign.Id;

        }
    }
}
