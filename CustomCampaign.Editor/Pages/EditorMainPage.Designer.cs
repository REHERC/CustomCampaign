using CustomCampaign.Editor.Controls;
using MaterialSkin.Controls;

namespace CustomCampaign.Editor.Pages
{
    partial class EditorMainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditorLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.EditorTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.FileTab = new System.Windows.Forms.TabPage();
            this.FileLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ActionsPanel = new MaterialSkin.Controls.MaterialPanel();
            this.CloseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.FolderBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ValidateBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ImportBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.PackBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.OpenBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NewBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MenuDivider = new MaterialSkin.Controls.MaterialDivider();
            this.FileRightSide = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.OverviewLevelsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.OverviewLbl = new MaterialSkin.Controls.MaterialLabel();
            this.Overview = new CustomCampaign.Editor.Controls.InfoCard();
            this.OverviewLevels = new MaterialSkin.Controls.MaterialListBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.SprintPlaylist = new MaterialSkin.Controls.MaterialCheckBox();
            this.CampaignName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignGamemode = new MaterialSkin.Controls.MaterialDropDown();
            this.CampaignDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignUnlockStyle = new MaterialSkin.Controls.MaterialDropDown();
            this.CampaignLogo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignAuthors = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OldIntro = new MaterialSkin.Controls.MaterialCheckBox();
            this.LevelsTab = new System.Windows.Forms.TabPage();
            this.LevelsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Levels = new CustomCampaign.Editor.Controls.LevelBox();
            this.LevelsMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.AddLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.EditLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelActions = new MaterialSkin.Controls.MaterialPanel();
            this.MoveLevelDownBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MoveLevelUpBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.RemoveLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.AddonsTab = new System.Windows.Forms.TabPage();
            this.AddonsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.AddonActions = new MaterialSkin.Controls.MaterialPanel();
            this.MoveAddonDownBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MoveAddonUpBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.RemoveAddonBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditAddonBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddAddonBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Addons = new CustomCampaign.Editor.Controls.AddonBox();
            this.AddonsMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.AddAddon = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAddon = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAddon = new System.Windows.Forms.ToolStripMenuItem();
            this.TabDivider = new MaterialSkin.Controls.MaterialDivider();
            this.EditorLayout.SuspendLayout();
            this.EditorTabs.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.FileLayout.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.FileRightSide.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsLayout.SuspendLayout();
            this.LevelsTab.SuspendLayout();
            this.LevelsLayout.SuspendLayout();
            this.LevelsMenu.SuspendLayout();
            this.LevelActions.SuspendLayout();
            this.AddonsTab.SuspendLayout();
            this.AddonsLayout.SuspendLayout();
            this.AddonActions.SuspendLayout();
            this.AddonsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorLayout
            // 
            this.EditorLayout.ColumnCount = 1;
            this.EditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorLayout.Controls.Add(this.TabSelector, 0, 0);
            this.EditorLayout.Controls.Add(this.TabDivider, 0, 1);
            this.EditorLayout.Controls.Add(this.EditorTabs, 0, 2);
            this.EditorLayout.Depth = 0;
            this.EditorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorLayout.Location = new System.Drawing.Point(0, 0);
            this.EditorLayout.Margin = new System.Windows.Forms.Padding(0);
            this.EditorLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditorLayout.Name = "EditorLayout";
            this.EditorLayout.RowCount = 3;
            this.EditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.EditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.EditorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorLayout.Size = new System.Drawing.Size(784, 371);
            this.EditorLayout.TabIndex = 2;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.EditorTabs;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSelector.Location = new System.Drawing.Point(0, 0);
            this.TabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Primary = false;
            this.TabSelector.Size = new System.Drawing.Size(784, 36);
            this.TabSelector.TabIndex = 1;
            // 
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.FileTab);
            this.EditorTabs.Controls.Add(this.SettingsTab);
            this.EditorTabs.Controls.Add(this.LevelsTab);
            this.EditorTabs.Controls.Add(this.AddonsTab);
            this.EditorTabs.Depth = 0;
            this.EditorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTabs.Location = new System.Drawing.Point(0, 37);
            this.EditorTabs.Margin = new System.Windows.Forms.Padding(0);
            this.EditorTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(784, 334);
            this.EditorTabs.TabIndex = 0;
            this.EditorTabs.SelectedIndexChanged += new System.EventHandler(this.EditorTabs_SelectedIndexChanged);
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.FileLayout);
            this.FileTab.Location = new System.Drawing.Point(4, 22);
            this.FileTab.Margin = new System.Windows.Forms.Padding(0);
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(776, 308);
            this.FileTab.TabIndex = 3;
            this.FileTab.Text = "File";
            this.FileTab.UseVisualStyleBackColor = true;
            // 
            // FileLayout
            // 
            this.FileLayout.ColumnCount = 2;
            this.FileLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.FileLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FileLayout.Controls.Add(this.ActionsPanel, 0, 0);
            this.FileLayout.Controls.Add(this.FileRightSide, 1, 0);
            this.FileLayout.Depth = 0;
            this.FileLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileLayout.Location = new System.Drawing.Point(0, 0);
            this.FileLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileLayout.Name = "FileLayout";
            this.FileLayout.RowCount = 1;
            this.FileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileLayout.Size = new System.Drawing.Size(776, 308);
            this.FileLayout.TabIndex = 0;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.CloseBtn);
            this.ActionsPanel.Controls.Add(this.FolderBtn);
            this.ActionsPanel.Controls.Add(this.ValidateBtn);
            this.ActionsPanel.Controls.Add(this.ImportBtn);
            this.ActionsPanel.Controls.Add(this.PackBtn);
            this.ActionsPanel.Controls.Add(this.SaveBtn);
            this.ActionsPanel.Controls.Add(this.OpenBtn);
            this.ActionsPanel.Controls.Add(this.NewBtn);
            this.ActionsPanel.Controls.Add(this.MenuDivider);
            this.ActionsPanel.Depth = 0;
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ActionsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(160, 308);
            this.ActionsPanel.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.Depth = 0;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseBtn.Icon = null;
            this.CloseBtn.Location = new System.Drawing.Point(0, 252);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Primary = false;
            this.CloseBtn.Size = new System.Drawing.Size(159, 36);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close Project";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FolderBtn
            // 
            this.FolderBtn.AutoSize = true;
            this.FolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderBtn.Depth = 0;
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderBtn.Icon = null;
            this.FolderBtn.Location = new System.Drawing.Point(0, 216);
            this.FolderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FolderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Primary = false;
            this.FolderBtn.Size = new System.Drawing.Size(159, 36);
            this.FolderBtn.TabIndex = 6;
            this.FolderBtn.Text = "Project Folder";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.AutoSize = true;
            this.ValidateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValidateBtn.Depth = 0;
            this.ValidateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValidateBtn.Icon = null;
            this.ValidateBtn.Location = new System.Drawing.Point(0, 180);
            this.ValidateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ValidateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Primary = false;
            this.ValidateBtn.Size = new System.Drawing.Size(159, 36);
            this.ValidateBtn.TabIndex = 8;
            this.ValidateBtn.Text = "Check Files";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.Depth = 0;
            this.ImportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImportBtn.Icon = null;
            this.ImportBtn.Location = new System.Drawing.Point(0, 144);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Primary = false;
            this.ImportBtn.Size = new System.Drawing.Size(159, 36);
            this.ImportBtn.TabIndex = 7;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // PackBtn
            // 
            this.PackBtn.AutoSize = true;
            this.PackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PackBtn.Depth = 0;
            this.PackBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PackBtn.Icon = null;
            this.PackBtn.Location = new System.Drawing.Point(0, 108);
            this.PackBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PackBtn.Name = "PackBtn";
            this.PackBtn.Primary = false;
            this.PackBtn.Size = new System.Drawing.Size(159, 36);
            this.PackBtn.TabIndex = 3;
            this.PackBtn.Text = "Export";
            this.PackBtn.UseVisualStyleBackColor = true;
            this.PackBtn.Click += new System.EventHandler(this.PackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Depth = 0;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveBtn.Icon = null;
            this.SaveBtn.Location = new System.Drawing.Point(0, 72);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Primary = false;
            this.SaveBtn.Size = new System.Drawing.Size(159, 36);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenBtn.Depth = 0;
            this.OpenBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenBtn.Icon = null;
            this.OpenBtn.Location = new System.Drawing.Point(0, 36);
            this.OpenBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Primary = false;
            this.OpenBtn.Size = new System.Drawing.Size(159, 36);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSize = true;
            this.NewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewBtn.Depth = 0;
            this.NewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewBtn.Icon = null;
            this.NewBtn.Location = new System.Drawing.Point(0, 0);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Primary = false;
            this.NewBtn.Size = new System.Drawing.Size(159, 36);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // MenuDivider
            // 
            this.MenuDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuDivider.Depth = 0;
            this.MenuDivider.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuDivider.Location = new System.Drawing.Point(159, 0);
            this.MenuDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuDivider.Name = "MenuDivider";
            this.MenuDivider.Size = new System.Drawing.Size(1, 308);
            this.MenuDivider.TabIndex = 5;
            // 
            // FileRightSide
            // 
            this.FileRightSide.AutoSize = true;
            this.FileRightSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileRightSide.ColumnCount = 1;
            this.FileRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileRightSide.Controls.Add(this.OverviewLevelsLbl, 0, 2);
            this.FileRightSide.Controls.Add(this.OverviewLbl, 0, 0);
            this.FileRightSide.Controls.Add(this.Overview, 0, 1);
            this.FileRightSide.Controls.Add(this.OverviewLevels, 0, 3);
            this.FileRightSide.Depth = 0;
            this.FileRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileRightSide.Location = new System.Drawing.Point(160, 0);
            this.FileRightSide.Margin = new System.Windows.Forms.Padding(0);
            this.FileRightSide.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileRightSide.Name = "FileRightSide";
            this.FileRightSide.RowCount = 4;
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileRightSide.Size = new System.Drawing.Size(624, 308);
            this.FileRightSide.TabIndex = 1;
            // 
            // OverviewLevelsLbl
            // 
            this.OverviewLevelsLbl.AutoSize = true;
            this.OverviewLevelsLbl.Depth = 0;
            this.OverviewLevelsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewLevelsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.OverviewLevelsLbl.FontSize = 11;
            this.OverviewLevelsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OverviewLevelsLbl.FormLabel = false;
            this.OverviewLevelsLbl.Location = new System.Drawing.Point(4, 121);
            this.OverviewLevelsLbl.Margin = new System.Windows.Forms.Padding(4, 8, 2, 2);
            this.OverviewLevelsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverviewLevelsLbl.Name = "OverviewLevelsLbl";
            this.OverviewLevelsLbl.Size = new System.Drawing.Size(618, 19);
            this.OverviewLevelsLbl.TabIndex = 4;
            this.OverviewLevelsLbl.Text = "LEVELS";
            // 
            // OverviewLbl
            // 
            this.OverviewLbl.AutoSize = true;
            this.OverviewLbl.Depth = 0;
            this.OverviewLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.OverviewLbl.FontSize = 11;
            this.OverviewLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OverviewLbl.FormLabel = false;
            this.OverviewLbl.Location = new System.Drawing.Point(4, 8);
            this.OverviewLbl.Margin = new System.Windows.Forms.Padding(4, 8, 2, 2);
            this.OverviewLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverviewLbl.Name = "OverviewLbl";
            this.OverviewLbl.Size = new System.Drawing.Size(618, 19);
            this.OverviewLbl.TabIndex = 3;
            this.OverviewLbl.Text = "OVERVIEW";
            // 
            // Overview
            // 
            this.Overview.Contrast = true;
            this.Overview.Depth = 0;
            this.Overview.Description = "Campaign description";
            this.Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Overview.Location = new System.Drawing.Point(8, 35);
            this.Overview.Margin = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.Overview.MouseState = MaterialSkin.MouseState.HOVER;
            this.Overview.Name = "Overview";
            this.Overview.Picture = null;
            this.Overview.Round = false;
            this.Overview.ShowPicture = false;
            this.Overview.Size = new System.Drawing.Size(616, 72);
            this.Overview.TabIndex = 0;
            this.Overview.Title = "Campaign title";
            // 
            // OverviewLevels
            // 
            this.OverviewLevels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OverviewLevels.Depth = 0;
            this.OverviewLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.OverviewLevels.Font = new System.Drawing.Font("Roboto", 12F);
            this.OverviewLevels.FormattingEnabled = true;
            this.OverviewLevels.ItemHeight = 36;
            this.OverviewLevels.Location = new System.Drawing.Point(0, 144);
            this.OverviewLevels.Margin = new System.Windows.Forms.Padding(0, 2, 0, 6);
            this.OverviewLevels.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverviewLevels.Name = "OverviewLevels";
            this.OverviewLevels.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.OverviewLevels.Size = new System.Drawing.Size(624, 158);
            this.OverviewLevels.TabIndex = 5;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTab.Controls.Add(this.SettingsLayout);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(776, 308);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            // 
            // SettingsLayout
            // 
            this.SettingsLayout.ColumnCount = 1;
            this.SettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsLayout.Controls.Add(this.SprintPlaylist, 0, 6);
            this.SettingsLayout.Controls.Add(this.CampaignName, 0, 0);
            this.SettingsLayout.Controls.Add(this.CampaignGamemode, 0, 5);
            this.SettingsLayout.Controls.Add(this.CampaignDescription, 0, 1);
            this.SettingsLayout.Controls.Add(this.CampaignUnlockStyle, 0, 4);
            this.SettingsLayout.Controls.Add(this.CampaignLogo, 0, 2);
            this.SettingsLayout.Controls.Add(this.CampaignAuthors, 0, 3);
            this.SettingsLayout.Controls.Add(this.OldIntro, 0, 7);
            this.SettingsLayout.Depth = 0;
            this.SettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsLayout.Name = "SettingsLayout";
            this.SettingsLayout.Padding = new System.Windows.Forms.Padding(16);
            this.SettingsLayout.RowCount = 10;
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.SettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsLayout.Size = new System.Drawing.Size(776, 308);
            this.SettingsLayout.TabIndex = 2;
            // 
            // SprintPlaylist
            // 
            this.SprintPlaylist.Depth = 0;
            this.SprintPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SprintPlaylist.Font = new System.Drawing.Font("Roboto", 11F);
            this.SprintPlaylist.Location = new System.Drawing.Point(16, 222);
            this.SprintPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.SprintPlaylist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SprintPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.SprintPlaylist.Name = "SprintPlaylist";
            this.SprintPlaylist.Ripple = true;
            this.SprintPlaylist.Size = new System.Drawing.Size(744, 30);
            this.SprintPlaylist.TabIndex = 6;
            this.SprintPlaylist.Text = "Create arcade mode sprint playlist";
            this.SprintPlaylist.UseVisualStyleBackColor = true;
            // 
            // CampaignName
            // 
            this.CampaignName.Depth = 0;
            this.CampaignName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignName.Hint = "Campaign name";
            this.CampaignName.Location = new System.Drawing.Point(22, 22);
            this.CampaignName.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignName.MaxLength = 32767;
            this.CampaignName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignName.Name = "CampaignName";
            this.CampaignName.PasswordChar = '\0';
            this.CampaignName.SelectedText = "";
            this.CampaignName.SelectionLength = 0;
            this.CampaignName.SelectionStart = 0;
            this.CampaignName.Size = new System.Drawing.Size(732, 23);
            this.CampaignName.TabIndex = 0;
            this.CampaignName.TabStop = false;
            this.CampaignName.UseSystemPasswordChar = false;
            this.CampaignName.TextChanged += new System.EventHandler(this.CampaignInfoChanged);
            // 
            // CampaignGamemode
            // 
            this.CampaignGamemode.Depth = 0;
            this.CampaignGamemode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignGamemode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CampaignGamemode.DropDownHeight = 58;
            this.CampaignGamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampaignGamemode.FormattingEnabled = true;
            this.CampaignGamemode.Hint = "Game mode";
            this.CampaignGamemode.IntegralHeight = false;
            this.CampaignGamemode.Location = new System.Drawing.Point(22, 195);
            this.CampaignGamemode.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignGamemode.MouseState = MaterialSkin.MouseState.OUT;
            this.CampaignGamemode.Name = "CampaignGamemode";
            this.CampaignGamemode.Size = new System.Drawing.Size(732, 21);
            this.CampaignGamemode.TabIndex = 5;
            // 
            // CampaignDescription
            // 
            this.CampaignDescription.Depth = 0;
            this.CampaignDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescription.Hint = "Campaign description";
            this.CampaignDescription.Location = new System.Drawing.Point(22, 57);
            this.CampaignDescription.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignDescription.MaxLength = 32767;
            this.CampaignDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignDescription.Name = "CampaignDescription";
            this.CampaignDescription.PasswordChar = '\0';
            this.CampaignDescription.SelectedText = "";
            this.CampaignDescription.SelectionLength = 0;
            this.CampaignDescription.SelectionStart = 0;
            this.CampaignDescription.Size = new System.Drawing.Size(732, 23);
            this.CampaignDescription.TabIndex = 1;
            this.CampaignDescription.TabStop = false;
            this.CampaignDescription.UseSystemPasswordChar = false;
            this.CampaignDescription.TextChanged += new System.EventHandler(this.CampaignInfoChanged);
            // 
            // CampaignUnlockStyle
            // 
            this.CampaignUnlockStyle.Depth = 0;
            this.CampaignUnlockStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignUnlockStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CampaignUnlockStyle.DropDownHeight = 58;
            this.CampaignUnlockStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampaignUnlockStyle.FormattingEnabled = true;
            this.CampaignUnlockStyle.Hint = "Level unlocking style";
            this.CampaignUnlockStyle.IntegralHeight = false;
            this.CampaignUnlockStyle.Items.AddRange(new object[] {
            "Campaign (unlock levels by completing previous ones)",
            "Level set (every level unlocked by default)"});
            this.CampaignUnlockStyle.Location = new System.Drawing.Point(22, 162);
            this.CampaignUnlockStyle.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignUnlockStyle.MouseState = MaterialSkin.MouseState.OUT;
            this.CampaignUnlockStyle.Name = "CampaignUnlockStyle";
            this.CampaignUnlockStyle.Size = new System.Drawing.Size(732, 21);
            this.CampaignUnlockStyle.TabIndex = 4;
            // 
            // CampaignLogo
            // 
            this.CampaignLogo.Depth = 0;
            this.CampaignLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignLogo.Hint = "Campaign logo";
            this.CampaignLogo.Location = new System.Drawing.Point(22, 92);
            this.CampaignLogo.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignLogo.MaxLength = 32767;
            this.CampaignLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignLogo.Name = "CampaignLogo";
            this.CampaignLogo.PasswordChar = '\0';
            this.CampaignLogo.SelectedText = "";
            this.CampaignLogo.SelectionLength = 0;
            this.CampaignLogo.SelectionStart = 0;
            this.CampaignLogo.Size = new System.Drawing.Size(732, 23);
            this.CampaignLogo.TabIndex = 2;
            this.CampaignLogo.TabStop = false;
            this.CampaignLogo.UseSystemPasswordChar = false;
            this.CampaignLogo.TextChanged += new System.EventHandler(this.CampaignLogo_TextChanged);
            // 
            // CampaignAuthors
            // 
            this.CampaignAuthors.Depth = 0;
            this.CampaignAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignAuthors.Hint = "Authors";
            this.CampaignAuthors.Location = new System.Drawing.Point(22, 127);
            this.CampaignAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignAuthors.MaxLength = 32767;
            this.CampaignAuthors.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignAuthors.Name = "CampaignAuthors";
            this.CampaignAuthors.PasswordChar = '\0';
            this.CampaignAuthors.SelectedText = "";
            this.CampaignAuthors.SelectionLength = 0;
            this.CampaignAuthors.SelectionStart = 0;
            this.CampaignAuthors.Size = new System.Drawing.Size(732, 23);
            this.CampaignAuthors.TabIndex = 3;
            this.CampaignAuthors.TabStop = false;
            this.CampaignAuthors.UseSystemPasswordChar = false;
            // 
            // OldIntro
            // 
            this.OldIntro.Depth = 0;
            this.OldIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OldIntro.Font = new System.Drawing.Font("Roboto", 11F);
            this.OldIntro.Location = new System.Drawing.Point(16, 252);
            this.OldIntro.Margin = new System.Windows.Forms.Padding(0);
            this.OldIntro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OldIntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.OldIntro.Name = "OldIntro";
            this.OldIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OldIntro.Ripple = true;
            this.OldIntro.Size = new System.Drawing.Size(744, 30);
            this.OldIntro.TabIndex = 7;
            this.OldIntro.Text = "Use early access intro title (black bars with level name in the bottom-left corne" +
    "r)";
            this.OldIntro.UseVisualStyleBackColor = true;
            // 
            // LevelsTab
            // 
            this.LevelsTab.BackColor = System.Drawing.Color.White;
            this.LevelsTab.Controls.Add(this.LevelsLayout);
            this.LevelsTab.Location = new System.Drawing.Point(4, 22);
            this.LevelsTab.Margin = new System.Windows.Forms.Padding(0);
            this.LevelsTab.Name = "LevelsTab";
            this.LevelsTab.Size = new System.Drawing.Size(776, 308);
            this.LevelsTab.TabIndex = 1;
            this.LevelsTab.Text = "Levels";
            // 
            // LevelsLayout
            // 
            this.LevelsLayout.ColumnCount = 2;
            this.LevelsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.LevelsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LevelsLayout.Controls.Add(this.Levels, 1, 0);
            this.LevelsLayout.Controls.Add(this.LevelActions, 0, 0);
            this.LevelsLayout.Depth = 0;
            this.LevelsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsLayout.Location = new System.Drawing.Point(0, 0);
            this.LevelsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelsLayout.Name = "LevelsLayout";
            this.LevelsLayout.RowCount = 1;
            this.LevelsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LevelsLayout.Size = new System.Drawing.Size(776, 308);
            this.LevelsLayout.TabIndex = 1;
            // 
            // Levels
            // 
            this.Levels.AllowDrop = true;
            this.Levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Levels.ContextMenuStrip = this.LevelsMenu;
            this.Levels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Levels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Levels.FormattingEnabled = true;
            this.Levels.ItemHeight = 96;
            this.Levels.Location = new System.Drawing.Point(160, 0);
            this.Levels.Margin = new System.Windows.Forms.Padding(0);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(616, 308);
            this.Levels.TabIndex = 0;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.Levels_SelectedIndexChanged);
            this.Levels.DoubleClick += new System.EventHandler(this.Levels_DoubleClick);
            this.Levels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Levels_MouseDown);
            // 
            // LevelsMenu
            // 
            this.LevelsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LevelsMenu.Depth = 0;
            this.LevelsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLevel,
            this.EditLevel,
            this.RemoveLevel});
            this.LevelsMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelsMenu.Name = "LevelsMenu";
            this.LevelsMenu.Size = new System.Drawing.Size(118, 70);
            this.LevelsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.LevelsMenu_Opening);
            // 
            // AddLevel
            // 
            this.AddLevel.Name = "AddLevel";
            this.AddLevel.Size = new System.Drawing.Size(117, 22);
            this.AddLevel.Text = "Add";
            this.AddLevel.Click += new System.EventHandler(this.AddLevel_Click);
            // 
            // EditLevel
            // 
            this.EditLevel.Name = "EditLevel";
            this.EditLevel.Size = new System.Drawing.Size(117, 22);
            this.EditLevel.Text = "Edit";
            this.EditLevel.Click += new System.EventHandler(this.EditLevel_Click);
            // 
            // RemoveLevel
            // 
            this.RemoveLevel.Name = "RemoveLevel";
            this.RemoveLevel.Size = new System.Drawing.Size(117, 22);
            this.RemoveLevel.Text = "Remove";
            this.RemoveLevel.Click += new System.EventHandler(this.RemoveLevel_Click);
            // 
            // LevelActions
            // 
            this.LevelActions.Controls.Add(this.MoveLevelDownBtn);
            this.LevelActions.Controls.Add(this.MoveLevelUpBtn);
            this.LevelActions.Controls.Add(this.RemoveLevelBtn);
            this.LevelActions.Controls.Add(this.EditLevelBtn);
            this.LevelActions.Controls.Add(this.AddLevelBtn);
            this.LevelActions.Controls.Add(this.materialDivider1);
            this.LevelActions.Depth = 0;
            this.LevelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelActions.Location = new System.Drawing.Point(0, 0);
            this.LevelActions.Margin = new System.Windows.Forms.Padding(0);
            this.LevelActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelActions.Name = "LevelActions";
            this.LevelActions.Size = new System.Drawing.Size(160, 308);
            this.LevelActions.TabIndex = 0;
            // 
            // MoveLevelDownBtn
            // 
            this.MoveLevelDownBtn.AutoSize = true;
            this.MoveLevelDownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveLevelDownBtn.Depth = 0;
            this.MoveLevelDownBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveLevelDownBtn.Icon = null;
            this.MoveLevelDownBtn.Location = new System.Drawing.Point(0, 144);
            this.MoveLevelDownBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoveLevelDownBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoveLevelDownBtn.Name = "MoveLevelDownBtn";
            this.MoveLevelDownBtn.Primary = false;
            this.MoveLevelDownBtn.Size = new System.Drawing.Size(159, 36);
            this.MoveLevelDownBtn.TabIndex = 7;
            this.MoveLevelDownBtn.Text = "Move Down";
            this.MoveLevelDownBtn.UseVisualStyleBackColor = true;
            this.MoveLevelDownBtn.Click += new System.EventHandler(this.MoveLevelDownBtn_Click);
            // 
            // MoveLevelUpBtn
            // 
            this.MoveLevelUpBtn.AutoSize = true;
            this.MoveLevelUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveLevelUpBtn.Depth = 0;
            this.MoveLevelUpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveLevelUpBtn.Icon = null;
            this.MoveLevelUpBtn.Location = new System.Drawing.Point(0, 108);
            this.MoveLevelUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoveLevelUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoveLevelUpBtn.Name = "MoveLevelUpBtn";
            this.MoveLevelUpBtn.Primary = false;
            this.MoveLevelUpBtn.Size = new System.Drawing.Size(159, 36);
            this.MoveLevelUpBtn.TabIndex = 6;
            this.MoveLevelUpBtn.Text = "Move Up";
            this.MoveLevelUpBtn.UseVisualStyleBackColor = true;
            this.MoveLevelUpBtn.Click += new System.EventHandler(this.MoveLevelUpBtn_Click);
            // 
            // RemoveLevelBtn
            // 
            this.RemoveLevelBtn.AutoSize = true;
            this.RemoveLevelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveLevelBtn.Depth = 0;
            this.RemoveLevelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveLevelBtn.Icon = null;
            this.RemoveLevelBtn.Location = new System.Drawing.Point(0, 72);
            this.RemoveLevelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveLevelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveLevelBtn.Name = "RemoveLevelBtn";
            this.RemoveLevelBtn.Primary = false;
            this.RemoveLevelBtn.Size = new System.Drawing.Size(159, 36);
            this.RemoveLevelBtn.TabIndex = 2;
            this.RemoveLevelBtn.Text = "Remove";
            this.RemoveLevelBtn.UseVisualStyleBackColor = true;
            this.RemoveLevelBtn.Click += new System.EventHandler(this.RemoveLevelBtn_Click);
            // 
            // EditLevelBtn
            // 
            this.EditLevelBtn.AutoSize = true;
            this.EditLevelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditLevelBtn.Depth = 0;
            this.EditLevelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditLevelBtn.Icon = null;
            this.EditLevelBtn.Location = new System.Drawing.Point(0, 36);
            this.EditLevelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditLevelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditLevelBtn.Name = "EditLevelBtn";
            this.EditLevelBtn.Primary = false;
            this.EditLevelBtn.Size = new System.Drawing.Size(159, 36);
            this.EditLevelBtn.TabIndex = 1;
            this.EditLevelBtn.Text = "Edit";
            this.EditLevelBtn.UseVisualStyleBackColor = true;
            this.EditLevelBtn.Click += new System.EventHandler(this.EditLevelBtn_Click);
            // 
            // AddLevelBtn
            // 
            this.AddLevelBtn.AutoSize = true;
            this.AddLevelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddLevelBtn.Depth = 0;
            this.AddLevelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddLevelBtn.Icon = null;
            this.AddLevelBtn.Location = new System.Drawing.Point(0, 0);
            this.AddLevelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddLevelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddLevelBtn.Name = "AddLevelBtn";
            this.AddLevelBtn.Primary = false;
            this.AddLevelBtn.Size = new System.Drawing.Size(159, 36);
            this.AddLevelBtn.TabIndex = 0;
            this.AddLevelBtn.Text = "Add";
            this.AddLevelBtn.UseVisualStyleBackColor = true;
            this.AddLevelBtn.Click += new System.EventHandler(this.AddLevelBtn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider1.Location = new System.Drawing.Point(159, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 308);
            this.materialDivider1.TabIndex = 5;
            // 
            // AddonsTab
            // 
            this.AddonsTab.Controls.Add(this.AddonsLayout);
            this.AddonsTab.Location = new System.Drawing.Point(4, 22);
            this.AddonsTab.Margin = new System.Windows.Forms.Padding(0);
            this.AddonsTab.Name = "AddonsTab";
            this.AddonsTab.Size = new System.Drawing.Size(776, 308);
            this.AddonsTab.TabIndex = 2;
            this.AddonsTab.Text = "Addons";
            this.AddonsTab.UseVisualStyleBackColor = true;
            // 
            // AddonsLayout
            // 
            this.AddonsLayout.ColumnCount = 2;
            this.AddonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.AddonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddonsLayout.Controls.Add(this.AddonActions, 0, 0);
            this.AddonsLayout.Controls.Add(this.Addons, 1, 0);
            this.AddonsLayout.Depth = 0;
            this.AddonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddonsLayout.Location = new System.Drawing.Point(0, 0);
            this.AddonsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddonsLayout.Name = "AddonsLayout";
            this.AddonsLayout.RowCount = 1;
            this.AddonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddonsLayout.Size = new System.Drawing.Size(776, 308);
            this.AddonsLayout.TabIndex = 2;
            // 
            // AddonActions
            // 
            this.AddonActions.Controls.Add(this.MoveAddonDownBtn);
            this.AddonActions.Controls.Add(this.MoveAddonUpBtn);
            this.AddonActions.Controls.Add(this.RemoveAddonBtn);
            this.AddonActions.Controls.Add(this.EditAddonBtn);
            this.AddonActions.Controls.Add(this.AddAddonBtn);
            this.AddonActions.Controls.Add(this.materialDivider2);
            this.AddonActions.Depth = 0;
            this.AddonActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddonActions.Location = new System.Drawing.Point(0, 0);
            this.AddonActions.Margin = new System.Windows.Forms.Padding(0);
            this.AddonActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddonActions.Name = "AddonActions";
            this.AddonActions.Size = new System.Drawing.Size(160, 308);
            this.AddonActions.TabIndex = 0;
            // 
            // MoveAddonDownBtn
            // 
            this.MoveAddonDownBtn.AutoSize = true;
            this.MoveAddonDownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveAddonDownBtn.Depth = 0;
            this.MoveAddonDownBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveAddonDownBtn.Icon = null;
            this.MoveAddonDownBtn.Location = new System.Drawing.Point(0, 144);
            this.MoveAddonDownBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoveAddonDownBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoveAddonDownBtn.Name = "MoveAddonDownBtn";
            this.MoveAddonDownBtn.Primary = false;
            this.MoveAddonDownBtn.Size = new System.Drawing.Size(159, 36);
            this.MoveAddonDownBtn.TabIndex = 9;
            this.MoveAddonDownBtn.Text = "Move Down";
            this.MoveAddonDownBtn.UseVisualStyleBackColor = true;
            this.MoveAddonDownBtn.Click += new System.EventHandler(this.MoveAddonDownBtn_Click);
            // 
            // MoveAddonUpBtn
            // 
            this.MoveAddonUpBtn.AutoSize = true;
            this.MoveAddonUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveAddonUpBtn.Depth = 0;
            this.MoveAddonUpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveAddonUpBtn.Icon = null;
            this.MoveAddonUpBtn.Location = new System.Drawing.Point(0, 108);
            this.MoveAddonUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoveAddonUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoveAddonUpBtn.Name = "MoveAddonUpBtn";
            this.MoveAddonUpBtn.Primary = false;
            this.MoveAddonUpBtn.Size = new System.Drawing.Size(159, 36);
            this.MoveAddonUpBtn.TabIndex = 8;
            this.MoveAddonUpBtn.Text = "Move Up";
            this.MoveAddonUpBtn.UseVisualStyleBackColor = true;
            this.MoveAddonUpBtn.Click += new System.EventHandler(this.MoveAddonUpBtn_Click);
            // 
            // RemoveAddonBtn
            // 
            this.RemoveAddonBtn.AutoSize = true;
            this.RemoveAddonBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveAddonBtn.Depth = 0;
            this.RemoveAddonBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveAddonBtn.Icon = null;
            this.RemoveAddonBtn.Location = new System.Drawing.Point(0, 72);
            this.RemoveAddonBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveAddonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveAddonBtn.Name = "RemoveAddonBtn";
            this.RemoveAddonBtn.Primary = false;
            this.RemoveAddonBtn.Size = new System.Drawing.Size(159, 36);
            this.RemoveAddonBtn.TabIndex = 2;
            this.RemoveAddonBtn.Text = "Remove";
            this.RemoveAddonBtn.UseVisualStyleBackColor = true;
            this.RemoveAddonBtn.Click += new System.EventHandler(this.RemoveAddonBtn_Click);
            // 
            // EditAddonBtn
            // 
            this.EditAddonBtn.AutoSize = true;
            this.EditAddonBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditAddonBtn.Depth = 0;
            this.EditAddonBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditAddonBtn.Icon = null;
            this.EditAddonBtn.Location = new System.Drawing.Point(0, 36);
            this.EditAddonBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditAddonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditAddonBtn.Name = "EditAddonBtn";
            this.EditAddonBtn.Primary = false;
            this.EditAddonBtn.Size = new System.Drawing.Size(159, 36);
            this.EditAddonBtn.TabIndex = 1;
            this.EditAddonBtn.Text = "Edit";
            this.EditAddonBtn.UseVisualStyleBackColor = true;
            this.EditAddonBtn.Click += new System.EventHandler(this.EditAddonBtn_Click);
            // 
            // AddAddonBtn
            // 
            this.AddAddonBtn.AutoSize = true;
            this.AddAddonBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddAddonBtn.Depth = 0;
            this.AddAddonBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAddonBtn.Icon = null;
            this.AddAddonBtn.Location = new System.Drawing.Point(0, 0);
            this.AddAddonBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddAddonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAddonBtn.Name = "AddAddonBtn";
            this.AddAddonBtn.Primary = false;
            this.AddAddonBtn.Size = new System.Drawing.Size(159, 36);
            this.AddAddonBtn.TabIndex = 0;
            this.AddAddonBtn.Text = "Add";
            this.AddAddonBtn.UseVisualStyleBackColor = true;
            this.AddAddonBtn.Click += new System.EventHandler(this.AddAddonBtn_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider2.Location = new System.Drawing.Point(159, 0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 308);
            this.materialDivider2.TabIndex = 5;
            // 
            // Addons
            // 
            this.Addons.AllowDrop = true;
            this.Addons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Addons.ContextMenuStrip = this.AddonsMenu;
            this.Addons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Addons.FormattingEnabled = true;
            this.Addons.ItemHeight = 48;
            this.Addons.Location = new System.Drawing.Point(160, 0);
            this.Addons.Margin = new System.Windows.Forms.Padding(0);
            this.Addons.Name = "Addons";
            this.Addons.Size = new System.Drawing.Size(616, 308);
            this.Addons.TabIndex = 1;
            this.Addons.SelectedIndexChanged += new System.EventHandler(this.Addons_SelectedIndexChanged);
            this.Addons.DoubleClick += new System.EventHandler(this.Addons_DoubleClick);
            this.Addons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Addons_MouseDown);
            // 
            // AddonsMenu
            // 
            this.AddonsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddonsMenu.Depth = 0;
            this.AddonsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAddon,
            this.EditAddon,
            this.RemoveAddon});
            this.AddonsMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddonsMenu.Name = "LevelsMenu";
            this.AddonsMenu.Size = new System.Drawing.Size(118, 70);
            this.AddonsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.AddonsMenu_Opening);
            // 
            // AddAddon
            // 
            this.AddAddon.Name = "AddAddon";
            this.AddAddon.Size = new System.Drawing.Size(117, 22);
            this.AddAddon.Text = "Add";
            this.AddAddon.Click += new System.EventHandler(this.AddAddon_Click);
            // 
            // EditAddon
            // 
            this.EditAddon.Name = "EditAddon";
            this.EditAddon.Size = new System.Drawing.Size(117, 22);
            this.EditAddon.Text = "Edit";
            this.EditAddon.Click += new System.EventHandler(this.EditAddon_Click);
            // 
            // RemoveAddon
            // 
            this.RemoveAddon.Name = "RemoveAddon";
            this.RemoveAddon.Size = new System.Drawing.Size(117, 22);
            this.RemoveAddon.Text = "Remove";
            this.RemoveAddon.Click += new System.EventHandler(this.RemoveAddon_Click);
            // 
            // TabDivider
            // 
            this.TabDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabDivider.Depth = 0;
            this.TabDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabDivider.Location = new System.Drawing.Point(0, 36);
            this.TabDivider.Margin = new System.Windows.Forms.Padding(0);
            this.TabDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabDivider.Name = "TabDivider";
            this.TabDivider.Size = new System.Drawing.Size(784, 1);
            this.TabDivider.TabIndex = 2;
            this.TabDivider.Text = "materialDivider1";
            // 
            // EditorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.EditorLayout);
            this.Name = "EditorMainPage";
            this.PageName = "pages:editormain";
            this.PageTitle = "Campaign editor";
            this.Size = new System.Drawing.Size(784, 371);
            this.EditorLayout.ResumeLayout(false);
            this.EditorTabs.ResumeLayout(false);
            this.FileTab.ResumeLayout(false);
            this.FileLayout.ResumeLayout(false);
            this.FileLayout.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.FileRightSide.ResumeLayout(false);
            this.FileRightSide.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsLayout.ResumeLayout(false);
            this.LevelsTab.ResumeLayout(false);
            this.LevelsLayout.ResumeLayout(false);
            this.LevelsMenu.ResumeLayout(false);
            this.LevelActions.ResumeLayout(false);
            this.LevelActions.PerformLayout();
            this.AddonsTab.ResumeLayout(false);
            this.AddonsLayout.ResumeLayout(false);
            this.AddonActions.ResumeLayout(false);
            this.AddonActions.PerformLayout();
            this.AddonsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal MaterialTabSelector TabSelector;
        internal MaterialTableLayoutPanel EditorLayout;
        internal MaterialTabControl EditorTabs;
        internal System.Windows.Forms.TabPage SettingsTab;
        internal MaterialDropDown CampaignGamemode;
        internal MaterialDropDown CampaignUnlockStyle;
        internal MaterialSingleLineTextField CampaignAuthors;
        internal MaterialSingleLineTextField CampaignLogo;
        internal MaterialSingleLineTextField CampaignName;
        internal System.Windows.Forms.TabPage LevelsTab;
        internal System.Windows.Forms.TabPage AddonsTab;
        internal System.Windows.Forms.TabPage FileTab;
        internal MaterialTableLayoutPanel FileLayout;
        internal MaterialPanel ActionsPanel;
        internal MaterialFlatButton CloseBtn;
        internal MaterialFlatButton PackBtn;
        internal MaterialFlatButton SaveBtn;
        internal MaterialFlatButton OpenBtn;
        internal MaterialFlatButton NewBtn;
        internal MaterialDivider MenuDivider;
        internal MaterialDivider TabDivider;
        internal MaterialTableLayoutPanel FileRightSide;
        internal InfoCard Overview;
        internal MaterialContextMenuStrip LevelsMenu;
        internal System.Windows.Forms.ToolStripMenuItem AddLevel;
        internal System.Windows.Forms.ToolStripMenuItem EditLevel;
        internal System.Windows.Forms.ToolStripMenuItem RemoveLevel;
        internal MaterialFlatButton FolderBtn;
        internal MaterialFlatButton ImportBtn;
        internal MaterialTableLayoutPanel LevelsLayout;
        internal MaterialPanel LevelActions;
        internal MaterialFlatButton RemoveLevelBtn;
        internal MaterialFlatButton EditLevelBtn;
        internal MaterialFlatButton AddLevelBtn;
        internal MaterialDivider materialDivider1;
        internal LevelBox Levels;
        internal MaterialFlatButton ValidateBtn;
        internal MaterialTableLayoutPanel AddonsLayout;
        internal MaterialPanel AddonActions;
        internal MaterialFlatButton RemoveAddonBtn;
        internal MaterialFlatButton EditAddonBtn;
        internal MaterialFlatButton AddAddonBtn;
        internal MaterialDivider materialDivider2;
        internal MaterialFlatButton MoveLevelDownBtn;
        internal MaterialFlatButton MoveLevelUpBtn;
        internal MaterialContextMenuStrip AddonsMenu;
        internal System.Windows.Forms.ToolStripMenuItem AddAddon;
        internal System.Windows.Forms.ToolStripMenuItem EditAddon;
        internal System.Windows.Forms.ToolStripMenuItem RemoveAddon;
        internal AddonBox Addons;
        internal MaterialFlatButton MoveAddonDownBtn;
        internal MaterialFlatButton MoveAddonUpBtn;
        internal MaterialLabel OverviewLbl;
        internal MaterialLabel OverviewLevelsLbl;
        internal MaterialListBox OverviewLevels;
        internal MaterialCheckBox SprintPlaylist;
        internal MaterialSingleLineTextField CampaignDescription;
        internal MaterialCheckBox OldIntro;
        internal MaterialTableLayoutPanel SettingsLayout;
    }
}
