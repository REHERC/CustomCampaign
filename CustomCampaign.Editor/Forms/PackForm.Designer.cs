namespace CustomCampaign.Forms
{
    partial class PackForm
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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SeparatorLight = new System.Windows.Forms.Panel();
            this.SeparatorDark = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LevelsBox = new ReorderableListView();
            this.FileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.RefreshBtn);
            this.ButtonsPanel.Controls.Add(this.ExportBtn);
            this.ButtonsPanel.Controls.Add(this.CancelBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 214);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.ButtonsPanel.Size = new System.Drawing.Size(584, 48);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RefreshBtn.Location = new System.Drawing.Point(9, 12);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(80, 24);
            this.RefreshBtn.TabIndex = 6;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExportBtn.Location = new System.Drawing.Point(389, 12);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(100, 24);
            this.ExportBtn.TabIndex = 4;
            this.ExportBtn.Text = "Export as ZIP file";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(495, 12);
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
            this.SeparatorLight.Location = new System.Drawing.Point(0, 213);
            this.SeparatorLight.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorLight.Name = "SeparatorLight";
            this.SeparatorLight.Size = new System.Drawing.Size(584, 1);
            this.SeparatorLight.TabIndex = 3;
            // 
            // SeparatorDark
            // 
            this.SeparatorDark.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SeparatorDark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorDark.Location = new System.Drawing.Point(0, 212);
            this.SeparatorDark.MaximumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.MinimumSize = new System.Drawing.Size(0, 1);
            this.SeparatorDark.Name = "SeparatorDark";
            this.SeparatorDark.Size = new System.Drawing.Size(584, 1);
            this.SeparatorDark.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.LevelsBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(584, 212);
            this.MainPanel.TabIndex = 5;
            // 
            // LevelsBox
            // 
            this.LevelsBox.AllowDrop = true;
            this.LevelsBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileColumn,
            this.StatusColumn});
            this.LevelsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsBox.FullRowSelect = true;
            this.LevelsBox.GridLines = true;
            this.LevelsBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LevelsBox.LineAfter = -1;
            this.LevelsBox.LineBefore = -1;
            this.LevelsBox.Location = new System.Drawing.Point(0, 0);
            this.LevelsBox.MultiSelect = false;
            this.LevelsBox.Name = "LevelsBox";
            this.LevelsBox.Size = new System.Drawing.Size(584, 212);
            this.LevelsBox.TabIndex = 1;
            this.LevelsBox.UseCompatibleStateImageBehavior = false;
            this.LevelsBox.View = System.Windows.Forms.View.Details;
            // 
            // FileColumn
            // 
            this.FileColumn.Text = "File";
            this.FileColumn.Width = 450;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 100;
            // 
            // PackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SeparatorDark);
            this.Controls.Add(this.SeparatorLight);
            this.Controls.Add(this.ButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Campaign Authoring Tool - Campaign packaging";
            this.Load += new System.EventHandler(this.PackForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel SeparatorLight;
        private System.Windows.Forms.Panel SeparatorDark;
        private System.Windows.Forms.Panel MainPanel;
        private ReorderableListView LevelsBox;
        private System.Windows.Forms.ColumnHeader FileColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}