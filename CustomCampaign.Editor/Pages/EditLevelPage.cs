﻿using CustomCampaign.Models;
using System;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class EditLevelPage : Classes.Page
    {
        public EditLevelPage()
        {
            InitializeComponent();
        }

        public void Setup(Level level, string title)
        {
            data = level;
            PageTitle = title;

            LevelFile.Text = data.file;
            DisplayIntro.Checked = data.display_intro_title;
            LevelName.Text = data.levelname;
            LevelSector.Text = data.levelname_sub;
            LoadingBackground.SelectedText = data.loading_wallpaper;
            OverwriteLoadingText.Checked = data.overwrite_loading_text;
            LoadingText.Text = data.loading_text;
        }

        private Level data = new Level();

        public Action<DialogResult, Level> PageClosed = (result, level) => { };

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
                PageClosed(DialogResult.OK, data);
        }
        private void CancelBtn_Click(object sender, EventArgs e) => PageClosed(DialogResult.Cancel, data);
        private void LevelFile_TextChanged(object sender, EventArgs e) => data.file = LevelFile.Text;
        private void DisplayIntro_CheckedChanged(object sender, EventArgs e) => data.display_intro_title = DisplayIntro.Checked;
        private void LevelName_TextChanged(object sender, EventArgs e) => data.levelname = LevelName.Text;
        private void LevelSector_TextChanged(object sender, EventArgs e) => data.levelname_sub = LevelSector.Text;
        private void LoadingBackground_TextChanged(object sender, EventArgs e) => data.loading_wallpaper = LoadingBackground.Text;
        private void OverwriteLoadingText_CheckedChanged(object sender, EventArgs e) => data.overwrite_loading_text = OverwriteLoadingText.Checked;
        private void LoadingText_TextChanged(object sender, EventArgs e) => data.loading_text = LoadingText.Text;
        private bool ValidateFields()
        {
            bool result = true;

            result &= LevelFile.Text.Length > 0;

            return result;
        }
    }
}
