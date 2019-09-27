using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms.Dialogs
{
    public partial class InputDialog : MaterialSkin.Controls.MaterialForm
    {
        [DllImport("user32")]
        static new extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;

        public InputDialog()
        {
            InitializeComponent();
            EnableMenuItem(GetSystemMenu(Handle, false), SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);

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
