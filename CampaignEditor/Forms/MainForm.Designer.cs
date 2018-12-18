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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CampaignDescriptionContainer = new System.Windows.Forms.Panel();
            this.CampaignDescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampaignNameLbl = new System.Windows.Forms.Label();
            this.CampaignNameBox = new System.Windows.Forms.TextBox();
            this.LevelsTab = new System.Windows.Forms.TabPage();
            this.LevelsBox = new System.Windows.Forms.ListView();
            this.LevelsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addANewLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLevelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsMenuBar = new System.Windows.Forms.ToolStrip();
            this.Status = new System.Windows.Forms.ToolStripLabel();
            this.MenuBar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.EditorTabs.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.CampaignDescriptionContainer.SuspendLayout();
            this.LevelsTab.SuspendLayout();
            this.LevelsContextMenu.SuspendLayout();
            this.levelsMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.OpenBtn,
            this.SaveBtn,
            this.SaveAsBtn});
            this.MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(784, 41);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "Menu";
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.NewBtn.ForeColor = System.Drawing.Color.White;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(43, 38);
            this.NewBtn.Text = "&New";
            this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(50, 38);
            this.OpenBtn.Text = "&Open";
            this.OpenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(48, 38);
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.SaveAsBtn.ForeColor = System.Drawing.Color.White;
            this.SaveAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsBtn.Image")));
            this.SaveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(69, 38);
            this.SaveAsBtn.Text = "Save as";
            this.SaveAsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EditorTabs);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 521);
            this.MainPanel.TabIndex = 1;
            // 
            // EditorTabs
            // 
            this.EditorTabs.Controls.Add(this.SettingsTab);
            this.EditorTabs.Controls.Add(this.LevelsTab);
            this.EditorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorTabs.Location = new System.Drawing.Point(0, 0);
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(784, 521);
            this.EditorTabs.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.AutoScroll = true;
            this.SettingsTab.BackColor = System.Drawing.Color.Gray;
            this.SettingsTab.Controls.Add(this.SettingsPanel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(776, 488);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Campaign settings";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.SettingsPanel.ColumnCount = 2;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Controls.Add(this.CampaignDescriptionContainer, 1, 1);
            this.SettingsPanel.Controls.Add(this.label1, 0, 1);
            this.SettingsPanel.Controls.Add(this.CampaignNameLbl, 0, 0);
            this.SettingsPanel.Controls.Add(this.CampaignNameBox, 1, 0);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 2;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.Size = new System.Drawing.Size(770, 482);
            this.SettingsPanel.TabIndex = 0;
            // 
            // CampaignDescriptionContainer
            // 
            this.CampaignDescriptionContainer.AutoSize = true;
            this.CampaignDescriptionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CampaignDescriptionContainer.Controls.Add(this.CampaignDescriptionBox);
            this.CampaignDescriptionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionContainer.Location = new System.Drawing.Point(152, 23);
            this.CampaignDescriptionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionContainer.MaximumSize = new System.Drawing.Size(0, 23);
            this.CampaignDescriptionContainer.MinimumSize = new System.Drawing.Size(0, 23);
            this.CampaignDescriptionContainer.Name = "CampaignDescriptionContainer";
            this.CampaignDescriptionContainer.Size = new System.Drawing.Size(618, 23);
            this.CampaignDescriptionContainer.TabIndex = 2;
            // 
            // CampaignDescriptionBox
            // 
            this.CampaignDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampaignDescriptionBox.Location = new System.Drawing.Point(0, 0);
            this.CampaignDescriptionBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignDescriptionBox.Name = "CampaignDescriptionBox";
            this.CampaignDescriptionBox.Size = new System.Drawing.Size(618, 23);
            this.CampaignDescriptionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 459);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign description :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameLbl
            // 
            this.CampaignNameLbl.AutoSize = true;
            this.CampaignNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampaignNameLbl.ForeColor = System.Drawing.Color.White;
            this.CampaignNameLbl.Location = new System.Drawing.Point(0, 0);
            this.CampaignNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameLbl.Name = "CampaignNameLbl";
            this.CampaignNameLbl.Size = new System.Drawing.Size(152, 23);
            this.CampaignNameLbl.TabIndex = 0;
            this.CampaignNameLbl.Text = "Campaign name :";
            this.CampaignNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampaignNameBox
            // 
            this.CampaignNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampaignNameBox.Location = new System.Drawing.Point(152, 0);
            this.CampaignNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.CampaignNameBox.Name = "CampaignNameBox";
            this.CampaignNameBox.Size = new System.Drawing.Size(618, 23);
            this.CampaignNameBox.TabIndex = 1;
            // 
            // LevelsTab
            // 
            this.LevelsTab.Controls.Add(this.LevelsBox);
            this.LevelsTab.Controls.Add(this.levelsMenuBar);
            this.LevelsTab.Location = new System.Drawing.Point(4, 29);
            this.LevelsTab.Name = "LevelsTab";
            this.LevelsTab.Size = new System.Drawing.Size(776, 488);
            this.LevelsTab.TabIndex = 1;
            this.LevelsTab.Text = "Levels";
            this.LevelsTab.UseVisualStyleBackColor = true;
            // 
            // LevelsBox
            // 
            this.LevelsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.LevelsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LevelsBox.ContextMenuStrip = this.LevelsContextMenu;
            this.LevelsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsBox.Location = new System.Drawing.Point(0, 0);
            this.LevelsBox.Name = "LevelsBox";
            this.LevelsBox.Size = new System.Drawing.Size(776, 463);
            this.LevelsBox.TabIndex = 0;
            this.LevelsBox.UseCompatibleStateImageBehavior = false;
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
            // 
            // addANewLevelToolStripMenuItem
            // 
            this.addANewLevelToolStripMenuItem.Name = "addANewLevelToolStripMenuItem";
            this.addANewLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addANewLevelToolStripMenuItem.Text = "Add";
            // 
            // editLevelInfoToolStripMenuItem
            // 
            this.editLevelInfoToolStripMenuItem.Name = "editLevelInfoToolStripMenuItem";
            this.editLevelInfoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editLevelInfoToolStripMenuItem.Text = "Edit";
            // 
            // removeLevelToolStripMenuItem
            // 
            this.removeLevelToolStripMenuItem.Name = "removeLevelToolStripMenuItem";
            this.removeLevelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeLevelToolStripMenuItem.Text = "Remove";
            // 
            // levelsMenuBar
            // 
            this.levelsMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(86)))));
            this.levelsMenuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.levelsMenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.levelsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.levelsMenuBar.Location = new System.Drawing.Point(0, 463);
            this.levelsMenuBar.Name = "levelsMenuBar";
            this.levelsMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.levelsMenuBar.Size = new System.Drawing.Size(776, 25);
            this.levelsMenuBar.TabIndex = 1;
            this.levelsMenuBar.Text = "Menu";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(609, 22);
            this.Status.Text = "Right-click to add a level, modify it\'s info or to remove one. Use drag and drop " +
    "to re-order them.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Campaign Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.EditorTabs.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.CampaignDescriptionContainer.ResumeLayout(false);
            this.CampaignDescriptionContainer.PerformLayout();
            this.LevelsTab.ResumeLayout(false);
            this.LevelsTab.PerformLayout();
            this.LevelsContextMenu.ResumeLayout(false);
            this.levelsMenuBar.ResumeLayout(false);
            this.levelsMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripButton SaveAsBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label CampaignNameLbl;
        private System.Windows.Forms.TextBox CampaignNameBox;
        private System.Windows.Forms.TabPage LevelsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampaignDescriptionBox;
        private System.Windows.Forms.Panel CampaignDescriptionContainer;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStrip MenuBar;
        private System.Windows.Forms.ListView LevelsBox;
        private System.Windows.Forms.ToolStrip levelsMenuBar;
        private System.Windows.Forms.ToolStripLabel Status;
        private System.Windows.Forms.ContextMenuStrip LevelsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addANewLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLevelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLevelToolStripMenuItem;
    }
}