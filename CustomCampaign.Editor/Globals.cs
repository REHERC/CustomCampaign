using CustomCampaign.Editor.Forms;
using CustomCampaign.Editor.Pages;
using MaterialSkin;
using System;
using System.IO;
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
                    OpenCampaign(dlg.FileName);
            }
        }

        public static void OpenCampaign(string file)
        {
            if (!File.Exists(file)) return;
            IsFileOpened = true;
            MainWindow.GetPage<EditorMainPage>("pages:editormain").GoToFileTab();
            MainWindow.GetPage<EditorMainPage>("pages:editormain").LoadCampaign(file);
            MainWindow.SetPage("pages:editormain");
        }

        public static bool ImportLevel(string file, out string error)
        {
            error = "";
            if (!IsFileOpened)
            {
                error = "No project opened";
                return false;
            }

            if (!file.ToLower().EndsWith(".bytes"))
            {
                error = "The selected file isn't a .bytes file.";
                return false;
            }

            FileInfo import_bytes = new FileInfo(file);
            FileInfo import_thumbnail = new FileInfo($"{file}.png");

            if (!import_bytes.Exists)
            {
                error = "The selected file couldn't be found.";
                return false;
            }

            if (!import_thumbnail.Exists)
            {
                error = "The selected file didn't have a thumbnail.";
                return false;
            }

            var file_name = Guid.NewGuid().ToString("N");

            var import_dir = new DirectoryInfo(Path.Combine(Editor.current_path, "levels/imported/"));
            if (!import_dir.Exists)
                import_dir.Create();

            var import_path = Path.Combine(import_dir.FullName, $"{file_name}.bytes");

            File.Copy(import_bytes.FullName, import_path);
            File.Copy(import_thumbnail.FullName, $"{import_path}.png");

            return true;
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
