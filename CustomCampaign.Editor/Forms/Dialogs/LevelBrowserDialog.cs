using System;
using System.IO;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms.Dialogs
{
    public partial class LevelBrowserDialog : MaterialSkin.Controls.MaterialForm
    {
        public string filename = string.Empty;

        public LevelBrowserDialog(string file)
        {
            InitializeComponent();
            filename = file;
            ProjectBrowser.RefreshList();
            ProjectBrowser.SetSelection(filename);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var mylevels = new DirectoryInfo($"{documents}/My Games/Distance/Levels/MyLevels");

            string initial_directory = mylevels.Exists ? mylevels.FullName : documents;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = initial_directory;
                dlg.Filter = Constants.LevelDialogFilter;
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!Globals.ImportLevel(dlg.FileName, out string error))
                    {
                        MessageDialog.Show(error, "Error");
                    }
                    ProjectBrowser.RefreshList();
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ProjectBrowser.RefreshList();
        }

        private void LevelBrowserDialog_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageDialog.Show(ProjectBrowser.GetSelection());
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProjectBrowser.GetSelection()))
            {
                MessageDialog.Show("You must select a level to continue.", "Error", MessageBoxButtons.OK);
                return;
            }

            filename = ProjectBrowser.GetSelection();

            Close(DialogResult.OK);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close(DialogResult.Cancel);
        }
    }
}
