using System;
using System.Windows.Forms;

namespace CustomCampaign.Forms
{
    public partial class LevelForm : Form
    {
        public Campaign.Level value;

        public LevelForm()
        {
            InitializeComponent();
        }

        public LevelForm(ListViewItem item)
        {
            InitializeComponent();
            if (item.SubItems.Count == 5)
            {
                value = new Campaign.Level(
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                    item.SubItems[4].Text
                );

                LevelFileBox.Text = value.file;
                LevelNameBox.Text = value.levelname;
                LevelSectorNameBox.Text = value.levelname_sub;
                LoadingBackgroundBox.Text = value.loading_wallpaper;
                LoadingTextBox.Text = value.loading_text;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            value = new Campaign.Level(
                    LevelFileBox.Text,
                    LevelNameBox.Text,
                    LevelSectorNameBox.Text,
                    LoadingBackgroundBox.Text,
                    LoadingTextBox.Text
                );
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LevelFileBox_TextChanged(object sender, EventArgs e)
        {
            bool requirements = LevelFileBox.Text != "" && LevelFileBox.Text.EndsWith(".bytes", StringComparison.OrdinalIgnoreCase);
            OkBtn.Enabled = requirements;
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
