namespace CustomCampaign.Editor.Forms
{
    partial class MissingFilesDialog
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
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.CloseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MainPanel.SuspendLayout();
            this.BottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Divider);
            this.MainPanel.Controls.Add(this.DisplayText);
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(8, 40);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.MainPanel.Size = new System.Drawing.Size(622, 267);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.BackColorChanged += new System.EventHandler(this.MainPanel_BackColorChanged);
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Divider.Location = new System.Drawing.Point(0, 266);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(622, 1);
            this.Divider.TabIndex = 3;
            // 
            // DisplayText
            // 
            this.DisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayText.HideSelection = false;
            this.DisplayText.Location = new System.Drawing.Point(0, 8);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ReadOnly = true;
            this.DisplayText.Size = new System.Drawing.Size(622, 259);
            this.DisplayText.TabIndex = 4;
            this.DisplayText.Text = "DISPLAYED INFO";
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.CloseBtn);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(8, 307);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BottomActions.Size = new System.Drawing.Size(622, 44);
            this.BottomActions.TabIndex = 5;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.Depth = 0;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.Icon = null;
            this.CloseBtn.Location = new System.Drawing.Point(559, 8);
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
            // MissingFilesDialog
            // 
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(638, 359);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MissingFilesDialog";
            this.Padding = new System.Windows.Forms.Padding(8, 40, 8, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Error title";
            this.Shown += new System.EventHandler(this.MissingFilesDialog_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialPanel MainPanel;
        private MaterialSkin.Controls.MaterialPanel BottomActions;
        private MaterialSkin.Controls.MaterialFlatButton CloseBtn;
        private MaterialSkin.Controls.MaterialDivider Divider;
        private System.Windows.Forms.TextBox DisplayText;
    }
}
