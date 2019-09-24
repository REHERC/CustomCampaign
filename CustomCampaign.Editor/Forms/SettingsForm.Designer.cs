namespace CustomCampaign.Editor.Forms
{
    partial class SettingsForm
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
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.AppearanceTab = new System.Windows.Forms.TabPage();
            this.AppearanceSettingsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.DarkMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.ThemeLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeList = new MaterialDropDown();
            this.DarkModeLbl = new MaterialSkin.Controls.MaterialLabel();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.CloseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.Tabs.SuspendLayout();
            this.AppearanceTab.SuspendLayout();
            this.AppearanceSettingsLayout.SuspendLayout();
            this.BottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.Tabs;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(108, 0);
            this.TabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Primary = true;
            this.TabSelector.Size = new System.Drawing.Size(524, 40);
            this.TabSelector.TabIndex = 0;
            this.TabSelector.Text = "Settings";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AppearanceTab);
            this.Tabs.Depth = 0;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(8, 40);
            this.Tabs.Margin = new System.Windows.Forms.Padding(0);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(624, 267);
            this.Tabs.TabIndex = 1;
            // 
            // AppearanceTab
            // 
            this.AppearanceTab.Controls.Add(this.AppearanceSettingsLayout);
            this.AppearanceTab.Location = new System.Drawing.Point(4, 22);
            this.AppearanceTab.Margin = new System.Windows.Forms.Padding(0);
            this.AppearanceTab.Name = "AppearanceTab";
            this.AppearanceTab.Padding = new System.Windows.Forms.Padding(8);
            this.AppearanceTab.Size = new System.Drawing.Size(616, 241);
            this.AppearanceTab.TabIndex = 0;
            this.AppearanceTab.Text = "Appearance";
            this.AppearanceTab.UseVisualStyleBackColor = true;
            // 
            // AppearanceSettingsLayout
            // 
            this.AppearanceSettingsLayout.ColumnCount = 2;
            this.AppearanceSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AppearanceSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AppearanceSettingsLayout.Controls.Add(this.DarkMode, 1, 0);
            this.AppearanceSettingsLayout.Controls.Add(this.ThemeLbl, 0, 1);
            this.AppearanceSettingsLayout.Controls.Add(this.ThemeList, 1, 1);
            this.AppearanceSettingsLayout.Controls.Add(this.DarkModeLbl, 0, 0);
            this.AppearanceSettingsLayout.Depth = 0;
            this.AppearanceSettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppearanceSettingsLayout.Location = new System.Drawing.Point(8, 8);
            this.AppearanceSettingsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.AppearanceSettingsLayout.Name = "AppearanceSettingsLayout";
            this.AppearanceSettingsLayout.RowCount = 3;
            this.AppearanceSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AppearanceSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AppearanceSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AppearanceSettingsLayout.Size = new System.Drawing.Size(600, 225);
            this.AppearanceSettingsLayout.TabIndex = 0;
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.Depth = 0;
            this.DarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DarkMode.Font = new System.Drawing.Font("Roboto", 11F);
            this.DarkMode.Location = new System.Drawing.Point(82, 0);
            this.DarkMode.Margin = new System.Windows.Forms.Padding(0);
            this.DarkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Ripple = true;
            this.DarkMode.Size = new System.Drawing.Size(518, 30);
            this.DarkMode.TabIndex = 0;
            this.DarkMode.UseVisualStyleBackColor = true;
            this.DarkMode.CheckedChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
            // 
            // ThemeLbl
            // 
            this.ThemeLbl.AutoSize = true;
            this.ThemeLbl.Depth = 0;
            this.ThemeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.ThemeLbl.FontSize = 11;
            this.ThemeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThemeLbl.FormLabel = false;
            this.ThemeLbl.Location = new System.Drawing.Point(0, 30);
            this.ThemeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLbl.Name = "ThemeLbl";
            this.ThemeLbl.Size = new System.Drawing.Size(82, 21);
            this.ThemeLbl.TabIndex = 1;
            this.ThemeLbl.Text = "Theme";
            // 
            // ThemeList
            // 
            this.ThemeList.Depth = 0;
            this.ThemeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ThemeList.DropDownHeight = 170;
            this.ThemeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeList.FormattingEnabled = true;
            this.ThemeList.Hint = null;
            this.ThemeList.IntegralHeight = false;
            this.ThemeList.Location = new System.Drawing.Point(90, 30);
            this.ThemeList.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ThemeList.MouseState = MaterialSkin.MouseState.OUT;
            this.ThemeList.Name = "ThemeList";
            this.ThemeList.Size = new System.Drawing.Size(510, 21);
            this.ThemeList.TabIndex = 2;
            this.ThemeList.SelectedIndexChanged += new System.EventHandler(this.ThemeList_SelectedIndexChanged);
            // 
            // DarkModeLbl
            // 
            this.DarkModeLbl.AutoSize = true;
            this.DarkModeLbl.Depth = 0;
            this.DarkModeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DarkModeLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.DarkModeLbl.FontSize = 11;
            this.DarkModeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DarkModeLbl.FormLabel = false;
            this.DarkModeLbl.Location = new System.Drawing.Point(0, 5);
            this.DarkModeLbl.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DarkModeLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkModeLbl.Name = "DarkModeLbl";
            this.DarkModeLbl.Size = new System.Drawing.Size(82, 25);
            this.DarkModeLbl.TabIndex = 1;
            this.DarkModeLbl.Text = "Dark mode";
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Divider.Location = new System.Drawing.Point(8, 307);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(624, 1);
            this.Divider.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.Depth = 0;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.Icon = null;
            this.CloseBtn.Location = new System.Drawing.Point(561, 8);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Primary = false;
            this.CloseBtn.Size = new System.Drawing.Size(63, 36);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.CloseBtn);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(8, 308);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BottomActions.Size = new System.Drawing.Size(624, 44);
            this.BottomActions.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.BottomActions);
            this.Controls.Add(this.TabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(8, 40, 8, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Title = "Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.Tabs.ResumeLayout(false);
            this.AppearanceTab.ResumeLayout(false);
            this.AppearanceSettingsLayout.ResumeLayout(false);
            this.AppearanceSettingsLayout.PerformLayout();
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage AppearanceTab;
        private MaterialSkin.Controls.MaterialTableLayoutPanel AppearanceSettingsLayout;
        private MaterialSkin.Controls.MaterialCheckBox DarkMode;
        private MaterialSkin.Controls.MaterialLabel ThemeLbl;
        private MaterialDropDown ThemeList;
        private MaterialSkin.Controls.MaterialLabel DarkModeLbl;
        private MaterialSkin.Controls.MaterialDivider Divider;
        private MaterialSkin.Controls.MaterialFlatButton CloseBtn;
        private MaterialSkin.Controls.MaterialPanel BottomActions;
    }
}