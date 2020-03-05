using CustomCampaign.Editor.Forms;
using Harmony;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace CustomCampaign.Editor
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("com.reherc.customcampaign.editor");
            harmony.PatchAll(typeof(Program).Assembly);

            Control.CheckForIllegalCrossThreadCalls = false;

            Config.AppSettings.Load();

            Globals.SkinManager.Theme = Config.AppSettings.Data.darkmode ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

            if (Themes.Values.TryGetValue(Config.AppSettings.Data.theme, out ColorScheme theme))
            {
                Globals.SkinManager.ColorScheme = theme;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(Globals.MainWindow = new MainForm());
        }
    }
}
