using CustomCampaign.Editor.Forms;
using CustomCampaign.Editor.Pages;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace CustomCampaign.Editor
{
    public static class Globals
    {
        public static readonly MaterialSkinManager SkinManager = MaterialSkinManager.Instance;
        public static MainForm MainWindow;

        public static bool IsFileOpened = false;

        public static void OpenCampaign()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                dlg.Filter = Constants.CampaignDialogFilter;
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    IsFileOpened = true;
                    MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
                    MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(dlg.FileName);
                    MainWindow.SetPage("pages:editormain");
                }
            }
        }

        public static void ImportCampaign()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                dlg.Filter = Constants.ExportDialogFilter;
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MainWindow.GetPage<ImportCampaignPage>("pages:importcampaign").ImportFile(dlg.FileName);
                    //MainWindow.GetPage<EditorMainPage>("pages:importcampaign").LoadCampaign(dlg.FileName);
                    MainWindow.SetPage("pages:importcampaign");
                }
            }
        }
    }
}
