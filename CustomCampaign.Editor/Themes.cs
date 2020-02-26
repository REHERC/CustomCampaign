using MaterialSkin;
using System.Collections.Generic;

namespace CustomCampaign.Editor
{
    public static class Themes
    {
        public static readonly Dictionary<string, ColorScheme> Values = new Dictionary<string, ColorScheme>() {
            {"Blue Grey", new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange400, TextShade.WHITE)},
            {"Snow", new ColorScheme(Primary.Grey400, Primary.Grey500, Primary.Grey300, (Accent)0x6f6f6f, (TextShade)0x6f6f6f)},
            {"Light Green", new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Light Blue", new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Pink", new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Amber", new ColorScheme(Primary.Amber700, Primary.Amber800, Primary.Amber400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Yellow", new ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Teal", new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal400, (Accent)0x7f7f7f, TextShade.WHITE)},
            {"Red", new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red400, (Accent)0x7f7f7f, TextShade.WHITE)}
        };
    }
}
