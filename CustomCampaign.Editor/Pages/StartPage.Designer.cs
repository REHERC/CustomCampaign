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
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.RecentLbl = new MaterialSkin.Controls.MaterialLabel();
            this.RecentList = new MaterialSkin.Controls.MaterialPanel();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.TutorialsBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NewBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OpenBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GetStartedLbl = new MaterialSkin.Controls.MaterialLabel();
            this.VersionBox.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.RecentList.SuspendLayout();
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
            this.RecentList.Controls.Add(this.materialFlatButton8);
            this.RecentList.Controls.Add(this.materialFlatButton7);
            this.RecentList.Controls.Add(this.materialFlatButton6);
            this.RecentList.Controls.Add(this.materialFlatButton5);
            this.RecentList.Controls.Add(this.materialFlatButton4);
            this.RecentList.Controls.Add(this.materialFlatButton3);
            this.RecentList.Controls.Add(this.materialFlatButton2);
            this.RecentList.Controls.Add(this.materialFlatButton1);
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
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton8.Icon = null;
            this.materialFlatButton8.Location = new System.Drawing.Point(4, 204);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton8.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton8.TabIndex = 7;
            this.materialFlatButton8.Text = "RECENT ITEM #8";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(4, 176);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton7.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton7.TabIndex = 6;
            this.materialFlatButton7.Text = "RECENT ITEM #7";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(4, 148);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton6.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton6.TabIndex = 5;
            this.materialFlatButton6.Text = "RECENT ITEM #6";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(4, 120);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton5.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton5.TabIndex = 4;
            this.materialFlatButton5.Text = "RECENT ITEM #5";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(4, 92);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton4.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "RECENT ITEM #4";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(4, 64);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton3.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "RECENT ITEM #3";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(4, 36);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton2.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "RECENT ITEM #2";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(4, 8);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MaximumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(0, 28);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(532, 28);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "RECENT ITEM #1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLayout
            // 
            this.BtnLayout.ColumnCount = 1;
            this.BtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnLayout.Controls.Add(this.TutorialsBtn, 0, 4);
            this.BtnLayout.Controls.Add(this.NewBtn, 0, 1);
            this.BtnLayout.Controls.Add(this.OpenBtn, 0, 2);
            this.BtnLayout.Controls.Add(this.GetStartedLbl, 0, 0);
            this.BtnLayout.Depth = 0;
            this.BtnLayout.Location = new System.Drawing.Point(14, 14);
            this.BtnLayout.Margin = new System.Windows.Forms.Padding(8);
            this.BtnLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLayout.Name = "BtnLayout";
            this.BtnLayout.RowCount = 5;
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.BtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.BtnLayout.Size = new System.Drawing.Size(200, 152);
            this.BtnLayout.TabIndex = 6;
            // 
            // TutorialsBtn
            // 
            this.TutorialsBtn.AutoSize = true;
            this.TutorialsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TutorialsBtn.Depth = 0;
            this.TutorialsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TutorialsBtn.Icon = null;
            this.TutorialsBtn.Location = new System.Drawing.Point(4, 116);
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
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.RecentList.ResumeLayout(false);
            this.RecentList.PerformLayout();
            this.BtnLayout.ResumeLayout(false);
            this.BtnLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanel VersionBox;
        private MaterialSkin.Controls.MaterialLabel VersionLbl;
        private MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialLabel RecentLbl;
        private MaterialPanel RecentList;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialTableLayoutPanel BtnLayout;
        private MaterialSkin.Controls.MaterialFlatButton TutorialsBtn;
        private MaterialSkin.Controls.MaterialRaisedButton NewBtn;
        private MaterialSkin.Controls.MaterialRaisedButton OpenBtn;
        private MaterialSkin.Controls.MaterialLabel GetStartedLbl;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
    }
}
