namespace CustomCampaign.Forms
{
    partial class LevelForm
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SeparatorLight = new System.Windows.Forms.Panel();
            this.SeparatorDark = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingTextLbl = new System.Windows.Forms.Label();
            this.LoadingBackgroundBox = new System.Windows.Forms.TextBox();
            this.LoadingBackgroundLbl = new System.Windows.Forms.Label();
            this.LevelSectorNameLbl = new System.Windows.Forms.Label();
            this.LevelNameLbl = new System.Windows.Forms.Label();
            this.LevelFileLbl = new System.Windows.Forms.Label();
            this.LevelFileBox = new System.Windows.Forms.TextBox();
            this.LevelSectorNameBox = new System.Windows.Forms.TextBox();
            this.LevelNameBox = new System.Windows.Forms.TextBox();
            this.LoadingTextBox = new System.Windows.Forms.TextBox();
            this.Separators = new System.Windows.Forms.Panel();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.Separators.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.OkBtn);
            this.ButtonsPanel.Controls.Add(this.CancelBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 118);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.ButtonsPanel.Size = new System.Drawing.Size(434, 48);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OkBtn.Enabled = false;
            this.OkBtn.Location = new System.Drawing.Point(259, 12);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(80, 24);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(345, 12);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(80, 24);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SeparatorLight
            // 
            this.SeparatorLight.BackColor = System.Drawing.SystemColors.Window;
            this.SeparatorLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorLight.Location = new System.Drawing.Point(0, 1);
            this.SeparatorLight.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.Name = "SeparatorLight";
            this.SeparatorLight.Size = new System.Drawing.Size(434, 1);
            this.SeparatorLight.TabIndex = 1;
            // 
            // SeparatorDark
            // 
            this.SeparatorDark.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SeparatorDark.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorDark.Location = new System.Drawing.Point(0, 0);
            this.SeparatorDark.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.Name = "SeparatorDark";
            this.SeparatorDark.Size = new System.Drawing.Size(434, 1);
            this.SeparatorDark.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainPanel.Size = new System.Drawing.Size(434, 116);
            this.MainPanel.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AutoSize = true;
            this.SettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsPanel.ColumnCount = 2;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Controls.Add(this.LoadingTextBox, 1, 4);
            this.SettingsPanel.Controls.Add(this.LoadingTextLbl, 0, 4);
            this.SettingsPanel.Controls.Add(this.LoadingBackgroundBox, 1, 3);
            this.SettingsPanel.Controls.Add(this.LoadingBackgroundLbl, 0, 3);
            this.SettingsPanel.Controls.Add(this.LevelSectorNameLbl, 0, 2);
            this.SettingsPanel.Controls.Add(this.LevelNameLbl, 0, 1);
            this.SettingsPanel.Controls.Add(this.LevelFileLbl, 0, 0);
            this.SettingsPanel.Controls.Add(this.LevelFileBox, 1, 0);
            this.SettingsPanel.Controls.Add(this.LevelSectorNameBox, 1, 2);
            this.SettingsPanel.Controls.Add(this.LevelNameBox, 1, 1);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(8, 8);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 5;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.Size = new System.Drawing.Size(418, 100);
            this.SettingsPanel.TabIndex = 0;
            // 
            // LoadingTextLbl
            // 
            this.LoadingTextLbl.AutoSize = true;
            this.LoadingTextLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingTextLbl.Location = new System.Drawing.Point(0, 80);
            this.LoadingTextLbl.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingTextLbl.Name = "LoadingTextLbl";
            this.LoadingTextLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadingTextLbl.Size = new System.Drawing.Size(108, 20);
            this.LoadingTextLbl.TabIndex = 7;
            this.LoadingTextLbl.Text = "Loading text:";
            this.LoadingTextLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadingBackgroundBox
            // 
            this.LoadingBackgroundBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingBackgroundBox.Location = new System.Drawing.Point(108, 60);
            this.LoadingBackgroundBox.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingBackgroundBox.Name = "LoadingBackgroundBox";
            this.LoadingBackgroundBox.Size = new System.Drawing.Size(310, 20);
            this.LoadingBackgroundBox.TabIndex = 3;
            // 
            // LoadingBackgroundLbl
            // 
            this.LoadingBackgroundLbl.AutoSize = true;
            this.LoadingBackgroundLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingBackgroundLbl.Location = new System.Drawing.Point(0, 60);
            this.LoadingBackgroundLbl.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingBackgroundLbl.Name = "LoadingBackgroundLbl";
            this.LoadingBackgroundLbl.Size = new System.Drawing.Size(108, 20);
            this.LoadingBackgroundLbl.TabIndex = 6;
            this.LoadingBackgroundLbl.Text = "Loading background:";
            this.LoadingBackgroundLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LevelSectorNameLbl
            // 
            this.LevelSectorNameLbl.AutoSize = true;
            this.LevelSectorNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelSectorNameLbl.Location = new System.Drawing.Point(0, 40);
            this.LevelSectorNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.LevelSectorNameLbl.Name = "LevelSectorNameLbl";
            this.LevelSectorNameLbl.Size = new System.Drawing.Size(108, 20);
            this.LevelSectorNameLbl.TabIndex = 3;
            this.LevelSectorNameLbl.Text = "Level sector name:";
            this.LevelSectorNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LevelNameLbl
            // 
            this.LevelNameLbl.AutoSize = true;
            this.LevelNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelNameLbl.Location = new System.Drawing.Point(0, 20);
            this.LevelNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.LevelNameLbl.Name = "LevelNameLbl";
            this.LevelNameLbl.Size = new System.Drawing.Size(108, 20);
            this.LevelNameLbl.TabIndex = 2;
            this.LevelNameLbl.Text = "Level name:";
            this.LevelNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LevelFileLbl
            // 
            this.LevelFileLbl.AutoSize = true;
            this.LevelFileLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelFileLbl.Location = new System.Drawing.Point(0, 0);
            this.LevelFileLbl.Margin = new System.Windows.Forms.Padding(0);
            this.LevelFileLbl.Name = "LevelFileLbl";
            this.LevelFileLbl.Size = new System.Drawing.Size(108, 20);
            this.LevelFileLbl.TabIndex = 0;
            this.LevelFileLbl.Text = "Level file:";
            this.LevelFileLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LevelFileBox
            // 
            this.LevelFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelFileBox.Location = new System.Drawing.Point(108, 0);
            this.LevelFileBox.Margin = new System.Windows.Forms.Padding(0);
            this.LevelFileBox.Name = "LevelFileBox";
            this.LevelFileBox.Size = new System.Drawing.Size(310, 20);
            this.LevelFileBox.TabIndex = 0;
            this.LevelFileBox.TextChanged += new System.EventHandler(this.LevelFileBox_TextChanged);
            // 
            // LevelSectorNameBox
            // 
            this.LevelSectorNameBox.Location = new System.Drawing.Point(108, 40);
            this.LevelSectorNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.LevelSectorNameBox.Name = "LevelSectorNameBox";
            this.LevelSectorNameBox.Size = new System.Drawing.Size(310, 20);
            this.LevelSectorNameBox.TabIndex = 2;
            // 
            // LevelNameBox
            // 
            this.LevelNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelNameBox.Location = new System.Drawing.Point(108, 20);
            this.LevelNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.LevelNameBox.Name = "LevelNameBox";
            this.LevelNameBox.Size = new System.Drawing.Size(310, 20);
            this.LevelNameBox.TabIndex = 1;
            // 
            // LoadingTextBox
            // 
            this.LoadingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingTextBox.Location = new System.Drawing.Point(108, 80);
            this.LoadingTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingTextBox.Name = "LoadingTextBox";
            this.LoadingTextBox.Size = new System.Drawing.Size(310, 20);
            this.LoadingTextBox.TabIndex = 8;
            // 
            // Separators
            // 
            this.Separators.AutoSize = true;
            this.Separators.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Separators.Controls.Add(this.SeparatorLight);
            this.Separators.Controls.Add(this.SeparatorDark);
            this.Separators.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separators.Location = new System.Drawing.Point(0, 116);
            this.Separators.Name = "Separators";
            this.Separators.Size = new System.Drawing.Size(434, 2);
            this.Separators.TabIndex = 3;
            // 
            // MainContainer
            // 
            this.MainContainer.AutoSize = true;
            this.MainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainContainer.Controls.Add(this.ButtonsPanel);
            this.MainContainer.Controls.Add(this.Separators);
            this.MainContainer.Controls.Add(this.MainPanel);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(434, 166);
            this.MainContainer.TabIndex = 4;
            // 
            // LevelForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(434, 166);
            this.Controls.Add(this.MainContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 0);
            this.Name = "LevelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LevelForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.Separators.ResumeLayout(false);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel SeparatorLight;
        private System.Windows.Forms.Panel SeparatorDark;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label LevelSectorNameLbl;
        private System.Windows.Forms.Label LevelNameLbl;
        private System.Windows.Forms.Label LevelFileLbl;
        private System.Windows.Forms.TextBox LevelFileBox;
        private System.Windows.Forms.TextBox LevelNameBox;
        private System.Windows.Forms.TextBox LoadingBackgroundBox;
        private System.Windows.Forms.Label LoadingBackgroundLbl;
        private System.Windows.Forms.TextBox LevelSectorNameBox;
        private System.Windows.Forms.Label LoadingTextLbl;
        private System.Windows.Forms.TextBox LoadingTextBox;
        private System.Windows.Forms.Panel Separators;
        private System.Windows.Forms.Panel MainContainer;
    }
}