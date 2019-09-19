using CustomCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class EditLevelPage : Classes.Page
    {
        private bool editing = false;

        public EditLevelPage()
        {
            InitializeComponent();
        }

        public void Setup(Level level, string title, bool editflag = false)
        {
            editing = editflag;

            data = level;
            PageTitle = title;

            LevelFile.Text = data.file;
            DisplayIntro.Checked = data.display_intro_title;
            LevelName.Text = data.levelname;
            LevelSector.Text = data.levelname_sub;
            LoadingBackground.SelectedText = data.loading_wallpaper;
            OverwriteLoadingText.Checked = data.overwrite_loading_text;
            LoadingText.Text = data.loading_text;
            HideInSprint.Checked = data.hide_in_sprint;
        }

        private Level data = new Level();

        public Action<DialogResult, Level> PageClosed = (result, level) => { };

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Campaign campaign = Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").UpdateWorkingstate();
            List<string> levels = campaign.levels.Select((level) => level.file.ToLower()).ToList();
            if (ValidateFields())
            {
                if (levels.Contains(data.file.ToLower()) && !editing)
                {
                    MessageBox.Show($"The level \"{data.file}\" is already in this campaign level set.\nA campaign can't have duplicate levels.");
                }
                else
                {
                    PageClosed(DialogResult.OK, data);
                }
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e) => PageClosed(DialogResult.Cancel, data);
        private void LevelFile_TextChanged(object sender, EventArgs e) => data.file = LevelFile.Text;
        private void DisplayIntro_CheckedChanged(object sender, EventArgs e) => data.display_intro_title = DisplayIntro.Checked;
        private void LevelName_TextChanged(object sender, EventArgs e) => data.levelname = LevelName.Text;
        private void LevelSector_TextChanged(object sender, EventArgs e) => data.levelname_sub = LevelSector.Text;
        private void LoadingBackground_TextChanged(object sender, EventArgs e) => data.loading_wallpaper = LoadingBackground.Text;
        private void OverwriteLoadingText_CheckedChanged(object sender, EventArgs e) => data.overwrite_loading_text = OverwriteLoadingText.Checked;
        private void LoadingText_TextChanged(object sender, EventArgs e) => data.loading_text = LoadingText.Text;
        private void HideInSprint_CheckedChanged(object sender, EventArgs e) => data.hide_in_sprint = HideInSprint.Checked;
        private bool ValidateFields()
        {
            bool result = true;

            result &= LevelFile.Text.Length > 0;

            return result;
        }
    }
}
