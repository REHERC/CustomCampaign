namespace CustomCampaign.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Levels/Factory Reset.bytes",
            "Factory Reset",
            "Ferne Corporation",
            "Levels/Loading.Factory Reset.png"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Levels/Level 02.bytes",
            "Level 02",
            "600 B.C.",
            "Levels/Loading.Level 02.png"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Levels/Level 03.bytes",
            "Level 03",
            "400 B.C",
            "Levels/Loading.Level 03.png"}, -1);
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CampaignDescriptionContainer = new System.Windows.Forms.Panel();
            this.CampaignDescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampaignNameLbl = new System.Windows.Forms.Label();
            this.CampaignNameBox = new System.Windows.Forms.TextBox();
            this.LevelsTab = new System.Windows.Forms.TabPage();
            this.LevelsBox = new ReorderableListView();
            this.LevelFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelSubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadingWallpaper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addANewLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLevelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsMenuBar = new System.Windows.Forms.ToolStrip();
            this.Status = new System.Windows.Forms.ToolStripLabel();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.MenuBar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.EditorTabs.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.CampaignDescriptionContainer.SuspendLayout();
            this.LevelsTab.SuspendLayout();
            this.LevelsContextMenu.SuspendLayout();
            this.levelsMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.toolStripSeparator2,
            this.OpenBtn,
            this.toolStripSeparator3,
            this.SaveAsBtn,
            this.toolStripSeparator1});
            this.MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(784, 38);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "Menu";
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewBtn.Image = global::CustomCampaign.Properties.Resources.Text_001;
            this.NewBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewBtn.Size = new System.Drawing.Size(35, 35);
            this.NewBtn.Text = "&New";
            this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenBtn.Image = global::CustomCampaign.Properties.Resources.Open_005;
            this.OpenBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OpenBtn.Size = new System.Drawing.Size(40, 35);
            this.OpenBtn.Text = "&Open";
            this.OpenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsBtn.Image")));
            this.SaveAsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAsBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveAsBtn.Size = new System.Drawing.Size(35, 35);
            this.SaveAsBtn.Text = "Save";
            this.SaveAsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveAsBtn.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EditorTabs);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 38);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 324);
            this.MainPanel.TabIndex = 1;
            // 
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.SettingsTab);
            this.EditorTabs.Controls.Add(this.LevelsTab);
            this.EditorTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTabs.ImageList = this.Icons;
            this.EditorTabs.Location = new System.Drawing.Point(0, 0);
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(784, 324);
            this.EditorTabs.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.AutoScroll = true;
            this.SettingsTab.Controls.Add(this.SettingsPanel);
            this.SettingsTab.ImageIndex = 7;
            this.SettingsTab.Location = new System.Drawing.Point(4, 23);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(776, 297);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Campaign settings";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.ColumnCount = 2;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Controls.Add(this.CampaignDescriptionContainer, 1, 1);
            this.SettingsPanel.Controls.Add(this.label1, 0, 1);
            this.SettingsPanel.Controls.Add(this.CampaignNameLbl, 0, 0);
            this.SettingsPanel.Controls.Add(this.CampaignNameBox, 1, 0);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 2;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Size = new System.Drawing.Size(770, 291);
            this.SettingsPanel.TabIndex = 0;
            // 
            // CampaignDescriptionContainer
            // 
            this.CampaignDescriptionContainer.AutoSize = true;
            this.CampaignDescriptionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CampaignDescriptionContainer.Controls.Add(this.CampaignDescriptionBox);
            this.CampaignDescriptionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionContainer.Location = new System.Drawing.Point(116, 20);
            this.CampaignDescriptionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionContainer.MaximumSize = new System.Drawing.Size(0, 25);
            this.CampaignDescriptionContainer.MinimumSize = new System.Drawing.Size(0, 25);
            this.CampaignDescriptionContainer.Name = "CampaignDescriptionContainer";
            this.CampaignDescriptionContainer.Size = new System.Drawing.Size(654, 25);
            this.CampaignDescriptionContainer.TabIndex = 2;
            // 
            // CampaignDescriptionBox
            // 
            this.CampaignDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionBox.Location = new System.Drawing.Point(0, 0);
            this.CampaignDescriptionBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionBox.Name = "CampaignDescriptionBox";
            this.CampaignDescriptionBox.Size = new System.Drawing.Size(654, 20);
            this.CampaignDescriptionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 271);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign description :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameLbl
            // 
            this.CampaignNameLbl.AutoSize = true;
            this.CampaignNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameLbl.Location = new System.Drawing.Point(0, 0);
            this.CampaignNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameLbl.Name = "CampaignNameLbl";
            this.CampaignNameLbl.Size = new System.Drawing.Size(116, 20);
            this.CampaignNameLbl.TabIndex = 0;
            this.CampaignNameLbl.Text = "Campaign name :";
            this.CampaignNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameBox
            // 
            this.CampaignNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameBox.Location = new System.Drawing.Point(116, 0);
            this.CampaignNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameBox.Name = "CampaignNameBox";
            this.CampaignNameBox.Size = new System.Drawing.Size(654, 20);
            this.CampaignNameBox.TabIndex = 1;
            // 
            // LevelsTab
            // 
            this.LevelsTab.BackColor = System.Drawing.SystemColors.Control;
            this.LevelsTab.Controls.Add(this.LevelsBox);
            this.LevelsTab.Controls.Add(this.levelsMenuBar);
            this.LevelsTab.ImageIndex = 3;
            this.LevelsTab.Location = new System.Drawing.Point(4, 23);
            this.LevelsTab.Name = "LevelsTab";
            this.LevelsTab.Size = new System.Drawing.Size(776, 297);
            this.LevelsTab.TabIndex = 1;
            this.LevelsTab.Text = "Levels";
            // 
            // LevelsBox
            // 
            this.LevelsBox.AllowDrop = true;
            this.LevelsBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LevelFile,
            this.LevelName,
            this.LevelSubName,
            this.LoadingWallpaper});
            this.LevelsBox.ContextMenuStrip = this.LevelsContextMenu;
            this.LevelsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsBox.FullRowSelect = true;
            this.LevelsBox.GridLines = true;
            this.LevelsBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LevelsBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.LevelsBox.LineAfter = -1;
            this.LevelsBox.LineBefore = -1;
            this.LevelsBox.Location = new System.Drawing.Point(0, 0);
            this.LevelsBox.MultiSelect = false;
            this.LevelsBox.Name = "LevelsBox";
            this.LevelsBox.Size = new System.Drawing.Size(776, 272);
            this.LevelsBox.TabIndex = 0;
            this.LevelsBox.UseCompatibleStateImageBehavior = false;
            this.LevelsBox.View = System.Windows.Forms.View.Details;
            this.LevelsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseDown);
            this.LevelsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseMove);
            this.LevelsBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseUp);
            // 
            // LevelFile
            // 
            this.LevelFile.Text = "Level file";
            this.LevelFile.Width = 160;
            // 
            // LevelName
            // 
            this.LevelName.Text = "Level name";
            this.LevelName.Width = 128;
            // 
            // LevelSubName
            // 
            this.LevelSubName.Text = "Level sector name";
            this.LevelSubName.Width = 128;
            // 
            // LoadingWallpaper
            // 
            this.LoadingWallpaper.Text = "Loading wallpaper";
            this.LoadingWallpaper.Width = 180;
            // 
            // LevelsContextMenu
            // 
            this.LevelsContextMenu.BackColor = System.Drawing.Color.White;
            this.LevelsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewLevelToolStripMenuItem,
            this.editLevelInfoToolStripMenuItem,
            this.removeLevelToolStripMenuItem});
            this.LevelsContextMenu.Name = "LevelsContextMenu";
            this.LevelsContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.LevelsContextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addANewLevelToolStripMenuItem
            // 
            this.addANewLevelToolStripMenuItem.Name = "addANewLevelToolStripMenuItem";
            this.addANewLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addANewLevelToolStripMenuItem.Text = "Add";
            // 
            // editLevelInfoToolStripMenuItem
            // 
            this.editLevelInfoToolStripMenuItem.Name = "editLevelInfoToolStripMenuItem";
            this.editLevelInfoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editLevelInfoToolStripMenuItem.Text = "Edit";
            // 
            // removeLevelToolStripMenuItem
            // 
            this.removeLevelToolStripMenuItem.Name = "removeLevelToolStripMenuItem";
            this.removeLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeLevelToolStripMenuItem.Text = "Remove";
            // 
            // levelsMenuBar
            // 
            this.levelsMenuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.levelsMenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.levelsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.levelsMenuBar.Location = new System.Drawing.Point(0, 272);
            this.levelsMenuBar.Name = "levelsMenuBar";
            this.levelsMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.levelsMenuBar.Size = new System.Drawing.Size(776, 25);
            this.levelsMenuBar.TabIndex = 1;
            this.levelsMenuBar.Text = "Menu";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(514, 22);
            this.Status.Text = "Right-click to add a level, modify it\'s info or to remove one. Use drag and drop " +
    "to re-order them.";
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Application.ico");
            this.Icons.Images.SetKeyName(1, "FileError.ico");
            this.Icons.Images.SetKeyName(2, "New.ico");
            this.Icons.Images.SetKeyName(3, "Object.ico");
            this.Icons.Images.SetKeyName(4, "Open.ico");
            this.Icons.Images.SetKeyName(5, "Pack.ico");
            this.Icons.Images.SetKeyName(6, "Save.ico");
            this.Icons.Images.SetKeyName(7, "Settings.ico");
            this.Icons.Images.SetKeyName(8, "Text.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Campaign SDK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.EditorTabs.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.CampaignDescriptionContainer.ResumeLayout(false);
            this.CampaignDescriptionContainer.PerformLayout();
            this.LevelsTab.ResumeLayout(false);
            this.LevelsTab.PerformLayout();
            this.LevelsContextMenu.ResumeLayout(false);
            this.levelsMenuBar.ResumeLayout(false);
            this.levelsMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripButton SaveAsBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label CampaignNameLbl;
        private System.Windows.Forms.TextBox CampaignNameBox;
        private System.Windows.Forms.TabPage LevelsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampaignDescriptionBox;
        private System.Windows.Forms.Panel CampaignDescriptionContainer;
        private System.Windows.Forms.ToolStrip MenuBar;
        private ReorderableListView LevelsBox;
        private System.Windows.Forms.ToolStrip levelsMenuBar;
        private System.Windows.Forms.ToolStripLabel Status;
        private System.Windows.Forms.ContextMenuStrip LevelsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addANewLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLevelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLevelToolStripMenuItem;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader LevelFile;
        private System.Windows.Forms.ColumnHeader LevelName;
        private System.Windows.Forms.ColumnHeader LevelSubName;
        private System.Windows.Forms.ColumnHeader LoadingWallpaper;
    }
}