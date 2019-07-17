using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace CustomCampaign.Editor.Forms
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        ~SettingsForm()
        {
            Globals.SkinManager.RemoveFormToManage(this);
            
        }

        private void DarkMode_CheckedChanged(object sender, System.EventArgs e)
        {
            Config.AppSettings.Data.darkmode = DarkMode.Checked;
            Config.AppSettings.Save();
            SkinManager.Theme = DarkMode.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
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

        private void SettingsForm_Load(object sender, System.EventArgs e)
        {
            Globals.SkinManager.AddFormToManage(this);

            DarkMode.Checked = Config.AppSettings.Data.darkmode;

            int themeindex = 0, i = 0;
            foreach (var theme in Themes.Values)
            {
                ThemeList.Items.Add(theme.Key);
                if (theme.Key == Config.AppSettings.Data.theme)
                    themeindex = i;
                i++;
            }
            ThemeList.SelectedIndex = themeindex;
        }
    }
}
