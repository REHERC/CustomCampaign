using System;
using System.Drawing;
using System.Windows.Forms;

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
                             System.Reflection.BindingFlags.NonPublic |
                             System.Reflection.BindingFlags.Instance)
               .SetValue(LevelsBox, true, null);

            string path = $@"{Application.StartupPath}\Campaign.pak";

            Campaign c;

            c = new Campaign()
            {
                Name = "Space base Frontier-1",
                Description = "Welcome to space base Frontier-1, our newest space colony. We're waiting for you!",
                LogoPath = "Images/Campaign.png",
                Levels = new System.Collections.Generic.List<Campaign.Level>()
                {
                    new Campaign.Level("Levels/SJ_Arrival.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Images/Loading.Arrival.png"),
                    new Campaign.Level("Levels/SJ_FarAway.bytes","[7BA7C6]Transportation Hub[-]","Terminal Alpha","Images/Loading.FarAway.png"),
                    new Campaign.Level("Levels/SJ_NewHome.bytes","[7BA7C6]Residential District[-]","Station Omicron","Images/Loading.NewHome.png"),
                    new Campaign.Level("Levels/SJ_Biosynthesis.bytes","[7BA7C6]Greenhouse[-]","Station Delta","Images/Loading.Biosynthesis.png"),
                    new Campaign.Level("Levels/SJ_Oxydation.bytes","[7BA7C6]Oxygen Production[-]","Station Epsilon","Images/Loading.Oxydation.png"),
                    new Campaign.Level("Levels/SJ_Gravity.bytes","[7BA7C6]Gravity Field Generator[-]","Station Theta","Images/Loading.Gravity.png"),
                    new Campaign.Level("Levels/SJ_Maintenance.bytes","[992F2F]Error[-]","[C45858]Maintenance required[-]","Images/Loading.Maintenance.png"),
                    new Campaign.Level("Levels/SJ_Threat.bytes","[992F2F]Evacuation Order[-]","[C45858]Leave the station immediately[-]","Images/Loading.Threat.png"),
                    new Campaign.Level("Levels/SJ_Contemplation.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Images/Loading.Contemplation.png")
                }
            };

            c.Save(path);
        }

        void SaveAs()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "Campaign.pak",
                Filter = "Packaged campaign playlist (.pak)|*.pak",
                DefaultExt = ".pak",
                Title = "Save file as",
                ValidateNames = true,
                OverwritePrompt = true,
                AddExtension = true
            };

            dlg.ShowDialog();
        }

        void Open()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "Campaign.pak",
                Filter = "Packaged campaign playlist (.pak)|*.pak",
                DefaultExt = ".pak",
                Title = "Open file",
                ValidateNames = true,
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (dlg.ShowDialog() == true)
            {
                Campaign c = new Campaign();
                c.Load(dlg.FileName);

                LoadCampaign(c);
            }
        }

        void LoadCampaign(Campaign c)
        {
            CampaignNameBox.Text = c.Name;
            CampaignDescriptionBox.Text = c.Description;
            CampaignLogoBox.Text = c.LogoPath;

            LevelsBox.Items.Clear();

            foreach (Campaign.Level level in c.Levels)
            {
                LevelsBox.Items.Add(new ListViewItem(new string[] {
                        level.file,
                        level.levelname,
                        level.levelname_sub,
                        level.loading_wallpaper
                    }));
            }
        }

        private ListViewItem LevelsBoxItem = null;

        private void LevelsBox_MouseDown(object sender, MouseEventArgs e)
        {
            LevelsBoxItem = LevelsBox.GetItemAt(0,e.Y);

            if (LevelsBoxItem != null)
            {
                //LevelsBox.DoDragDrop(LevelsBoxItem, DragDropEffects.Move);
            }
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
            
            //Cursor.Current = Cursors.Default;

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
            MessageBox.Show(item.Text);
        }

        private void AddANewLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLevelForm form = new AddLevelForm();

            form.ShowDialog();

            ListViewItem selectedItem = LevelsBox.SelectedItems.Count > 0 ? LevelsBox.SelectedItems[0] : null;

            ListViewItem item = new ListViewItem(new string[]{
                form.value.file,
                form.value.levelname,
                form.value.levelname_sub,
                form.value.loading_wallpaper
            });

            LevelsBox.Items.Insert(selectedItem != null ? selectedItem.Index + 1 : LevelsBox.Items.Count, item);
        }

        private void LevelsContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool active = LevelsBox.SelectedItems.Count > 0;

            removeLevelToolStripMenuItem.Enabled = active;
            editLevelInfoToolStripMenuItem.Enabled = active;
        }

        private void RemoveLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = LevelsBox.SelectedItems[0];


            if (item != null && MessageBox.Show($"Are you sure you want to remove \"{item.Text}\" from the playlist ?", $"Remove \"{item.SubItems[1].Text}\" from the playlist", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LevelsBox.Items.Remove(item);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this application?\nAny unsaved changes will be discarded!", "Quit application?", MessageBoxButtons.YesNo) == DialogResult.No)
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
            if (MessageBox.Show("Are you sure you want to create a new file?\nAny unsaved changes will be discarded!", "Create new file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoadCampaign(new Campaign());
            }
        }
    }
}
