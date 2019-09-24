using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows;

namespace CustomCampaign.Editor.Forms
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            Globals.SkinManager.AddFormToManage(this);
        }

        ~SettingsForm()
        {
            Globals.SkinManager.RemoveFormToManage(this);
        }

        private void DarkMode_CheckedChanged(object sender, System.EventArgs e)
        {
            Config.AppSettings.Data.darkmode = DarkMode.Checked;
            Config.AppSettings.Save();
            SkinManager.Theme = DarkMode.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
        }

        private void ThemeList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string theme = ThemeList.Items[ThemeList.SelectedIndex].ToString();
            Config.AppSettings.Data.theme = theme;
            Config.AppSettings.Save();

            if (Themes.Values.TryGetValue(theme, out ColorScheme scheme))
                Globals.SkinManager.ColorScheme = scheme;
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            Globals.MainWindow.Refresh();
            Close();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            DarkMode.Checked = Config.AppSettings.Data.darkmode;
            
            int themeindex = 0, i = 0;
            foreach (var theme in Themes.Values)
            {
                ThemeList.Items.AddRange(new object[] {theme.Key});
                if (theme.Key.ToLower() == Config.AppSettings.Data.theme.ToLower())
                    themeindex = i;
                i++;
            }
            try
            {
                ThemeList.SelectedIndex = themeindex;
            }
            catch (Exception)
            { }
        }
    }
}
