using System.Windows.Forms;

#pragma warning disable RCS1110
public static class ExampleCampaign
{
    public static void Create01()
    {
        string path = $@"{Application.StartupPath}\Example.pak";

        Campaign c = new Campaign()
        {
            Name = "Space base Frontier-1",
            Description = "Welcome to space base Frontier-1, our newest space colony. We're waiting for you!",
            LogoPath = "Images/Campaign.png",
            Authors = "REHERC (Mich)",
            Levels = new System.Collections.Generic.List<Campaign.Level>()
                {
                    new Campaign.Level("Levels/SJ_Arrival.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Images/Loading.Arrival.png"),
                    new Campaign.Level("Levels/SJ_FarAway.bytes","[7BA7C6]Transportation Hub[-]","Terminal Alpha","Images/Loading.FarAway.png"),
                    new Campaign.Level("Levels/SJ_NewHome.bytes","[7BA7C6]Residential District[-]","Station Omicron","Images/Loading.NewHome.png"),
                    new Campaign.Level("Levels/SJ_Biosynthesis.bytes","[7BA7C6]Greenhouse[-]","Station Delta","Images/Loading.Biosynthesis.png"),
                    new Campaign.Level("Levels/SJ_Oxydation.bytes","[7BA7C6]Oxygen Production[-]","Station Epsilon","Images/Loading.Oxydation.png"),
                    new Campaign.Level("Levels/SJ_Gravity.bytes","[7BA7C6]Gravity Field Generator[-]","Station Theta","Images/Loading.Gravity.png"),
                    new Campaign.Level("Levels/SJ_Maintenance.bytes","[992F2F]Error[-]","[C45858]Maintenance required[-]","Images/Loading.Maintenance.png"),
                    new Campaign.Level("Levels/SJ_Threat.bytes","[992F2F]Evacuation Order[-]","[C45858]Leave the station immediately[-]","Images/Loading.Threat.png"),
                    new Campaign.Level("Levels/SJ_Contemplation.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Images/Loading.Contemplation.png")
                }
        };

        c.Save(path);
    }

    public static void Create02()
    {
        string path = $@"{Application.StartupPath}\Example.pak";

        Campaign c = new Campaign()
        {
            Name = "Example campaign",
            Description = "This campaign is meant to demonstrate how the tool works. It will be re-written on each application startup.",
            LogoPath = "Images/Campaign.png",
            Authors = "Author 1;Author 2;Author 3",
            Levels = new System.Collections.Generic.List<Campaign.Level>()
                {
                    new Campaign.Level("Levels/01.bytes","Level 01","Sector 01","Images/Loading.01.png"),
                    new Campaign.Level("Levels/02.bytes","Level 02","Sector 02","Images/Loading.02.png")
                }
        };

        c.Save(path);
    }
}