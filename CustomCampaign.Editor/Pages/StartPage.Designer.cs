using MaterialSkin.Controls;

namespace CustomCampaign.Editor.Pages
{
    partial class StartPage
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
            this.VersionBox = new MaterialSkin.Controls.MaterialPanel();
            this.VersionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SecretMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.secretSpookButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.RecentLbl = new MaterialSkin.Controls.MaterialLabel();
            this.RecentList = new MaterialSkin.Controls.MaterialPanel();
            this.BtnLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ImportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TutorialsBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NewBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OpenBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GetStartedLbl = new MaterialSkin.Controls.MaterialLabel();
            this.VersionBox.SuspendLayout();
            this.SecretMenu.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.BtnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionBox
            // 
            this.VersionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionBox.Controls.Add(this.VersionLbl);
            this.VersionBox.Depth = 0;
            this.VersionBox.Location = new System.Drawing.Point(14, 296);
            this.VersionBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(756, 19);
            this.VersionBox.TabIndex = 8;
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.ContextMenuStrip = this.SecretMenu;
            this.VersionLbl.Depth = 0;
            this.VersionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.VersionLbl.FontSize = 11;
            this.VersionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VersionLbl.Location = new System.Drawing.Point(0, 0);
            this.VersionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(269, 19);
            this.VersionLbl.TabIndex = 4;
            this.VersionLbl.Text = "Campaign creation toolkit for Distance";
            // 
            // SecretMenu
            // 
            this.SecretMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SecretMenu.Depth = 0;
            this.SecretMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secretSpookButtonToolStripMenuItem});
            this.SecretMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.SecretMenu.Name = "SecretMenu";
            this.SecretMenu.Size = new System.Drawing.Size(182, 26);
            // 
            // secretSpookButtonToolStripMenuItem
            // 
            this.secretSpookButtonToolStripMenuItem.Name = "secretSpookButtonToolStripMenuItem";
            this.secretSpookButtonToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.secretSpookButtonToolStripMenuItem.Text = "Secret Spook Button";
            this.secretSpookButtonToolStripMenuItem.Click += new System.EventHandler(this.SecretSpookButtonToolStripMenuItem_Click);
            // 
            // MainLayout
            // 
            this.MainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.RecentLbl, 0, 0);
            this.MainLayout.Controls.Add(this.RecentList, 0, 1);
            this.MainLayout.Depth = 0;
            this.MainLayout.Location = new System.Drawing.Point(230, 14);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(8);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(540, 271);
            this.MainLayout.TabIndex = 7;
            // 
            // RecentLbl
            // 
            this.RecentLbl.AutoSize = true;
            this.RecentLbl.Depth = 0;
            this.RecentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.RecentLbl.FontSize = 11;
            this.RecentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RecentLbl.Location = new System.Drawing.Point(3, 0);
            this.RecentLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecentLbl.Name = "RecentLbl";
            this.RecentLbl.Size = new System.Drawing.Size(534, 24);
            this.RecentLbl.TabIndex = 2;
            this.RecentLbl.Text = "RECENT FILES";
            // 
            // RecentList
            // 
            this.RecentList.Depth = 0;
            this.RecentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentList.Location = new System.Drawing.Point(0, 24);
            this.RecentList.Margin = new System.Windows.Forms.Padding(0);
            this.RecentList.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecentList.Name = "RecentList";
            this.RecentList.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.RecentList.Size = new System.Drawing.Size(540, 247);
            this.RecentList.TabIndex = 3;
            // 
            // BtnLayout
            // 
            this.BtnLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLayout.AutoSize = true;
            this.BtnLayout.ColumnCount = 1;
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnLayout.Controls.Add(this.ImportBtn, 0, 3);
            this.BtnLayout.Controls.Add(this.TutorialsBtn, 0, 5);
            this.BtnLayout.Controls.Add(this.NewBtn, 0, 1);
            this.BtnLayout.Controls.Add(this.OpenBtn, 0, 2);
            this.BtnLayout.Controls.Add(this.GetStartedLbl, 0, 0);
            this.BtnLayout.Depth = 0;
            this.BtnLayout.Location = new System.Drawing.Point(14, 14);
            this.BtnLayout.Margin = new System.Windows.Forms.Padding(8);
            this.BtnLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLayout.Name = "BtnLayout";
            this.BtnLayout.RowCount = 6;
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BtnLayout.Size = new System.Drawing.Size(200, 180);
            this.BtnLayout.TabIndex = 6;
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.Depth = 0;
            this.ImportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBtn.Header = true;
            this.ImportBtn.Icon = null;
            this.ImportBtn.Location = new System.Drawing.Point(4, 88);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Primary = true;
            this.ImportBtn.Size = new System.Drawing.Size(192, 28);
            this.ImportBtn.TabIndex = 4;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // TutorialsBtn
            // 
            this.TutorialsBtn.AutoSize = true;
            this.TutorialsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TutorialsBtn.Depth = 0;
            this.TutorialsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TutorialsBtn.Enabled = false;
            this.TutorialsBtn.Icon = null;
            this.TutorialsBtn.Location = new System.Drawing.Point(4, 144);
            this.TutorialsBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
            this.TutorialsBtn.MaximumSize = new System.Drawing.Size(0, 28);
            this.TutorialsBtn.MinimumSize = new System.Drawing.Size(0, 28);
            this.TutorialsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TutorialsBtn.Name = "TutorialsBtn";
            this.TutorialsBtn.Primary = false;
            this.TutorialsBtn.Size = new System.Drawing.Size(192, 28);
            this.TutorialsBtn.TabIndex = 7;
            this.TutorialsBtn.Text = "Online Tutorials";
            this.TutorialsBtn.UseVisualStyleBackColor = true;
            this.TutorialsBtn.Click += new System.EventHandler(this.TutorialsBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSize = true;
            this.NewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewBtn.Depth = 0;
            this.NewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewBtn.Header = true;
            this.NewBtn.Icon = null;
            this.NewBtn.Location = new System.Drawing.Point(4, 32);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.NewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Primary = true;
            this.NewBtn.Size = new System.Drawing.Size(192, 28);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = true;
            this.OpenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenBtn.Depth = 0;
            this.OpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenBtn.Header = true;
            this.OpenBtn.Icon = null;
            this.OpenBtn.Location = new System.Drawing.Point(4, 60);
            this.OpenBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Primary = true;
            this.OpenBtn.Size = new System.Drawing.Size(192, 28);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // GetStartedLbl
            // 
            this.GetStartedLbl.AutoSize = true;
            this.GetStartedLbl.Depth = 0;
            this.GetStartedLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetStartedLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.GetStartedLbl.FontSize = 11;
            this.GetStartedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GetStartedLbl.Location = new System.Drawing.Point(3, 0);
            this.GetStartedLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetStartedLbl.Name = "GetStartedLbl";
            this.GetStartedLbl.Size = new System.Drawing.Size(194, 24);
            this.GetStartedLbl.TabIndex = 2;
            this.GetStartedLbl.Text = "GET STARTED";
            // 
            // StartPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.BtnLayout);
            this.Name = "StartPage";
            this.PageName = "pages:home";
            this.PageTitle = "Start page";
            this.Size = new System.Drawing.Size(784, 328);
            this.VersionBox.ResumeLayout(false);
            this.VersionBox.PerformLayout();
            this.SecretMenu.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.BtnLayout.ResumeLayout(false);
            this.BtnLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialPanel VersionBox;
        private MaterialSkin.Controls.MaterialLabel VersionLbl;
        private MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialLabel RecentLbl;
        private MaterialPanel RecentList;
        private MaterialTableLayoutPanel BtnLayout;
        private MaterialSkin.Controls.MaterialFlatButton TutorialsBtn;
        private MaterialSkin.Controls.MaterialRaisedButton NewBtn;
        private MaterialSkin.Controls.MaterialRaisedButton OpenBtn;
        private MaterialSkin.Controls.MaterialLabel GetStartedLbl;
        private MaterialRaisedButton ImportBtn;
        private MaterialContextMenuStrip SecretMenu;
        private System.Windows.Forms.ToolStripMenuItem secretSpookButtonToolStripMenuItem;
    }
}
