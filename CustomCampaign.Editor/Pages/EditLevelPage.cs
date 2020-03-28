#pragma warning disable SecurityIntelliSenseCS, RCS1163
using CustomCampaign.Editor.Forms;
using CustomCampaign.Editor.Forms.Dialogs;
using CustomCampaign.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class EditLevelPage : Classes.Page
    {
        private bool editing;
        private string filename;

        public EditLevelPage()
        {
            InitializeComponent();
        }

        public void Setup(Level level, string title, bool editflag = false)
        {
            editing = editflag;

            //data = level;
            data = new Level();

            PageTitle = title;

            filename = FileFullPath(level.file);

            data.file = level.file;
            data.display_intro_title = level.display_intro_title;
            data.levelname = level.levelname;
            data.levelname_sub = level.levelname_sub;
            data.loading_wallpaper = level.loading_wallpaper;
            data.overwrite_loading_text = level.overwrite_loading_text;
            data.loading_text = level.loading_text;
            data.hide_in_sprint = level.hide_in_sprint;
            data.countdown = level.countdown;

            LevelFile.Text = data.file;
            DisplayIntro.Checked = data.display_intro_title;
            LevelName.Text = data.levelname;
            LevelSector.Text = data.levelname_sub;
            LoadingBackground.Text = data.loading_wallpaper;
            OverwriteLoadingText.Checked = data.overwrite_loading_text;
            LoadingText.Text = data.loading_text;
            HideInSprint.Checked = data.hide_in_sprint;
            HideInSprint.Visible = Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").SprintPlaylist.Checked;

            SetTimerDisplay();
        }

        private Level data = new Level();

        public Action<DialogResult, Level> PageClosed = (result, data) => { };

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Campaign campaign = Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain").UpdateWorkingstate();
            List<string> levels = campaign.levels.Select((level) => level.file.ToLower()).ToList();
            if (ValidateFields())
            {
                if (levels.Contains(data.file.ToLower()) && !editing)
                {
                    MessageDialog.Show($"The level \"{data.file}\" is already in this campaign level set.\nA campaign can't have duplicate levels.");
                }
                else
                {
                    PageClosed(DialogResult.OK, data);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) => PageClosed(DialogResult.Cancel, data);

        private void LevelFile_TextChanged(object sender, EventArgs e) => data.file = LevelFile.Text;

        private void DisplayIntro_CheckedChanged(object sender, EventArgs e)
        {
            LevelName.Visible = DisplayIntro.Checked;
            LevelSector.Visible = DisplayIntro.Checked;
            data.display_intro_title = DisplayIntro.Checked;
        }

        private void LevelName_TextChanged(object sender, EventArgs e) => data.levelname = LevelName.Text;

        private void LevelSector_TextChanged(object sender, EventArgs e) => data.levelname_sub = LevelSector.Text;

        private void LoadingBackground_TextChanged(object sender, EventArgs e) => data.loading_wallpaper = LoadingBackground.Text;

        private void OverwriteLoadingText_CheckedChanged(object sender, EventArgs e)
        {
            LoadingText.Visible = OverwriteLoadingText.Checked;
            data.overwrite_loading_text = OverwriteLoadingText.Checked;
        }

        private void LoadingText_TextChanged(object sender, EventArgs e) => data.loading_text = LoadingText.Text;

        private void HideInSprint_CheckedChanged(object sender, EventArgs e) => data.hide_in_sprint = HideInSprint.Checked;

        private bool ValidateFields()
        {
            bool valid = true;

            valid &= LevelFile.Text.Length > 0;

            if (!valid)
            {
                MessageDialog.Show("You must provide a file name to continue.", "Error", MessageBoxButtons.OK);
                return false;
            }

            valid &= (editing && string.Equals(filename, FileFullPath(LevelFile.Text), StringComparison.InvariantCultureIgnoreCase)) || CheckFileDuplicates() == 0;

            if (!valid)
            {
                MessageDialog.Show("You can't add the same level file twice in a campaign.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return valid;
        }

        private int CheckFileDuplicates()
        {
            string current = FileFullPath(LevelFile.Text);
            Dictionary<string, int> occurences = new Dictionary<string, int>()
            {
                {current,0}
            };
            foreach (Level level in Editor.current_campaign.levels)
            {
                string item = FileFullPath(level.file);

                if (!occurences.ContainsKey(item))
                {
                    occurences.Add(item, 0);
                }
                occurences[item]++;
            }
            return occurences[current];
        }

        private string FileFullPath(string file)
        {
            return Path.GetFullPath(Path.Combine(Editor.current_path, file.Replace('\\', '/'))).ToLower();
        }

        private void LocateLevel_Click(object sender, EventArgs e)
        {
            using (LevelBrowserDialog dlg = new LevelBrowserDialog(LevelFile.Text))
            {
                if (dlg.ShowDialog() is DialogResult.OK)
                {
                    LevelFile.Text = dlg.filename;
                }
            }
        }

        private void SetTimerDisplay()
        {
            TimerValue.Text = data.countdown == 0.0d ? "Standard sprint stopwatch" : TimeSpan.FromSeconds(data.countdown).GetDisplayTime();
        }

        private void TimerBtn_Click(object sender, EventArgs e)
        {
            using (CountdownSelector dlg = new CountdownSelector())
            {
                dlg.SetValue(data.countdown);
                if (dlg.ShowDialog() is DialogResult.OK)
                {
                    data.countdown = dlg.GetValue();
                    SetTimerDisplay();
                }
            }
        }
    }
}
