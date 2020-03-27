using CustomCampaign.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class ExportProgressDialog : MaterialSkin.Controls.MaterialForm
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams base_params = base.CreateParams;
                base_params.ClassStyle |= NativeMethods.CP_NOCLOSE_BUTTON;
                return base_params;
            }
        }

        private Action<SaveFileDialog, Campaign, ExportProgressDialog> Routine;
        private SaveFileDialog Dialog;
        private Campaign Campaign;

        public ExportProgressDialog()
        {
            InitializeComponent();
        }

        public void ShowAndRunRoutine(SaveFileDialog dlg, Campaign campaign, Action<SaveFileDialog, Campaign, ExportProgressDialog> routine)
        {
            Routine = routine;
            Dialog = dlg;
            Campaign = campaign;
            ShowDialog();
        }

        public void SetMaxProgress(int value)
        {
            Progress.Maximum = value;
            Refresh();
        }

        public void SetProgress(int value)
        {
            Progress.Value = value;
        }

        public void SetStatus(string text)
        {
            Status.Text = text;
        }

        public void IncrementProgress()
        {
            Progress.Value = Math.Min(Progress.Value + 1, Progress.Maximum);
        }

        private void ExportProgressDialog_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => Routine(Dialog, Campaign, this))
                        .ContinueWith((Task _) => Close());
        }
    }
}
