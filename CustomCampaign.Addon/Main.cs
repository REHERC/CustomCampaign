using CustomCampaign.Api;
using CustomCampaign.Data;
using System;

namespace CustomCampaign.SampleAddon
{
    public class Main : Addon
    {
        public override void OnInit(CampaignInfo info)
        {
            Console.WriteLine($"Hello World from {info.Name}");
            Console.WriteLine($"{Info.Name} - OnInit");
        }

        public override void OnEnable()
        {
            Console.WriteLine($"{Info.Name} - OnEnable");
        }

        public override void OnDisable()
        {
            Console.WriteLine($"{Info.Name} - OnDisable");
        }

        public override void OnLevelStart(Models.Level level, bool arcade)
        {
            Console.WriteLine($"{arcade}\t{Info.Name} - OnLevelStart : {level.levelname}");
        }
    }
}
