using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

namespace CustomCampaign.Editor.Controls
{
    public partial class LevelBrowser : MaterialSkin.Controls.MaterialUserControl
    {
        public LevelBrowser()
        {
            InitializeComponent();
        }


        public void RefreshList()
        {
            Levels.Items.Clear();
                AddRecursive(Editor.current_path);
            Levels.SelectedIndex = -1;
        }

        public void AddRecursive(string folder, int step = 16)
        {
            if (step <= 0) return;
            var info = new DirectoryInfo(folder);
            if (!info.Exists) return;

            foreach (var file in info.GetFiles("*.bytes"))
            {
                Levels.Items.Add(file.FullName.Substring(1+Editor.current_path.Length));
            }
            foreach (var subfolder in info.GetDirectories())
            {
                AddRecursive(subfolder.FullName, step - 1);
            }
        }

        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Levels.SelectedIndex < 0)
            {
                Thumbnail.Image = Resx.Resources.NoPreview;
                return;
            }

            string item = Levels.Items[Levels.SelectedIndex].ToString();

            string thumbnail = Path.Combine(Editor.current_path, $"{item}.png");
            if (File.Exists(thumbnail))
                Thumbnail.Image = Image.FromFile(thumbnail);
            else
                Thumbnail.Image = Resx.Resources.NoPreview;
        }

        private void LevelBrowser_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                RefreshList();
        }
    }
}
