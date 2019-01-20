using System;
using System.Windows.Forms;

namespace CustomCampaign.Forms
{
    public partial class AddonForm : Form
    {
        public string value = "";
        
        public AddonForm()
        {
            InitializeComponent();
        }

        public AddonForm(ListViewItem item)
        {
            InitializeComponent();

            if (item.SubItems.Count == 1)
            {
                value = item.SubItems[0].Text;
            }

            AddonFileBox.Text = value;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            value = AddonFileBox.Text;
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
            bool requirements =
                AddonFileBox.Text != "" &&
                AddonFileBox.Text.ToLower().EndsWith(".json");

            OkBtn.Enabled = requirements;
        }
    }
}
