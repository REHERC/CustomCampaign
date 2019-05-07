#pragma warning disable CS1690, CS0436, CS0436
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Campaign;

namespace CustomCampaign.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                             System.Reflection.BindingFlags.NonPublic
                             | System.Reflection.BindingFlags.Instance)
               .SetValue(LevelsBox, true, null);

            LoadCampaign(new Campaign());

            ExampleCampaign.Create02();
        }

        public void SaveAs()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "Campaign",
                Filter = "Campaign playlist|*.json",
                DefaultExt = ".json",
                Title = "Save file as",
                ValidateNames = true,
                OverwritePrompt = true,
                AddExtension = true
            };

            if (dlg.ShowDialog() == true)
            {
                Campaign c = new Campaign() {
                    name = CampaignNameBox.Text,
                    description = CampaignDescriptionBox.Text,
                    logopath = CampaignLogoBox.Text,
                    authors = AuthorsBox.Text,
                    lockmode = (UnlockStyle)UnlockStyleBox.SelectedIndex
                };

                c.levels = new List<Campaign.Level>();
                foreach (ListViewItem item in LevelsBox.Items)
                    c.levels.Add(new Campaign.Level(
                            item.SubItems[0].Text,
                            item.SubItems[1].Text,
                            item.SubItems[2].Text,
                            item.SubItems[3].Text,
                            item.SubItems[4].Text
                        ));

                c.addons = new List<string>();
                foreach (ListViewItem item in AddonsBox.Items)
                    c.addons.Add(item.SubItems[0].Text);

                c.gamemode = GameMode.GetMode(GameModeBox.SelectedIndex);

                c.Save(dlg.FileName);
            }
        }

        public void Open()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "Campaign",
                Filter = "Campaign playlist|*.json|Campaign playlist (old format)|*.pak",
                DefaultExt = ".json",
                Title = "Open file",
                ValidateNames = true,
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (dlg.ShowDialog() == true)
            {
                Campaign c = Campaign.FromFile(dlg.FileName);
                LoadCampaign(c);
            }
        }

        public void LoadCampaign(Campaign c)
        {
            CampaignNameBox.Text = c.name;
            CampaignDescriptionBox.Text = c.description;
            CampaignLogoBox.Text = c.logopath;
            AuthorsBox.Text = c.authors;
            UnlockStyleBox.SelectedIndex = (int)c.lockmode;
            LevelsBox.Items.Clear();
            foreach (Campaign.Level level in c.levels)
                LevelsBox.Items.Add(new ListViewItem(new string[] {
                    level.file,
                    level.levelname,
                    level.levelname_sub,
                    level.loading_wallpaper,
                    level.loading_text
                }));

            AddonsBox.Items.Clear();

            foreach (string addon in c.addons)
                AddonsBox.Items.Add(new ListViewItem(new string[] {
                        addon
                    }));

            GameModeBox.SelectedIndex = GameMode.GetIndex(c.gamemode);
        }

        private ListViewItem LevelsBoxItem = null;

        private void LevelsBox_MouseDown(object sender, MouseEventArgs e)
        {
            LevelsBoxItem = LevelsBox.GetItemAt(0,e.Y);
        }

        private void LevelsBox_MouseUp(object sender, MouseEventArgs e)
        {
            LevelsBox.LineAfter =
            LevelsBox.LineBefore = -1;
            if (LevelsBoxItem == null)
                return;
            ListViewItem ItemOver = LevelsBox.GetItemAt(0, e.Y);
            if (ItemOver != null)
            {
                Rectangle ItemOverRec = ItemOver.GetBounds(ItemBoundsPortion.Entire);
                bool InsertBefore = (e.Y < ItemOverRec.Top + (ItemOverRec.Height / 2));
                if (ItemOver != LevelsBoxItem)
                {
                    LevelsBox.Items.Remove(LevelsBoxItem);
                    LevelsBox.Items.Insert(ItemOver.Index + (!InsertBefore ? 1 : 0), LevelsBoxItem);
                }
            }
            else
            {
                LevelsBox.Items.Remove(LevelsBoxItem);
                LevelsBox.Items.Insert(LevelsBox.Items.Count, LevelsBoxItem);
            }
            LevelsBoxItem = null;
            LevelsBox.Invalidate();
        }

        private void LevelsBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (LevelsBoxItem != null)
            {
                ListViewItem ItemOver = LevelsBox.GetItemAt(0, e.Y);

                if (ItemOver != null)
                {
                    Rectangle ItemOverRec = ItemOver.GetBounds(ItemBoundsPortion.Entire);
                    bool InsertBefore = (e.Y < ItemOverRec.Top + (ItemOverRec.Height / 2));
                    LevelsBox.LineBefore = InsertBefore ? ItemOver.Index : -1;
                    LevelsBox.LineAfter = InsertBefore ? -1 : ItemOver.Index;
                    LevelsBox.Invalidate();
                }
                else
                {
                    LevelsBox.LineBefore = -1;
                    LevelsBox.LineAfter = LevelsBox.Items.Count - 1;
                    LevelsBox.Invalidate();
                }
            }
        }

        private void EditItem(ref ListViewItem item)
        {
            LevelsBox.LineAfter = LevelsBox.LineBefore = -1;
            LevelsBox.Invalidate();
            LevelForm form = new LevelForm(item)
            {
                Text = "Custom Campaign Authoring Tool - Edit a level"
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                item.SubItems[0].Text = form.value.file;
                item.SubItems[1].Text = form.value.levelname;
                item.SubItems[2].Text = form.value.levelname_sub;
                item.SubItems[3].Text = form.value.loading_wallpaper;
                item.SubItems[4].Text = form.value.loading_text;
            }
        }

        private void AddANewLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelForm form = new LevelForm()
            {
                Text = "Custom Campaign Authoring Tool - Add a level"
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selectedItem = LevelsBox.SelectedItems.Count > 0 ? LevelsBox.SelectedItems[0] : null;
                ListViewItem item = new ListViewItem(new string[]{
                    form.value.file,
                    form.value.levelname,
                    form.value.levelname_sub,
                    form.value.loading_wallpaper,
                    form.value.loading_text
                });
                LevelsBox.Items.Insert(selectedItem != null ? selectedItem.Index + 1 : LevelsBox.Items.Count, item);
            }
        }

        private void LevelsContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool active = LevelsBox.SelectedItems.Count > 0;
            removeLevelToolStripMenuItem.Enabled = editLevelInfoToolStripMenuItem.Enabled = active;
        }

        private void RemoveLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = LevelsBox.SelectedItems[0];
            if (item != null && MessageBox.Show($"Are you sure you want to remove \"{item.Text}\" from the playlist ?", $"Remove \"{item.SubItems[1].Text}\" from the playlist", MessageBoxButtons.YesNo) == DialogResult.Yes)
                LevelsBox.Items.Remove(item);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this application ?\nAny unsaved changes will be discarded !", "Quit application ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LevelsBox_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = LevelsBox.SelectedItems.Count > 0 ? LevelsBox.SelectedItems[0] : null;

            if (selectedItem != null)
                EditItem(ref selectedItem);
        }

        private void EditLevelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = LevelsBox.SelectedItems.Count > 0 ? LevelsBox.SelectedItems[0] : null;
            if (selectedItem != null)
                EditItem(ref selectedItem);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create a new file ?\nAny unsaved changes will be discarded !", "Create new file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoadCampaign(new Campaign());
            }
        }

        private void PackBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "Campaign",
                Filter = "Campaign playlist|*.json",
                DefaultExt = ".json",
                Title = "Open file for packaging",
                ValidateNames = true,
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (dlg.ShowDialog() == true)
            {
                PackForm form = new PackForm(dlg.FileName);
                form.Show();
            }
        }

        private void AddAddon_Click(object sender, EventArgs e)
        {
            AddonForm form = new AddonForm()
            {
                Text = "Custom Campaign Authoring Tool - Add an add-on"
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selectedItem = AddonsBox.SelectedItems.Count > 0 ? AddonsBox.SelectedItems[0] : null;

                ListViewItem item = new ListViewItem(new string[]{
                    form.value
                });
                AddonsBox.Items.Insert(selectedItem != null ? selectedItem.Index + 1 : AddonsBox.Items.Count, item);
            }
        }

        private void AddonContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool active = AddonsBox.SelectedItems.Count > 0;
            RemoveAddon.Enabled = EditAddon.Enabled = active;
        }

        private void EditAddon_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = AddonsBox.SelectedItems.Count > 0 ? AddonsBox.SelectedItems[0] : null;

            if (selectedItem != null)
                EditAddonItem(ref selectedItem);
        }

        private void EditAddonItem(ref ListViewItem item)
        {
            AddonsBox.LineAfter = AddonsBox.LineBefore = -1;
            AddonsBox.Invalidate();

            AddonForm form = new AddonForm(item)
            {
                Text = "Custom Campaign Authoring Tool - Edit an add-on"
            };

            if (form.ShowDialog() == DialogResult.OK)
                item.SubItems[0].Text = form.value;
        }

        private void RemoveAddon_Click(object sender, EventArgs e)
        {
            ListViewItem item = AddonsBox.SelectedItems[0];

            if (item != null && MessageBox.Show($"Are you sure you want to remove \"{item.Text}\" from the add-ons ?", $"Remove \"{item.SubItems[0].Text}\" from the add-ons", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AddonsBox.Items.Remove(item);
            }
        }

        private void AddonsBox_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = AddonsBox.SelectedItems.Count > 0 ? AddonsBox.SelectedItems[0] : null;

            if (selectedItem != null)
                EditAddonItem(ref selectedItem);
        }
    }
}
