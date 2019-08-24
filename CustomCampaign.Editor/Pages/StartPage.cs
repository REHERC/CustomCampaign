using CustomCampaign.Editor.Forms;
using CustomCampaign.Models;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
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
            Globals.MainWindow.GetPage<NewCampaignWizard>("pages:newcampaignwizard").PreviousPage = PageName;
            Globals.MainWindow.SetPage("pages:newcampaignwizard");
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Globals.OpenCampaign();
        }

        public override void OnDisplay()
        {
            base.OnDisplay();

            SetupRecentList();
        }

        void SetupRecentList()
        {
            RecentList.Controls.Clear();

            MaterialFlatButton button;
            MaterialContextMenuStrip menu;

            foreach (string file in Config.GetRecentFiles())
            {
                Campaign campaign = Campaign.FromFile(file);

                if (!campaign) continue;

                RecentList.Controls.Add(button = new MaterialFlatButton()
                {
                    Text = campaign.name,
                    Dock = DockStyle.Top,
                    MaximumSize = new Size(0, 28),
                    Tag = file,
                });

                menu = new MaterialContextMenuStrip();
                menu.Items.Add("Remove", null, (sender, e) => {
                    Config.RemoveRecentFile(file);
                    SetupRecentList();
                });

                button.Click += (sender, e) =>
                {
                    Globals.IsFileOpened = true;
                    Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
                    Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(file);
                    Globals.MainWindow.SetPage("pages:editormain");
                };

                button.ContextMenuStrip = menu;

                button.BringToFront();
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            Globals.MainWindow.GetPage<ImportCampaignPage>("pages:importcampaign").PreviousPage = PageName;
            Globals.ImportCampaign();
        }

        private void SecretSpookButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Aaaaaaa dlg = new Aaaaaaa())
            {
                dlg.ShowDialog();
            }
        }
    }
}
