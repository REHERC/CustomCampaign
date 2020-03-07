using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCampaign.Editor.Forms
{
    public partial class MissingFilesDialog : MaterialSkin.Controls.MaterialForm
    {
        public MissingFilesDialog()
        {
            InitializeComponent();
        }

        public MissingFilesDialog(List<string> files)
        {
            InitializeComponent();

            StringBuilder builder = new StringBuilder();

            foreach (string file in files)
                builder.AppendLine($"File not found: \"{file}\"");

            DisplayText.Text = builder.ToString();
        }

        private void MissingFilesDialog_Shown(object sender, EventArgs e)
        {
            DisplayText.ForeColor = Primary.Grey900.ToColor();
            DisplayText.Font = SkinManager.GetFont(12, true);
            UpdateTextColors();
        }

        private void UpdateTextColors()
        {
            DisplayText.BackColor = SkinManager.GetApplicationBackgroundColor();
            DisplayText.ForeColor = SkinManager.GetPrimaryTextColor();
        }

        private void MainPanel_BackColorChanged(object sender, EventArgs e)
        {
            UpdateTextColors();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
