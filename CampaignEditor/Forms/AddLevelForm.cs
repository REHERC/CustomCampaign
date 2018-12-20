using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomCampaign.Forms
{
    public partial class AddLevelForm : Form
    {
        public Campaign.Level value;

        public AddLevelForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            value = new Campaign.Level(
                    LevelFileBox.Text,
                    LevelNameBox.Text,
                    LevelSectorNameBox.Text,
                    LoadingBackgroundBox.Text
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
            bool requirements =
                LevelFileBox.Text != "" &&
                LevelFileBox.Text.ToLower().EndsWith(".bytes");

            OkBtn.Enabled = requirements;
        }
    }
}
