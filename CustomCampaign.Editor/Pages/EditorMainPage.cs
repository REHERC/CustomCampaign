using CustomCampaign.Data;
using CustomCampaign.Editor.Classes;
using CustomCampaign.Editor.Forms;
using CustomCampaign.Models;
using Newtonsoft.Json;
using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Documents;
using System.Windows.Forms;

#pragma warning disable CS0436

namespace CustomCampaign.Editor.Pages
{
    public partial class EditorMainPage : Page
    {
        public EditorMainPage()
        {
            InitializeComponent();

            foreach (var mode in GameModeId.ConversionTable)
                CampaignGamemode.Items.Add(mode.Key);

            AddonsTab.Dispose();
        }

        public override void OnDisplay()
        {
            base.OnDisplay();
        }

        public void GoToSettingsTab()
        {
            TabPages.SelectedTab = SettingsTab;
        }

        public void GoToFileTab()
        {
            TabPages.SelectedTab = FileTab;
        }

        private void NewBtn_Click(object sender, System.EventArgs e)
        {
            Globals.MainWindow.GetPage<NewCampaignWizard>("pages:newcampaignwizard").PreviousPage = PageName;
            Globals.MainWindow.SetPage("pages:newcampaignwizard");
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.IsFileOpened = false;
                Globals.MainWindow.SetPage("pages:home");
            }
        }

        private void OpenBtn_Click(object sender, System.EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.OpenCampaign();
            }
        }

        DialogResult ClosseDialog()
        {
            return MessageBox.Show("Are you sure you want to close this project?\nAny unsaved changes will be discarded!", "Close project", MessageBoxButtons.YesNo);
        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            SaveCampaign();
        }

        private void CampaignInfoChanged(object sender, System.EventArgs e)
        {
            Overview.Title = CampaignName.Text;
            Overview.Description = CampaignDescription.Text;
        }

        public void LoadCampaign(string path)
        {
            #region File loading
            FileInfo file = new FileInfo(path);
            if (!file.Exists) throw new FileNotFoundException($"The file \"{path}\" does not exist!");

            Config.AppendRecentFile(file.FullName);

            Serializer<Campaign> serializer = new Serializer<Campaign>(SerializerType.Json, path, true);
            Editor.current_campaign = serializer.Data;
            Editor.current_path = file.DirectoryName;
            #endregion

            #region Filling the user interface with the data
            Levels.Items.Clear();

            CampaignName.Text = Editor.current_campaign.name;
            CampaignDescription.Text = Editor.current_campaign.description;
            CampaignLogo.Text = Editor.current_campaign.logopath;
            CampaignAuthors.Text = Editor.current_campaign.authors;

            CampaignUnlockStyle.SelectedIndex = Editor.current_campaign.lockmode;
            CampaignGamemode.SelectedIndex = GameModeId.GetIndexFromId(Editor.current_campaign.gamemode);

            foreach (Level level in Editor.current_campaign.levels)
            {
                Levels.Items.Add(level);
            }

            #endregion


            Levels.SelectedIndex = -1;
            Levels_SelectedIndexChanged(Levels, new EventArgs());
        }

        public Campaign UpdateWorkingstate()
        {
            Campaign _ = Editor.current_campaign;

            _.name = CampaignName.Text;
            _.description = CampaignDescription.Text;
            _.logopath = CampaignLogo.Text;
            _.authors = CampaignAuthors.Text;
            _.lockmode = CampaignUnlockStyle.SelectedIndex;
            _.gamemode = GameModeId.GetIdFromIndex(CampaignGamemode.SelectedIndex);

            _.levels = new List<Level>();
            foreach (Level level in Levels.Items)
                _.levels.Add(level);

            return (Editor.current_campaign = _);
        }

        public void SaveCampaign()
        {
            Serializer<Campaign> serializer = new Serializer<Campaign>(SerializerType.Json,
            Path.Combine(Editor.current_path, "campaign.json"), false)
            {
                Data = UpdateWorkingstate()
            };
            serializer.Save();
        }

        private void LevelsMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flag = Levels.SelectedIndex >= 0;
            EditLevel.Enabled = flag;
            RemoveLevel.Enabled = flag;
        }

        private void AddLevel_Click(object sender, System.EventArgs e)
        {
            AddLevel_Run();
        }

        private void AddLevel_Run()
        {
            int index = Levels.SelectedIndex;
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").Setup(new Level(), "Add a level");
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Levels.Items.Insert(index + 1, data);
                Globals.MainWindow.SetPage("pages:editormain");
            };
            Globals.MainWindow.SetPage("pages:editlevel");
        }

        private void Levels_DoubleClick(object sender, System.EventArgs e)
        {
            EditLevel_Run();
        }

        private void EditLevel_Click(object sender, System.EventArgs e)
        {
            EditLevel_Run();
        }

        void EditLevel_Run()
        {
            int index = Levels.SelectedIndex;
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").Setup((Level)Levels.Items[index], "Edit a level");
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Levels.Items[index] = data;
                Globals.MainWindow.SetPage("pages:editormain");
            };
            Globals.MainWindow.SetPage("pages:editlevel");
        }

        private void RemoveLevel_Click(object sender, System.EventArgs e)
        {
            RemoveLevel_Run();
        }

        private void RemoveLevel_Run()
        {
            if (Levels.SelectedIndex >= 0 && MessageBox.Show("Are you sure you want to remove this level from the list?", "Remove level", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Levels.Items.RemoveAt(Levels.SelectedIndex);
        }

        private void PackBtn_Click(object sender, System.EventArgs e)
        {
            ExportToZip();
        }

        public void ExportToZip()
        {
            Campaign campaign = UpdateWorkingstate();

            if (!campaign.Validate(Editor.current_path, out List<string> missingfiles))
            {
                ShowMissingFiles(missingfiles);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                dlg.Filter = Constants.ExportDialogFilter;
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;
                dlg.OverwritePrompt = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dlg.FileName))
                            File.Delete(dlg.FileName);

                    using (ZipArchive archive = ZipFile.Open(dlg.FileName, ZipArchiveMode.Create))
                    {
                        foreach (string file in campaign.IncludedFiles(Editor.current_path))
                        {
                            FileInfo include = new FileInfo(Path.Combine(Editor.current_path, file));
                            archive.CreateEntryFromFile(include.FullName, $"data/{file}");

                            archive.CreateEntry($".check/{file}.md5").WriteContent(include.GetMD5());
                        }
                        archive.CreateEntry("manifest").WriteContent
                        (
                            JsonConvert.SerializeObject(new Models.Manifest()
                            {
                                name = campaign.name,
                                description = campaign.description,
                                authors = campaign.authors,
                                useaddons = campaign.addons.Count > 0,
                                levels = campaign.levels.Count,
                                logo = $"data/{campaign.logopath}"
                            }, Formatting.Indented)
                        );

                        archive.CreateEntry("readme.txt").WriteContent("Don't modify the content of this archive manually or it might not work anymore!");
                    }
                }
            }
        }

        void ShowMissingFiles(List<string> files, string title = "Campaign export failed")
        {
            using (MissingFilesDialog dlg = new MissingFilesDialog(files))
            {
                dlg.Title = title;
                dlg.ShowDialog();
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Campaign campaign = UpdateWorkingstate();

            if (campaign.Validate(Editor.current_path, out List<string> files))
                MessageBox.Show("File check complete, no files were missing.");
            else
                ShowMissingFiles(files, "File check failed");
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Editor.current_path);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.MainWindow.GetPage<ImportCampaignPage>("pages:importcampaign").PreviousPage = PageName;
                Globals.ImportCampaign();
            }
        }

        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveLevelBtn.Enabled = EditLevelBtn.Enabled = Levels.SelectedIndex > -1;
        }

        private void AddLevelBtn_Click(object sender, EventArgs e)
        {
            AddLevel_Run();
        }

        private void EditLevelBtn_Click(object sender, EventArgs e)
        {
            EditLevel_Run();
        }

        private void RemoveLevelBtn_Click(object sender, EventArgs e)
        {
            RemoveLevel_Run();
        }
    }
}
