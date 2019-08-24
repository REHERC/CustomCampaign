using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms.Dialogs
{
    public partial class InputDialog : MaterialSkin.Controls.MaterialForm
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string Show(string title, string hint = "", string default_value = "")
        {
            string result = string.Empty;

            using (InputDialog dlg = new InputDialog())
            {
                dlg.Title = title;
                dlg.InputBox.Hint = hint;
                dlg.InputBox.Text = default_value;

                if (dlg.ShowDialog() == DialogResult.OK)
                    result = dlg.InputBox.Text;
            }

            return result;
        }
    }
}
