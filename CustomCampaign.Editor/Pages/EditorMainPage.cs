#pragma warning disable SecurityIntelliSenseCS, CS0436, CS0168, CA1031, IDE0059
using CustomCampaign.Data;
using CustomCampaign.Editor.Classes;
using CustomCampaign.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class EditorMainPage : Page
    {
        public EditorMainPage()
        {
            InitializeComponent();

            GameModeId.ConversionTable.ToList().ForEach((item) => CampaignGamemode.Items.Add(item.Key));
        }

        private void CampaignInfoChanged(object sender, EventArgs e)
        {
            Overview.Title = CampaignName.Text;
            Overview.Description = CampaignDescription.Text;
        }

        #region File Menu
        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.MainWindow.GetPage<NewCampaignWizard>("pages:newcampaignwizard").PreviousPage = PageName;
                Globals.MainWindow.SetPage("pages:newcampaignwizard");
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
                Globals.OpenCampaign();
        }

        private void SaveBtn_Click(object sender, EventArgs e) => SaveCampaign();

        private void PackBtn_Click(object sender, EventArgs e) => ExportToZip();

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.MainWindow.GetPage<ImportCampaignPage>("pages:importcampaign").PreviousPage = PageName;
                Globals.ImportCampaign();
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e) => Validate_Run();

        private void FolderBtn_Click(object sender, EventArgs e) => Process.Start(Editor.current_path);

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (ClosseDialog() == DialogResult.Yes)
            {
                Globals.IsFileOpened = false;
                Globals.MainWindow.SetPage("pages:home");
            }
        }
        #endregion
        #region Levels List
        private void AddLevelBtn_Click(object sender, EventArgs e) => AddLevel_Run();

        private void AddLevel_Click(object sender, EventArgs e) => AddLevel_Run();

        private void EditLevelBtn_Click(object sender, EventArgs e) => EditLevel_Run();

        private void EditLevel_Click(object sender, EventArgs e) => EditLevel_Run();

        private void Levels_DoubleClick(object sender, EventArgs e) => EditLevel_Run();

        private void RemoveLevelBtn_Click(object sender, EventArgs e) => RemoveLevel_Run();

        private void RemoveLevel_Click(object sender, EventArgs e) => RemoveLevel_Run();

        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveLevelBtn.Enabled =
            EditLevelBtn.Enabled =
            MoveLevelUpBtn.Enabled =
            MoveLevelDownBtn.Enabled = Levels.SelectedIndex > -1;

            MoveLevelUpBtn.Enabled &= Levels.SelectedIndex > 0;
            MoveLevelDownBtn.Enabled &= Levels.SelectedIndex < Levels.Items.Count - 1;
        }

        private void MoveLevelUpBtn_Click(object sender, EventArgs e)
        {
            int current = Levels.SelectedIndex;
            int move = Math.Max(0, current - 1);
            Level level = Levels.Items[current] as Level;
            Levels.Items.Remove(level);
            Levels.Items.Insert(move, level);
            Levels.SelectedIndex = move;
        }

        private void MoveLevelDownBtn_Click(object sender, EventArgs e)
        {
            int current = Levels.SelectedIndex;
            int move = Math.Min(Levels.Items.Count - 1, current + 1);
            Level level = Levels.Items[current] as Level;
            Levels.Items.Remove(level);
            Levels.Items.Insert(move, level);
            Levels.SelectedIndex = move;
        }

        private void Levels_MouseDown(object sender, MouseEventArgs e)
        {
            int index = Levels.IndexFromPoint(e.Location);
            index = Levels.Items.Count > 0 ? Math.Max(0, Math.Min(Levels.Items.Count - 1, index)) : -1;

            Levels.SelectedIndex = index;
        }

        private void LevelsMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flag = Levels.SelectedIndex >= 0 && Levels.SelectedIndex < Levels.Items.Count;
            EditLevel.Enabled = flag;
            RemoveLevel.Enabled = flag;
        }
        #endregion
        #region Addons List
        private void AddAddonBtn_Click(object sender, EventArgs e) => AddAddon_Run();

        private void AddAddon_Click(object sender, EventArgs e) => AddAddon_Run();

        private void EditAddonBtn_Click(object sender, EventArgs e) => EditAddon_Run();

        private void EditAddon_Click(object sender, EventArgs e) => EditAddon_Run();

        private void Addons_DoubleClick(object sender, EventArgs e) => EditAddon_Run();

        private void RemoveAddonBtn_Click(object sender, EventArgs e) => RemoveAddon_Run();

        private void RemoveAddon_Click(object sender, EventArgs e) => RemoveAddon_Run();

        private void Addons_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveAddonBtn.Enabled =
            EditAddonBtn.Enabled =
            MoveAddonUpBtn.Enabled =
            MoveAddonDownBtn.Enabled = Addons.SelectedIndex > -1;

            MoveAddonUpBtn.Enabled &= Addons.SelectedIndex > 0;
            MoveAddonDownBtn.Enabled &= Addons.SelectedIndex < Addons.Items.Count - 1;
        }

        private void MoveAddonUpBtn_Click(object sender, EventArgs e)
        {
            int current = Addons.SelectedIndex;
            int move = Math.Max(0, current - 1);
            Addon addon = Addons.Items[current] as Addon;
            Addons.Items.Remove(addon);
            Addons.Items.Insert(move, addon);
            Addons.SelectedIndex = move;
        }

        private void MoveAddonDownBtn_Click(object sender, EventArgs e)
        {
            int current = Addons.SelectedIndex;
            int move = Math.Min(Addons.Items.Count - 1, current + 1);
            Addon addon = Addons.Items[current] as Addon;
            Addons.Items.Remove(addon);
            Addons.Items.Insert(move, addon);
            Addons.SelectedIndex = move;
        }

        private void Addons_MouseDown(object sender, MouseEventArgs e)
        {
            int index = Addons.IndexFromPoint(e.Location);
            index = Addons.Items.Count > 0 ? Math.Max(0, Math.Min(Addons.Items.Count - 1, index)) : -1;

            Addons.SelectedIndex = index;
        }

        private void AddonsMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flag = Addons.SelectedIndex >= 0 && Addons.SelectedIndex < Addons.Items.Count;
            EditAddon.Enabled = flag;
            RemoveAddon.Enabled = flag;
        }
        #endregion

        private void CampaignLogo_TextChanged(object sender, EventArgs e)
        {
            string file = Path.Combine(Editor.current_path, CampaignLogo.Text);
            if (File.Exists(file))
            {
                try
                {
                    Overview.Picture = Image.FromFile(file);
                }
                catch (Exception ex)
                {
                    Overview.Picture = null;
                }
            }
            else
            {
                Overview.Picture = null;
            }
            Overview.ShowPicture = Overview.Picture != null;
        }

        private void EditorTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOverviewList();
        }
    }
}
