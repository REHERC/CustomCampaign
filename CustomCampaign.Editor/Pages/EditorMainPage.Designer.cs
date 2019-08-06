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
            this.TabPages = new MaterialSkin.Controls.MaterialTabControl();
            this.FileTab = new System.Windows.Forms.TabPage();
            this.FileLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ActionsPanel = new MaterialSkin.Controls.MaterialPanel();
            this.CloseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.FolderBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ImportBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.PackBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.OpenBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NewBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MenuDivider = new MaterialSkin.Controls.MaterialDivider();
            this.FileRightSide = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Overview = new CustomCampaign.Editor.Controls.PizzaCard();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsLayout = new MaterialSkin.Controls.MaterialPanel();
            this.CampaignGamemode = new MaterialDropDown();
            this.CampaignUnlockStyle = new MaterialDropDown();
            this.CampaignAuthors = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignLogo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LevelsTab = new System.Windows.Forms.TabPage();
            this.Levels = new CustomCampaign.Editor.Controls.LevelBox();
            this.LevelsMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.AddLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.EditLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.AddonsTab = new System.Windows.Forms.TabPage();
            this.TabDivider = new MaterialSkin.Controls.MaterialDivider();
            this.LevelsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.RemoveLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddLevelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.EditorLayout.SuspendLayout();
            this.TabPages.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.FileLayout.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.FileRightSide.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsLayout.SuspendLayout();
            this.LevelsTab.SuspendLayout();
            this.LevelsMenu.SuspendLayout();
            this.LevelsLayout.SuspendLayout();
            this.materialPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorLayout
            // 
            this.EditorLayout.ColumnCount = 1;
            this.EditorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorLayout.Controls.Add(this.TabSelector, 0, 0);
            this.EditorLayout.Controls.Add(this.TabPages, 0, 2);
            this.EditorLayout.Controls.Add(this.TabDivider, 0, 1);
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
            this.EditorLayout.Size = new System.Drawing.Size(784, 328);
            this.EditorLayout.TabIndex = 2;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabPages;
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
            // TabPages
            // 
            this.TabPages.Controls.Add(this.FileTab);
            this.TabPages.Controls.Add(this.SettingsTab);
            this.TabPages.Controls.Add(this.LevelsTab);
            this.TabPages.Controls.Add(this.AddonsTab);
            this.TabPages.Depth = 0;
            this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPages.Location = new System.Drawing.Point(0, 37);
            this.TabPages.Margin = new System.Windows.Forms.Padding(0);
            this.TabPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(784, 291);
            this.TabPages.TabIndex = 0;
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.FileLayout);
            this.FileTab.Location = new System.Drawing.Point(4, 22);
            this.FileTab.Margin = new System.Windows.Forms.Padding(0);
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(776, 265);
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
            this.FileLayout.Size = new System.Drawing.Size(776, 265);
            this.FileLayout.TabIndex = 0;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.CloseBtn);
            this.ActionsPanel.Controls.Add(this.FolderBtn);
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
            this.ActionsPanel.Size = new System.Drawing.Size(160, 265);
            this.ActionsPanel.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.Depth = 0;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseBtn.Icon = null;
            this.CloseBtn.Location = new System.Drawing.Point(0, 216);
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
            this.FolderBtn.Location = new System.Drawing.Point(0, 180);
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
            this.MenuDivider.Size = new System.Drawing.Size(1, 265);
            this.MenuDivider.TabIndex = 5;
            // 
            // FileRightSide
            // 
            this.FileRightSide.AutoSize = true;
            this.FileRightSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileRightSide.ColumnCount = 1;
            this.FileRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileRightSide.Controls.Add(this.Overview, 0, 0);
            this.FileRightSide.Depth = 0;
            this.FileRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileRightSide.Location = new System.Drawing.Point(160, 0);
            this.FileRightSide.Margin = new System.Windows.Forms.Padding(0);
            this.FileRightSide.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileRightSide.Name = "FileRightSide";
            this.FileRightSide.RowCount = 2;
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileRightSide.Size = new System.Drawing.Size(621, 265);
            this.FileRightSide.TabIndex = 1;
            // 
            // Overview
            // 
            this.Overview.Depth = 0;
            this.Overview.Description = "Campaign description";
            this.Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Overview.Location = new System.Drawing.Point(8, 8);
            this.Overview.Margin = new System.Windows.Forms.Padding(8);
            this.Overview.MouseState = MaterialSkin.MouseState.HOVER;
            this.Overview.Name = "Overview";
            this.Overview.Picture = null;
            this.Overview.ShowPicture = false;
            this.Overview.Size = new System.Drawing.Size(605, 72);
            this.Overview.TabIndex = 0;
            this.Overview.Title = "Campaign title";
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTab.Controls.Add(this.SettingsLayout);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(776, 265);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            // 
            // SettingsLayout
            // 
            this.SettingsLayout.Controls.Add(this.CampaignGamemode);
            this.SettingsLayout.Controls.Add(this.CampaignUnlockStyle);
            this.SettingsLayout.Controls.Add(this.CampaignAuthors);
            this.SettingsLayout.Controls.Add(this.CampaignLogo);
            this.SettingsLayout.Controls.Add(this.CampaignDescription);
            this.SettingsLayout.Controls.Add(this.CampaignName);
            this.SettingsLayout.Depth = 0;
            this.SettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SettingsLayout.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsLayout.Name = "SettingsLayout";
            this.SettingsLayout.Padding = new System.Windows.Forms.Padding(16);
            this.SettingsLayout.Size = new System.Drawing.Size(776, 265);
            this.SettingsLayout.TabIndex = 1;
            // 
            // CampaignGamemode
            // 
            this.CampaignGamemode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignGamemode.Depth = 0;
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
            // CampaignUnlockStyle
            // 
            this.CampaignUnlockStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignUnlockStyle.Depth = 0;
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
            // CampaignAuthors
            // 
            this.CampaignAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignAuthors.Depth = 0;
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
            // CampaignLogo
            // 
            this.CampaignLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignLogo.Depth = 0;
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
            // 
            // CampaignDescription
            // 
            this.CampaignDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignDescription.Depth = 0;
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
            // CampaignName
            // 
            this.CampaignName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignName.Depth = 0;
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
            // LevelsTab
            // 
            this.LevelsTab.BackColor = System.Drawing.Color.White;
            this.LevelsTab.Controls.Add(this.LevelsLayout);
            this.LevelsTab.Location = new System.Drawing.Point(4, 22);
            this.LevelsTab.Margin = new System.Windows.Forms.Padding(0);
            this.LevelsTab.Name = "LevelsTab";
            this.LevelsTab.Size = new System.Drawing.Size(776, 265);
            this.LevelsTab.TabIndex = 1;
            this.LevelsTab.Text = "Levels";
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
            this.Levels.Size = new System.Drawing.Size(616, 265);
            this.Levels.TabIndex = 0;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.Levels_SelectedIndexChanged);
            this.Levels.DoubleClick += new System.EventHandler(this.Levels_DoubleClick);
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
            // AddonsTab
            // 
            this.AddonsTab.Location = new System.Drawing.Point(4, 22);
            this.AddonsTab.Margin = new System.Windows.Forms.Padding(0);
            this.AddonsTab.Name = "AddonsTab";
            this.AddonsTab.Size = new System.Drawing.Size(776, 265);
            this.AddonsTab.TabIndex = 2;
            this.AddonsTab.Text = "Addons";
            this.AddonsTab.UseVisualStyleBackColor = true;
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
            // LevelsLayout
            // 
            this.LevelsLayout.ColumnCount = 2;
            this.LevelsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.LevelsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LevelsLayout.Controls.Add(this.Levels, 1, 0);
            this.LevelsLayout.Controls.Add(this.materialPanel1, 0, 0);
            this.LevelsLayout.Depth = 0;
            this.LevelsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsLayout.Location = new System.Drawing.Point(0, 0);
            this.LevelsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelsLayout.Name = "LevelsLayout";
            this.LevelsLayout.RowCount = 1;
            this.LevelsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LevelsLayout.Size = new System.Drawing.Size(776, 265);
            this.LevelsLayout.TabIndex = 1;
            // 
            // materialPanel1
            // 
            this.materialPanel1.Controls.Add(this.RemoveLevelBtn);
            this.materialPanel1.Controls.Add(this.EditLevelBtn);
            this.materialPanel1.Controls.Add(this.AddLevelBtn);
            this.materialPanel1.Controls.Add(this.materialDivider1);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel1.Location = new System.Drawing.Point(0, 0);
            this.materialPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(160, 265);
            this.materialPanel1.TabIndex = 0;
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
            this.materialDivider1.Size = new System.Drawing.Size(1, 265);
            this.materialDivider1.TabIndex = 5;
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
            this.Size = new System.Drawing.Size(784, 328);
            this.EditorLayout.ResumeLayout(false);
            this.TabPages.ResumeLayout(false);
            this.FileTab.ResumeLayout(false);
            this.FileLayout.ResumeLayout(false);
            this.FileLayout.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.FileRightSide.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsLayout.ResumeLayout(false);
            this.LevelsTab.ResumeLayout(false);
            this.LevelsMenu.ResumeLayout(false);
            this.LevelsLayout.ResumeLayout(false);
            this.materialPanel1.ResumeLayout(false);
            this.materialPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialTableLayoutPanel EditorLayout;
        private MaterialSkin.Controls.MaterialTabControl TabPages;
        private System.Windows.Forms.TabPage SettingsTab;
        private MaterialPanel SettingsLayout;
        private MaterialDropDown CampaignGamemode;
        private MaterialDropDown CampaignUnlockStyle;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignAuthors;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignLogo;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignName;
        private System.Windows.Forms.TabPage LevelsTab;
        private System.Windows.Forms.TabPage AddonsTab;
        private System.Windows.Forms.TabPage FileTab;
        private MaterialTableLayoutPanel FileLayout;
        private MaterialPanel ActionsPanel;
        private MaterialSkin.Controls.MaterialFlatButton CloseBtn;
        private MaterialSkin.Controls.MaterialFlatButton PackBtn;
        private MaterialSkin.Controls.MaterialFlatButton SaveBtn;
        private MaterialSkin.Controls.MaterialFlatButton OpenBtn;
        private MaterialSkin.Controls.MaterialFlatButton NewBtn;
        private MaterialSkin.Controls.MaterialDivider MenuDivider;
        private MaterialSkin.Controls.MaterialDivider TabDivider;
        private MaterialTableLayoutPanel FileRightSide;
        private Controls.PizzaCard Overview;
        private MaterialContextMenuStrip LevelsMenu;
        private System.Windows.Forms.ToolStripMenuItem AddLevel;
        private System.Windows.Forms.ToolStripMenuItem EditLevel;
        private System.Windows.Forms.ToolStripMenuItem RemoveLevel;
        private MaterialFlatButton FolderBtn;
        private MaterialFlatButton ImportBtn;
        private MaterialTableLayoutPanel LevelsLayout;
        private MaterialPanel materialPanel1;
        private MaterialFlatButton RemoveLevelBtn;
        private MaterialFlatButton EditLevelBtn;
        private MaterialFlatButton AddLevelBtn;
        private MaterialDivider materialDivider1;
        public LevelBox Levels;
    }
}
