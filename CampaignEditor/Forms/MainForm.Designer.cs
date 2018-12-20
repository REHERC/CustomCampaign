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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CampaignLogoLbl = new System.Windows.Forms.Label();
            this.CampaignDescriptionLbl = new System.Windows.Forms.Label();
            this.CampaignNameLbl = new System.Windows.Forms.Label();
            this.CampaignNameBox = new System.Windows.Forms.TextBox();
            this.CampaignLogoBox = new System.Windows.Forms.TextBox();
            this.CampaignDescriptionBox = new System.Windows.Forms.TextBox();
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
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PackBtn = new System.Windows.Forms.ToolStripButton();
            this.MainPanel.SuspendLayout();
            this.EditorTabs.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.LevelsTab.SuspendLayout();
            this.LevelsContextMenu.SuspendLayout();
            this.levelsMenuBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EditorTabs);
            this.MainPanel.Controls.Add(this.MenuBar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 362);
            this.MainPanel.TabIndex = 1;
            // 
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.SettingsTab);
            this.EditorTabs.Controls.Add(this.LevelsTab);
            this.EditorTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTabs.ImageList = this.Icons;
            this.EditorTabs.Location = new System.Drawing.Point(0, 38);
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
            this.SettingsPanel.Controls.Add(this.CampaignLogoLbl, 0, 2);
            this.SettingsPanel.Controls.Add(this.CampaignDescriptionLbl, 0, 1);
            this.SettingsPanel.Controls.Add(this.CampaignNameLbl, 0, 0);
            this.SettingsPanel.Controls.Add(this.CampaignNameBox, 1, 0);
            this.SettingsPanel.Controls.Add(this.CampaignLogoBox, 1, 2);
            this.SettingsPanel.Controls.Add(this.CampaignDescriptionBox, 1, 1);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 3;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsPanel.Size = new System.Drawing.Size(770, 291);
            this.SettingsPanel.TabIndex = 0;
            // 
            // CampaignLogoLbl
            // 
            this.CampaignLogoLbl.AutoSize = true;
            this.CampaignLogoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignLogoLbl.Location = new System.Drawing.Point(0, 40);
            this.CampaignLogoLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignLogoLbl.Name = "CampaignLogoLbl";
            this.CampaignLogoLbl.Size = new System.Drawing.Size(113, 251);
            this.CampaignLogoLbl.TabIndex = 3;
            this.CampaignLogoLbl.Text = "Campaign logo file:";
            this.CampaignLogoLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignDescriptionLbl
            // 
            this.CampaignDescriptionLbl.AutoSize = true;
            this.CampaignDescriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionLbl.Location = new System.Drawing.Point(0, 20);
            this.CampaignDescriptionLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionLbl.Name = "CampaignDescriptionLbl";
            this.CampaignDescriptionLbl.Size = new System.Drawing.Size(113, 20);
            this.CampaignDescriptionLbl.TabIndex = 2;
            this.CampaignDescriptionLbl.Text = "Campaign description:";
            this.CampaignDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameLbl
            // 
            this.CampaignNameLbl.AutoSize = true;
            this.CampaignNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameLbl.Location = new System.Drawing.Point(0, 0);
            this.CampaignNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameLbl.Name = "CampaignNameLbl";
            this.CampaignNameLbl.Size = new System.Drawing.Size(113, 20);
            this.CampaignNameLbl.TabIndex = 0;
            this.CampaignNameLbl.Text = "Campaign name:";
            this.CampaignNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameBox
            // 
            this.CampaignNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameBox.Location = new System.Drawing.Point(113, 0);
            this.CampaignNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameBox.Name = "CampaignNameBox";
            this.CampaignNameBox.Size = new System.Drawing.Size(657, 20);
            this.CampaignNameBox.TabIndex = 0;
            // 
            // CampaignLogoBox
            // 
            this.CampaignLogoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignLogoBox.Location = new System.Drawing.Point(113, 40);
            this.CampaignLogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignLogoBox.Name = "CampaignLogoBox";
            this.CampaignLogoBox.Size = new System.Drawing.Size(657, 20);
            this.CampaignLogoBox.TabIndex = 2;
            // 
            // CampaignDescriptionBox
            // 
            this.CampaignDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionBox.Location = new System.Drawing.Point(113, 20);
            this.CampaignDescriptionBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionBox.Name = "CampaignDescriptionBox";
            this.CampaignDescriptionBox.Size = new System.Drawing.Size(657, 20);
            this.CampaignDescriptionBox.TabIndex = 1;
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
            this.LevelsBox.DoubleClick += new System.EventHandler(this.LevelsBox_DoubleClick);
            this.LevelsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseDown);
            this.LevelsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseMove);
            this.LevelsBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LevelsBox_MouseUp);
            // 
            // LevelFile
            // 
            this.LevelFile.Text = "Level file";
            this.LevelFile.Width = 180;
            // 
            // LevelName
            // 
            this.LevelName.Text = "Level name";
            this.LevelName.Width = 180;
            // 
            // LevelSubName
            // 
            this.LevelSubName.Text = "Level sector name";
            this.LevelSubName.Width = 220;
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
            this.LevelsContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.LevelsContextMenu_Opening);
            // 
            // addANewLevelToolStripMenuItem
            // 
            this.addANewLevelToolStripMenuItem.Name = "addANewLevelToolStripMenuItem";
            this.addANewLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addANewLevelToolStripMenuItem.Text = "Add";
            this.addANewLevelToolStripMenuItem.Click += new System.EventHandler(this.AddANewLevelToolStripMenuItem_Click);
            // 
            // editLevelInfoToolStripMenuItem
            // 
            this.editLevelInfoToolStripMenuItem.Name = "editLevelInfoToolStripMenuItem";
            this.editLevelInfoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editLevelInfoToolStripMenuItem.Text = "Edit";
            this.editLevelInfoToolStripMenuItem.Click += new System.EventHandler(this.EditLevelInfoToolStripMenuItem_Click);
            // 
            // removeLevelToolStripMenuItem
            // 
            this.removeLevelToolStripMenuItem.Name = "removeLevelToolStripMenuItem";
            this.removeLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeLevelToolStripMenuItem.Text = "Remove";
            this.removeLevelToolStripMenuItem.Click += new System.EventHandler(this.RemoveLevelToolStripMenuItem_Click);
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
            this.Status.Size = new System.Drawing.Size(568, 22);
            this.Status.Text = "Right-click to add/edit/remove a level. Use drag and drop to re-order items. Doub" +
    "le-click an item to edit it.";
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
            // MenuBar
            // 
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.toolStripSeparator1,
            this.OpenBtn,
            this.toolStripSeparator2,
            this.SaveBtn,
            this.toolStripSeparator3,
            this.PackBtn});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(784, 38);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "Menu";
            // 
            // NewBtn
            // 
            this.NewBtn.Image = global::CustomCampaign.Properties.Resources.New16;
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(35, 35);
            this.NewBtn.Text = "New";
            this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Image = global::CustomCampaign.Properties.Resources.Open16;
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(40, 35);
            this.OpenBtn.Text = "Open";
            this.OpenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenBtn.ToolTipText = "Open";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::CustomCampaign.Properties.Resources.Save16;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(35, 35);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // PackBtn
            // 
            this.PackBtn.Enabled = false;
            this.PackBtn.Image = global::CustomCampaign.Properties.Resources.Pack16;
            this.PackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PackBtn.Name = "PackBtn";
            this.PackBtn.Size = new System.Drawing.Size(36, 35);
            this.PackBtn.Text = "Pack";
            this.PackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Campaign SDK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.EditorTabs.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.LevelsTab.ResumeLayout(false);
            this.LevelsTab.PerformLayout();
            this.LevelsContextMenu.ResumeLayout(false);
            this.levelsMenuBar.ResumeLayout(false);
            this.levelsMenuBar.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label CampaignNameLbl;
        private System.Windows.Forms.TextBox CampaignNameBox;
        private System.Windows.Forms.TabPage LevelsTab;
        private System.Windows.Forms.Label CampaignDescriptionLbl;
        private ReorderableListView LevelsBox;
        private System.Windows.Forms.ToolStrip levelsMenuBar;
        private System.Windows.Forms.ContextMenuStrip LevelsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addANewLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLevelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLevelToolStripMenuItem;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.ColumnHeader LevelFile;
        private System.Windows.Forms.ColumnHeader LevelName;
        private System.Windows.Forms.ColumnHeader LevelSubName;
        private System.Windows.Forms.ColumnHeader LoadingWallpaper;
        private System.Windows.Forms.Label CampaignLogoLbl;
        private System.Windows.Forms.TextBox CampaignLogoBox;
        private System.Windows.Forms.TextBox CampaignDescriptionBox;
        private System.Windows.Forms.ToolStrip MenuBar;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton PackBtn;
        private System.Windows.Forms.ToolStripLabel Status;
    }
}