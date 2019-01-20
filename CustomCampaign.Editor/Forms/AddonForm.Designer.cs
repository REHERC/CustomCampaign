namespace CustomCampaign.Forms
{
    partial class AddonForm
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
            this.AddonFileLbl = new System.Windows.Forms.Label();
            this.AddonFileBox = new System.Windows.Forms.TextBox();
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.OkBtn);
            this.ButtonsPanel.Controls.Add(this.CancelBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 94);
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
            this.SeparatorLight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorLight.Location = new System.Drawing.Point(0, 93);
            this.SeparatorLight.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.Name = "SeparatorLight";
            this.SeparatorLight.Size = new System.Drawing.Size(434, 1);
            this.SeparatorLight.TabIndex = 1;
            // 
            // SeparatorDark
            // 
            this.SeparatorDark.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SeparatorDark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorDark.Location = new System.Drawing.Point(0, 92);
            this.SeparatorDark.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.Name = "SeparatorDark";
            this.SeparatorDark.Size = new System.Drawing.Size(434, 1);
            this.SeparatorDark.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainPanel.Size = new System.Drawing.Size(434, 92);
            this.MainPanel.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.ColumnCount = 2;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Controls.Add(this.AddonFileLbl, 0, 0);
            this.SettingsPanel.Controls.Add(this.AddonFileBox, 1, 0);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(8, 8);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 4;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Size = new System.Drawing.Size(418, 76);
            this.SettingsPanel.TabIndex = 0;
            // 
            // AddonFileLbl
            // 
            this.AddonFileLbl.AutoSize = true;
            this.AddonFileLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddonFileLbl.Location = new System.Drawing.Point(0, 0);
            this.AddonFileLbl.Margin = new System.Windows.Forms.Padding(0);
            this.AddonFileLbl.Name = "AddonFileLbl";
            this.AddonFileLbl.Size = new System.Drawing.Size(66, 20);
            this.AddonFileLbl.TabIndex = 0;
            this.AddonFileLbl.Text = "Manifest file:";
            this.AddonFileLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddonFileBox
            // 
            this.AddonFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddonFileBox.Location = new System.Drawing.Point(66, 0);
            this.AddonFileBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddonFileBox.Name = "AddonFileBox";
            this.AddonFileBox.Size = new System.Drawing.Size(352, 20);
            this.AddonFileBox.TabIndex = 0;
            this.AddonFileBox.TextChanged += new System.EventHandler(this.LevelFileBox_TextChanged);
            // 
            // AddonForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(434, 142);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SeparatorDark);
            this.Controls.Add(this.SeparatorLight);
            this.Controls.Add(this.ButtonsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddonForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ButtonsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel SeparatorLight;
        private System.Windows.Forms.Panel SeparatorDark;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label AddonFileLbl;
        private System.Windows.Forms.TextBox AddonFileBox;
    }
}