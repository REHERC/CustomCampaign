using CustomCampaign.Editor.Classes;
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

            //foreach (var entry in archive.Entries)
            //    MessageBox.Show(entry.FullName);
        }
    }
}
