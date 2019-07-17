using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class StartPage : Classes.Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void TutorialsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/REHERC/CustomCampaign/wiki");
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Globals.MainWindow.GetPage<NewCampaignWizard>("pages:newcampaignwizard").PreviousPage = "pages:home";
            Globals.MainWindow.SetPage("pages:newcampaignwizard");
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Globals.OpenCampaign();
        }
    }
}
