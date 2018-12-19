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
                Description = "Welcome to spece base Frontier-1, our newest space colony. We're waiting for you!",
                Levels = new System.Collections.Generic.List<Campaign.Level>()
                {
                    new Campaign.Level("Levels/SJ_Arrival.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Levels/Loading.Arrival.png"),
                    new Campaign.Level("Levels/SJ_FarAway.bytes","[7BA7C6]Transportation Hub[-]","Terminal Alpha","Levels/Loading.FarAway.png"),
                    new Campaign.Level("Levels/SJ_NewHome.bytes","[7BA7C6]Residential District[-]","Station Omicron","Levels/Loading.NewHome.png"),
                    new Campaign.Level("Levels/SJ_Biosynthesis.bytes","[7BA7C6]Greenhouse[-]","Station Delta","Levels/Loading.Biosynthesis.png"),
                    new Campaign.Level("Levels/SJ_Oxydation.bytes","[7BA7C6]Oxygen Production[-]","Station Epsilon","Levels/Loading.Oxydation.png"),
                    new Campaign.Level("Levels/SJ_Gravity.bytes","[7BA7C6]Gravity Field Generator[-]","Station Theta","Levels/Loading.Gravity.png"),
                    new Campaign.Level("Levels/SJ_Maintenance.bytes","[992F2F]Error[-]","[C45858]Maintenance required[-]","Levels/Loading.Maintenance.png"),
                    new Campaign.Level("Levels/SJ_Threat.bytes","[992F2F]Evacuation Order[-]","[C45858]Leave the station immediately[-]","Levels/Loading.Threat.png"),
                    new Campaign.Level("Levels/SJ_Contemplation.bytes","[7BA7C6]Transportation Hub[-]","Terminal Aplha","Levels/Loading.Contemplation.png")
                }
            };

            c.Save(path);
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Open();
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

            dlg.ShowDialog();
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
    }
}
