#pragma warning disable SecurityIntelliSenseCS, CS0436, CA1031
using CustomCampaign.Editor.Classes;
using CustomCampaign.Editor.Exceptions;
using CustomCampaign.Editor.Forms;
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

            if (flag && SetupProject(out string path))
            {
                Globals.IsFileOpened = true;
                Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
                Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(path);
                Globals.MainWindow.SetPage("pages:editormain");
            }
        }

        private void BrowseBtn_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog()
            {
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

        private bool SetupProject(out string campaign_file)
        {
            campaign_file = string.Empty;
            try
            {
                string directory_path = Path.Combine(CampaignDirectory.Text, CampaignName.Text).RemoveIllegalPathChars();

                if (directory_path.ContainsIllegalName())
                {
                    throw new ReservedFileNameException();
                }

                DirectoryInfo directory = new DirectoryInfo(directory_path);

                if (!directory.Exists)
                {
                    directory.Create();
                }

                if (new List<string>(from file in directory.GetFiles() select file.Name.ToLower()).Contains("campaign.json"))
                {
                    MessageDialog.Show("A campaign project already exists in this folder.");
                    return false;
                }

                directory.CreateSubdirectory("levels");
                directory.CreateSubdirectory("addons");

                Campaign campaign = new Campaign
                {
                    guid = Guid.NewGuid().ToString(),
                    name = CampaignName.Text,
                    description = CampaignDescription.Text
                };

                campaign_file = Path.Combine(directory.FullName, "campaign.json");

                new Serializer<Campaign>(SerializerType.Json,
                    campaign_file
                    , false, true)
                {
                    Data = campaign
                }.Save();
            }
            catch (ReservedFileNameException rfne)
            {
                MessageDialog.Show(rfne.Message, "Invalid file name!");
                return false;
            }
            catch (Exception e)
            {
                MessageDialog.Show($"{e.Message}\n----------\n{e.Source}\n{e.StackTrace}", e.Source);
                return false;
            }
            return true;
        }
    }
}
