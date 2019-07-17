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
                dlg.Filter = Constants.DialogFilter;
                dlg.FilterIndex = 0;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Globals.IsFileOpened = true;
                    Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
                    Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(dlg.FileName);
                    Globals.MainWindow.SetPage("pages:editormain");
                }
            }
        }
    }
}
