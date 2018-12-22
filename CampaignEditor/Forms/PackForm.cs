using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomCampaign.Forms
{
    public partial class PackForm : Form
    {
        public PackForm()
        {InitializeComponent();}

        public string PakFile = "";
        public string PakFileDir = "";
        Campaign campaign;

        public PackForm(string file)
        {
            InitializeComponent();

            if (file != "" && file != null && File.Exists(file))
            {
                PakFile = file;
                PakFileDir = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar;

                ListFiles();

                Show();
            }
            else Dispose();
        }

        private void PackForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int errorcount = 0;

        void ListFiles()
        {
            LevelsBox.Items.Clear();

            errorcount = 0;

            campaign = new Campaign();
            campaign.Load(PakFile);

            AddItem(campaign.LogoPath);
            foreach (Campaign.Level level in campaign.Levels)
            {
                AddItem(level.file);
                AddItem(level.file + ".png");

                if (level.loading_wallpaper != "")
                    AddItem(level.loading_wallpaper);
            }
        }

        void AddItem(string file)
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

        bool FileExists(string file)
        {
            return File.Exists(PakFileDir + file.Replace('/', Path.DirectorySeparatorChar));
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ListFiles();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (errorcount == 0)
            {

            }
            else
                MessageBox.Show("Campaign export failed.\n" + ((errorcount == 1) ? $"{errorcount} file was not found !" : $"{errorcount} files were not found !"));
        }
    }
}
