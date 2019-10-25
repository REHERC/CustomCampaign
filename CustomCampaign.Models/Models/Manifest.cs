namespace CustomCampaign.Models
{
    public class Manifest
    {
        public string name = "";
        public string description = "";
        public string authors;
#if !LIMITED_COMPATIBILITY
        public string logo = "";
#endif
        public bool useaddons = false;
        public int levels = 0;
    }
}