using MaterialSkin.Controls;

namespace CustomCampaign.Editor.Forms
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
            this.MainPanel = new MaterialSkin.Controls.MaterialPanel();
            this.BugReportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SettingsBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 40);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(834, 360);
            this.MainPanel.TabIndex = 3;
            // 
            // BugReportBtn
            // 
            this.BugReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BugReportBtn.AutoSize = true;
            this.BugReportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BugReportBtn.Depth = 0;
            this.BugReportBtn.Header = true;
            this.BugReportBtn.Icon = null;
            this.BugReportBtn.Location = new System.Drawing.Point(632, 2);
            this.BugReportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BugReportBtn.Name = "BugReportBtn";
            this.BugReportBtn.Primary = true;
            this.BugReportBtn.Size = new System.Drawing.Size(103, 36);
            this.BugReportBtn.TabIndex = 4;
            this.BugReportBtn.Text = "BUG REPORT";
            this.BugReportBtn.UseVisualStyleBackColor = true;
            this.BugReportBtn.Click += new System.EventHandler(this.BugReportBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBtn.AutoSize = true;
            this.SettingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsBtn.Depth = 0;
            this.SettingsBtn.Header = true;
            this.SettingsBtn.Icon = null;
            this.SettingsBtn.Location = new System.Drawing.Point(741, 2);
            this.SettingsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Primary = true;
            this.SettingsBtn.Size = new System.Drawing.Size(85, 36);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.Text = "SETTINGS";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(834, 400);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.BugReportBtn);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialPanel MainPanel;
        private MaterialSkin.Controls.MaterialRaisedButton BugReportBtn;
        private MaterialSkin.Controls.MaterialRaisedButton SettingsBtn;
    }
}