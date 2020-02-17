#pragma warning disable SecurityIntelliSenseCS
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using static Extensions;

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
                LevelName.Text = "No level selected.";
                FileSize.Text = "0 Kb";
                return;
            }

            string item = Levels.Items[Levels.SelectedIndex].ToString();

            string file = Path.Combine(Editor.current_path, item);

            string thumbnail = $"{file}.png";
            if (File.Exists(thumbnail))
            {
                Thumbnail.Image = Image.FromFile(thumbnail);
            }
            else
            {
                Thumbnail.Image = Resx.Resources.NoPreview;
            }

            string name = Path.GetFileNameWithoutExtension(file);
            LevelName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);

            string size = new FileInfo(file).Length.ToFileSize();
            size = $"{size.Replace(',','.').Remove(size.Length - 1)}b";
            FileSize.Text = size;
        }

        public void SetSelection(string selected)
        {
            foreach(string level in Levels.Items )
            {
                int index = Levels.Items.IndexOf(level);
                string file = Levels.Items[index].ToString();
                if (string.Equals(file, selected, StringComparison.OrdinalIgnoreCase))
                {
                    Levels.SelectedIndex = index;
                    return;
                }
            }
            Levels.SelectedIndex = -1;
        }

        public string GetSelection()
        {
            if (Levels.SelectedIndex > -1)
            {
                return Levels.SelectedItem.ToString();
            }
            return string.Empty;
        }

        private void LevelBrowser_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                RefreshList();
            }
        }
    }
}
