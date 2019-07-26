using CustomCampaign.Editor.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class ImportCampaignPage : Page
    {
        public ImportCampaignPage()
        {
            InitializeComponent();
        }

        public void ImportFile(string path)
        {
            ZipArchive archive = ZipFile.OpenRead(path);

            bool md5_validity = true;

            foreach (var entry in archive.Entries)
            {
                if (entry.FullName.StartsWith(".check") && entry.FullName.EndsWith(".md5"))
                {
                    string data_path = $"data/{entry.FullName.Substring(".ckeck/".Length)}";
                    data_path = data_path.Remove(data_path.Length - ".md5".Length);

                    ZipArchiveEntry data_entry = archive.GetEntry(data_path);

                    string data_md5 = data_entry.GetMD5().ToString().Substring(0, 32);
                    string check_md5 = entry.ReadContent().ToString().Substring(0, 32);

                    md5_validity &= data_md5.Equals(check_md5, StringComparison.InvariantCultureIgnoreCase);
                }
            }
            MessageBox.Show($"{md5_validity}");
        }
    }
}
