using CustomCampaign.Editor.Classes;
using CustomCampaign.Models;
using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class NewCampaignWizard : Page
    {
        public string PreviousPage = "pages:home";

        public NewCampaignWizard()
        {
            InitializeComponent();
        }

        public override void OnDisplay()
        {
            base.OnDisplay();

            CampaignName.Text = CampaignDescription.Text = "";
            CampaignDirectory.Text = "Directory (required)";
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Globals.MainWindow.SetPage(PreviousPage);
        }

        private void CreateBtn_Click(object sender, System.EventArgs e)
        {
            bool flag
             = !string.IsNullOrEmpty(CampaignName.Text)
            && !string.IsNullOrEmpty(CampaignDirectory.Text)
            && Directory.Exists(CampaignDirectory.Text);

            if (flag && SetupProject())
            {
                Globals.IsFileOpened = true;
                Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
                Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(Path.Combine(CampaignDirectory.Text, "campaign.json"));
                Globals.MainWindow.SetPage("pages:editormain");
            }
        }

        private void BrowseBtn_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog() {
                Description = "Locate the directory where you want to create your custom campaign",
                RootFolder = System.Environment.SpecialFolder.MyComputer
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.SelectedPath))
                {
                    CampaignDirectory.Text = dlg.SelectedPath;
                }
            }
        }

        private bool SetupProject()
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(CampaignDirectory.Text);

                if (new List<string>(from file in directory.GetFiles() select file.Name.ToLower()).Contains("campaign.json"))
                {
                    MessageBox.Show("A campaign project already exists in this folder.");
                    return false;
                }

                directory.Create();
                directory.CreateSubdirectory("levels");
                directory.CreateSubdirectory("addons");

                Campaign campaign = new Campaign();
                campaign.name = CampaignName.Text;
                campaign.description = CampaignDescription.Text;

                new Serializer<Campaign>(SerializerType.Json,
                    Path.Combine(CampaignDirectory.Text, "campaign.json")
                    , false, true)
                {
                    Data = campaign
                }.Save();
            }
            catch (Exception e) {
                MessageBox.Show($"{e.Message}\n----------\n{e.Source}\n{e.StackTrace}", e.Source);
                return false;
            }
            return true;
        }
    }
}
