using CustomCampaign.SDK.Data;
using Photon.Serialization;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

#pragma warning disable CS0168, RCS1003
namespace CustomCampaign.Forms
{
    public partial class PackForm : Form
    {
        public PackForm()
        {InitializeComponent();}

        public string _PakFile = "";
        public string _PakFileDir = "";
        private Campaign _campaign;

        public PackForm(string file)
        {
            InitializeComponent();

            if (file != "" && file != null && File.Exists(file))
            {
                _PakFile = file;
                _PakFileDir = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar;
                ListFiles();
            }
            else Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int errorcount = 0;

        public void ListFiles()
        {
            string root = Path.GetDirectoryName(_PakFileDir);
            LevelsBox.Items.Clear();
            errorcount = 0;
            _campaign = new Campaign();
            _campaign.Load(_PakFile);
            if (_campaign.logopath != "")
                AddItem(_campaign.logopath);
            foreach (Campaign.Level level in _campaign.levels)
            {
                AddItem(level.file);
                AddItem(level.file + ".png");

                if (level.loading_wallpaper != "")
                    AddItem(level.loading_wallpaper);
            }

            foreach (string addon in _campaign.addons)
            {
                AddItem(addon);
                string addonfile = Path.GetFullPath(Path.Combine(root, addon));
                AddOnManifest manifest;
                try
                {
                    new Serializer<AddOnManifest>(SerializerType.Json, addonfile, true).Save();
                    manifest = new Serializer<AddOnManifest>(SerializerType.Json, addonfile, true).Data;
                    string filename = $"/{addon}".Substring($"/{addon}".Replace(@"\", "/").LastIndexOf("/") + 1);
                    string fileroot = addon.Substring(0, addon.Length - filename.Length);
                    AddItem(fileroot + manifest.Module);
                    foreach (string dependency in manifest.Dependencies)
                        AddItem(fileroot + dependency);
                } catch (Exception pizza) { MessageBox.Show($"{pizza.Message}\n{pizza.Source}\n\n{pizza.StackTrace}", pizza.Message, MessageBoxButtons.OK ,MessageBoxIcon.Error); }
            }
        }

        public void AddItem(string file)
        {
            bool exists = FileExists(file);
            ListViewItem item = new ListViewItem(new string[] {
                file,
                exists ? "File found" : "File not found !"
            })
            {
                BackColor = exists ? SystemColors.Window : Color.Red,
                ForeColor = exists ? SystemColors.ControlText : Color.White
            };
            item.Font = exists ? item.Font : new Font(item.Font, FontStyle.Bold);
            LevelsBox.Items.Add(item);
            errorcount += exists ? 0 : 1;
        }

        private bool FileExists(string file)
        {
            return File.Exists(_PakFileDir + file.Replace('/', Path.DirectorySeparatorChar));
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ListFiles();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (!Campaign.Validate(_PakFile))
                ListFiles();
            if (errorcount == 0)
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
                {
                    FileName = "Campaign.zip",
                    Filter = "ZIP archive|*.zip",
                    DefaultExt = ".zip",
                    Title = "Export campaign as",
                    ValidateNames = true,
                    OverwritePrompt = true,
                    AddExtension = true
                };
                if (dlg.ShowDialog() == true)
                {
                    string _ZipFile = dlg.FileName;
                    string _ZipFileDir = Path.GetDirectoryName(_ZipFile);
                    if (File.Exists(_ZipFile))
                        File.Delete(_ZipFile);
                    _ZipFileDir = Path.GetFullPath(_ZipFileDir);
                    if (!_ZipFileDir.EndsWith(Path.DirectorySeparatorChar.ToString()))
                        _ZipFileDir += Path.DirectorySeparatorChar;
                    using (ZipArchive archive = ZipFile.Open(_ZipFile, ZipArchiveMode.Create))
                    {
                        archive.CreateEntryFromFile(_PakFile, $"{_campaign.name}/Campaign.json");
                        foreach (ListViewItem item in LevelsBox.Items)
                        {
                            string file = Path.GetFullPath(Path.Combine(_PakFileDir, item.Text));
                            archive.CreateEntryFromFile(file, $"{_campaign.name}/{item.Text}");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Campaign export failed due to missing files.\n" + ((errorcount == 1) ? $"{errorcount} file" : $"{errorcount} files") + " can't be located!");
        }
    }
}
