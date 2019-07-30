using CustomCampaign.Editor.Classes;
using CustomCampaign.Models;
using MaterialSkin;
using Newtonsoft.Json;
using System;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class ImportCampaignPage : Page
    {
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

        public void ImportFile(string path)
        {
            using (ZipArchive archive = (open_archive = ZipFile.OpenRead(path)))
            {
                manifest = new Manifest();

                bool md5_validity = true;

                foreach (var entry in archive.Entries)
                {
                    if (entry.FullName.StartsWith("data/"))
                    {
                        string data_path = $".check/{entry.FullName.Substring("data/".Length)}.md5";

                        try
                        {
                            ZipArchiveEntry check_entry = archive.GetEntry(data_path);

                            string check_md5 = entry.GetMD5().ToString().Substring(0, 32);
                            string data_md5 = check_entry.ReadContent().ToString().Substring(0, 32);

                            md5_validity &= check_entry != null && data_md5.Equals(check_md5, StringComparison.InvariantCultureIgnoreCase);
                        }
                        catch (Exception)
                        {
                            md5_validity = false;
                        }
                    }
                    else if (entry.FullName == "manifest")
                    {
                        manifest = JsonConvert.DeserializeObject<Manifest>(entry.ReadContent());
                    }
                }
                BannerBackground.Visible = !md5_validity;

                TemplateCheck.Checked = false;
                SetDisplayedInfo();
            }
        }

        private void SetDisplayedInfo()
        {
            StringBuilder display = new StringBuilder();

            display.AppendLine($"{manifest.name} by {manifest.authors}");
            display.AppendLine($"{manifest.description}");
            display.AppendLine($"This campaign has {manifest.levels} level{(manifest.levels > 1 ? "s" : "")}");
            if (manifest.useaddons)
                display.Append($" and uses custom code to add features");
            DisplayText.Text = display.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Globals.MainWindow.SetPage("pages:home");
        }

        private void FormPanel_BackColorChanged(object sender, EventArgs e)
        {
            UpdateTextColors();
        }

        void UpdateTextColors()
        {
            DisplayText.BackColor = SkinManager.GetApplicationBackgroundColor();
            DisplayText.ForeColor = SkinManager.GetPrimaryTextColor();
        }

    }
}
