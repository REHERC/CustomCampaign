using SharpCompress.Common;

namespace CustomCampaign.Editor
{
    public static class Constants
    {
        public const string LevelDialogFilter = "Distance level file|*.bytes";
        public const string CampaignDialogFilter = "Project file|Campaign.json";
        public const string ExportDialogFilter = "Compressed campaign|*.campaign";

        public const string BIG_SPIN = "https://www.youtube.com/watch?v=5bzhUtrbI_A";
        public const string BIG_SPIN_MESSAGE = "Well done, you found an easter egg!\nEnjoy this high quality content and have a nice day...\n\nBIG SPIN";

        public const CompressionType COMPRESSION_MODE = CompressionType.LZMA;
    }
}
