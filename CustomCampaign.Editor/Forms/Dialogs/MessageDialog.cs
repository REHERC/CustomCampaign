using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class MessageDialog : MaterialSkin.Controls.MaterialForm
    {
        [DllImport("user32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        public const int MF_BYCOMMAND = 0;
        public const int MF_DISABLED = 2;
        public const int SC_CLOSE = 0xF060;

        private string message_content = "";

        public string Message
        {
            get => message_content;
            set
            {
                message_content = value;
                render_bounds = new Rectangle(0, 0, MainPanel.MaximumSize.Width, MainPanel.MaximumSize.Height);
                Size size = TextRenderer.MeasureText(message_content, Font, render_bounds.Size, flags);
                MainPanel.MinimumSize = size;
                text_bounds = new Rectangle(0, 0, size.Width, size.Height);
                MainPanel.Invalidate();
            }
        }

        public MessageDialog()
        {
            InitializeComponent();
            EnableMenuItem(GetSystemMenu(Handle, false), SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
        }

        public void Setup(MessageBoxButtons buttons)
        {
            foreach (Control control in BottomActions.Controls)
                control.Visible = false;
            switch(buttons)
            {
                case MessageBoxButtons.OK:
                    OkBox.Visible = true;
                    break;
                case MessageBoxButtons.YesNo:
                    YesBox.Visible = true;
                    NoBox.Visible = true;
                    break;
                case MessageBoxButtons.OKCancel:
                    OkBox.Visible = true;
                    CancelBox.Visible = true;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    YesBox.Visible = true;
                    NoBox.Visible = true;
                    CancelBox.Visible = true;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    AbortBox.Visible = true;
                    RetryBox.Visible = true;
                    IgnoreBox.Visible = true;
                    break;
                case MessageBoxButtons.RetryCancel:
                    CancelBox.Visible = true;
                    RetryBox.Visible = true;
                    break;
            }
        }

        public static DialogResult Show(string message, string title = "\0", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            using (MessageDialog dlg = new MessageDialog())
            {
                dlg.Title = title;
                dlg.Setup(buttons);
                dlg.Message = message;
                dlg.ShowDialog();
                return dlg.DialogResult;
            }
        }

        public override Font Font => SkinManager.GetFont(11);
        private Rectangle render_bounds;
        private Rectangle text_bounds;

        private readonly TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl;

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            TextRenderer.DrawText(g, Message, Font, text_bounds, SkinManager.GetPrimaryTextColor(), flags);
        }

        private void MessageDialog_Shown(object sender, System.EventArgs e)
        {
            MainPanel.Invalidate();
        }
    }
}
