﻿namespace CustomCampaign.Models
{
    public class Manifest
    {
        public long build = 0;
        public string guid = "";
        public string name = "";
        public string description = "";
        public string authors;
#if !LIMITED_COMPATIBILITY
        public string logo = "";
#endif
        public bool useaddons;
        public int levels = 0;
    }
}