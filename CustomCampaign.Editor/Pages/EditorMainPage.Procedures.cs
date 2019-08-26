﻿using CustomCampaign.Data;
using CustomCampaign.Editor.Forms;
using CustomCampaign.Models;
using Newtonsoft.Json;
using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

#pragma warning disable CS0436

namespace CustomCampaign.Editor.Pages
{
    partial class EditorMainPage
    {
        public void GoToSettingsTab() => EditorTabs.SelectedTab = SettingsTab;
        public void GoToFileTab() => EditorTabs.SelectedTab = FileTab;
        DialogResult ClosseDialog() => MessageBox.Show("Are you sure you want to close this project?\nAny unsaved changes will be discarded!", "Close project", MessageBoxButtons.YesNo);

        #region Save and Load
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
            Addons.Items.Clear();

            CampaignName.Text = Editor.current_campaign.name;
            CampaignDescription.Text = Editor.current_campaign.description;
            CampaignLogo.Text = Editor.current_campaign.logopath;
            CampaignAuthors.Text = Editor.current_campaign.authors;

            CampaignUnlockStyle.SelectedIndex = Editor.current_campaign.lockmode;
            CampaignGamemode.SelectedIndex = GameModeId.GetIndexFromId(Editor.current_campaign.gamemode);

            Editor.current_campaign.levels.ForEach((level) => Levels.Items.Add(level));
            Editor.current_campaign.addons.ForEach((addon) => Addons.Items.Add(addon));

            UpdateOverviewList();
            #endregion

            Levels.SelectedIndex = -1;
            Addons.SelectedIndex = -1;
            Levels_SelectedIndexChanged(Levels, new EventArgs());
            Addons_SelectedIndexChanged(Levels, new EventArgs());

            
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
            Levels.Items.Cast<Level>().ToList().ForEach((level) => _.levels.Add(level));

            _.addons = new List<Addon>();
            Addons.Items.Cast<Addon>().ToList().ForEach((addon) => _.addons.Add(addon));

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
        
        public void UpdateOverviewList()
        {
            void SetDataSource(object value)
            {
                OverviewLevels.DataSource = value;
                OverviewLevels.Refresh();
                OverviewLevels.Update();
            }

            SetDataSource(Levels.Items.Cast<Level>().ToArray());
        }
        #endregion

        #region Export and Validation
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

        private void Validate_Run()
        {
            Campaign campaign = UpdateWorkingstate();

            if (campaign.Validate(Editor.current_path, out List<string> files))
                MessageBox.Show("File check complete, no files were missing.");
            else
                ShowMissingFiles(files, "File check failed");
        }

        private void ShowMissingFiles(List<string> files, string title = "Campaign export failed")
        {
            using (MissingFilesDialog dlg = new MissingFilesDialog(files))
            {
                dlg.Title = title;
                dlg.ShowDialog();
            }
        }
        #endregion

        #region Level List Managment
        private void AddLevel_Run()
        {
            int index = Levels.SelectedIndex;
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").Setup(new Level(), "Add a level");
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Levels.Items.Insert(index + 1, data);
                Globals.MainWindow.SetPage("pages:editormain");
                Levels_SelectedIndexChanged(Levels, new EventArgs());
                UpdateOverviewList();
            };
            Globals.MainWindow.SetPage("pages:editlevel");
        }

        private void EditLevel_Run()
        {
            int index = Levels.SelectedIndex;

            if (!(index > -1 & index < Levels.Items.Count)) return;

            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").Setup((Level)Levels.Items[index], "Edit a level");
            Globals.MainWindow.GetPage<EditLevelPage>("pages:editlevel").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Levels.Items[index] = data;
                Globals.MainWindow.SetPage("pages:editormain");
                Levels_SelectedIndexChanged(Levels, new EventArgs());
                UpdateOverviewList();
            };
            Globals.MainWindow.SetPage("pages:editlevel");
        }

        private void RemoveLevel_Run()
        {
            if (Levels.SelectedIndex >= 0 && MessageBox.Show("Are you sure you want to remove this level from the list?", "Remove level", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Levels.Items.RemoveAt(Levels.SelectedIndex);
            UpdateOverviewList();
        }
        #endregion

        #region Addon List Managment
        private void AddAddon_Run()
        {
            int index = Addons.SelectedIndex;
            Globals.MainWindow.GetPage<EditAddonPage>("pages:editaddon").Setup(new Addon(), "Add an addon");
            Globals.MainWindow.GetPage<EditAddonPage>("pages:editaddon").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Addons.Items.Insert(index + 1, data);
                Globals.MainWindow.SetPage("pages:editormain");
                Addons_SelectedIndexChanged(Addons, new EventArgs());
            };
            Globals.MainWindow.SetPage("pages:editaddon");
        }

        private void EditAddon_Run()
        {
            int index = Addons.SelectedIndex;

            if (!(index > -1 & index < Addons.Items.Count)) return;

            Globals.MainWindow.GetPage<EditAddonPage>("pages:editaddon").Setup((Addon)Addons.Items[index], "Edit an addon");
            Globals.MainWindow.GetPage<EditAddonPage>("pages:editaddon").PageClosed = (result, data) => {
                if (result == DialogResult.OK)
                    Addons.Items[index] = data;
                Globals.MainWindow.SetPage("pages:editormain");
                Addons_SelectedIndexChanged(Addons, new EventArgs());
            };
            Globals.MainWindow.SetPage("pages:editaddon");
        }

        private void RemoveAddon_Run()
        {
            if (Addons.SelectedIndex >= 0 && MessageBox.Show("Are you sure you want to remove this addon from the list?", "Remove addon", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Addons.Items.RemoveAt(Addons.SelectedIndex);
        }
        #endregion
    }
}
