﻿#pragma warning disable CS0436, IDE0069, RCS1197, CA1031
using CustomCampaign.Editor.Classes;
using CustomCampaign.Models;
using MaterialSkin;
using Newtonsoft.Json;
using Photon.Serialization;
using SharpCompress.Archives.Zip;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class ImportCampaignPage : Page
    {
        public string PreviousPage = "pages:home";

        public ImportCampaignPage()
        {
            InitializeComponent();

            BannerBackground.BackColor = Primary.Grey800.ToColor();
            BannerBackground.ForeColor = Primary.Grey100.ToColor();
            BannerText.Font = SkinManager.GetFont(10, true);
            BannerText.Text = "This file has been modified manually outside of the editor and might not match its description.".ToUpperInvariant();
            DisplayText.ForeColor = Primary.Grey900.ToColor();
            DisplayText.Font = SkinManager.GetFont(12, true);
            UpdateTextColors();
        }

        protected ZipArchive open_archive;
        protected Manifest manifest;
        protected string file_path;

        public void ImportFile(string path)
        {
            open_archive = ZipArchive.Open(path);
            file_path = path;

            manifest = new Manifest();

            bool md5_validity = true;

            foreach (var entry in open_archive.Entries)
            {
                if (entry.Key.StartsWith("data/"))
                {
                    string data_path = $".check/{entry.Key.Substring("data/".Length)}.md5";

                    try
                    {
                        ZipArchiveEntry check_entry = open_archive.Entries.Get(data_path);

                        string check_md5 = entry.GetMD5().Substring(0, 32);
                        string data_md5 = check_entry.ReadContent().Substring(0, 32);

                        md5_validity &= check_entry != null && data_md5.Equals(check_md5, StringComparison.InvariantCultureIgnoreCase);
                    }
                    catch (Exception)
                    {
                        md5_validity = false;
                    }
                }
                else if (string.Equals(entry.Key, "manifest", StringComparison.InvariantCultureIgnoreCase))
                {
                    manifest = JsonConvert.DeserializeObject<Manifest>(entry.ReadContent());
                }
            }
            BannerBackground.Visible = !md5_validity;

            TemplateCheck.Checked = false;
            SetDisplayedInfo();
        }

        private void SetDisplayedInfo()
        {
            StringBuilder display = new StringBuilder();

            display.AppendLine($"{manifest.name} by {manifest.authors}");
            display.AppendLine($"{manifest.description}");
            display.Append($"This campaign has {manifest.levels} level{(manifest.levels > 1 ? "s" : "")}");
            if (manifest.useaddons)
            {
                display.Append(" and uses custom code to add features");
            }
            display.AppendLine("");
            DisplayText.Text = display.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            open_archive.Dispose();
            Globals.MainWindow.SetPage(PreviousPage);
        }

        private void FormPanel_BackColorChanged(object sender, EventArgs e)
        {
            UpdateTextColors();
        }

        private void UpdateTextColors()
        {
            DisplayText.BackColor = SkinManager.GetApplicationBackgroundColor();
            DisplayText.ForeColor = SkinManager.GetPrimaryTextColor();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = file_path;
                dlg.ShowNewFolderButton = true;
                dlg.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (ZipArchiveEntry entry in from item in open_archive.Entries where item.Key.StartsWith("data/") select item)
                    {
                        FileInfo out_file = new FileInfo($@"{dlg.SelectedPath}\{entry.Key.Substring("data/".Length)}");
                        DirectoryInfo out_dir = new DirectoryInfo(out_file.DirectoryName);
                        if (!out_dir.Exists)
                        {
                            out_dir.Create();
                        }
                        entry.ExtractToFile(out_file.FullName, out_file.Exists);
                    }

                    Serializer<Campaign> campaign_file = new Serializer<Campaign>(SerializerType.Json, $@"{dlg.SelectedPath}\campaign.json", true);

                    if (TemplateCheck.Checked)
                    {
                        campaign_file.Data.guid = Guid.NewGuid().ToString();
                        campaign_file.Save();
                    }

                    Globals.OpenCampaign(campaign_file.FileName);
                }
            }
            open_archive.Dispose();
        }
    }
}
