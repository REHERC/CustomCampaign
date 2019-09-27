namespace CustomCampaign.Editor.Forms
{
    partial class MessageDialog
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
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.AbortBox = new MaterialSkin.Controls.MaterialPanel();
            this.AbortBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.RetryBox = new MaterialSkin.Controls.MaterialPanel();
            this.RetryBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.IgnoreBox = new MaterialSkin.Controls.MaterialPanel();
            this.IgnoreBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.YesBox = new MaterialSkin.Controls.MaterialPanel();
            this.YesBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NoBox = new MaterialSkin.Controls.MaterialPanel();
            this.NoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.OkBox = new MaterialSkin.Controls.MaterialPanel();
            this.OkBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelBox = new MaterialSkin.Controls.MaterialPanel();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.BottomDivider = new MaterialSkin.Controls.MaterialDivider();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomActions.SuspendLayout();
            this.AbortBox.SuspendLayout();
            this.RetryBox.SuspendLayout();
            this.IgnoreBox.SuspendLayout();
            this.YesBox.SuspendLayout();
            this.NoBox.SuspendLayout();
            this.OkBox.SuspendLayout();
            this.CancelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.AbortBox);
            this.BottomActions.Controls.Add(this.RetryBox);
            this.BottomActions.Controls.Add(this.IgnoreBox);
            this.BottomActions.Controls.Add(this.YesBox);
            this.BottomActions.Controls.Add(this.NoBox);
            this.BottomActions.Controls.Add(this.OkBox);
            this.BottomActions.Controls.Add(this.CancelBox);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(16, 141);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BottomActions.Size = new System.Drawing.Size(340, 45);
            this.BottomActions.TabIndex = 2;
            // 
            // AbortBox
            // 
            this.AbortBox.AutoSize = true;
            this.AbortBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AbortBox.Controls.Add(this.AbortBtn);
            this.AbortBox.Depth = 0;
            this.AbortBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.AbortBox.Location = new System.Drawing.Point(-255, 8);
            this.AbortBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.AbortBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AbortBox.Name = "AbortBox";
            this.AbortBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AbortBox.Size = new System.Drawing.Size(85, 37);
            this.AbortBox.TabIndex = 6;
            // 
            // AbortBtn
            // 
            this.AbortBtn.AutoSize = true;
            this.AbortBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AbortBtn.Depth = 0;
            this.AbortBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.AbortBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbortBtn.Icon = null;
            this.AbortBtn.Location = new System.Drawing.Point(8, 0);
            this.AbortBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AbortBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Primary = false;
            this.AbortBtn.Size = new System.Drawing.Size(77, 37);
            this.AbortBtn.TabIndex = 1;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            // 
            // RetryBox
            // 
            this.RetryBox.AutoSize = true;
            this.RetryBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RetryBox.Controls.Add(this.RetryBtn);
            this.RetryBox.Depth = 0;
            this.RetryBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RetryBox.Location = new System.Drawing.Point(-170, 8);
            this.RetryBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.RetryBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetryBox.Name = "RetryBox";
            this.RetryBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.RetryBox.Size = new System.Drawing.Size(85, 37);
            this.RetryBox.TabIndex = 5;
            // 
            // RetryBtn
            // 
            this.RetryBtn.AutoSize = true;
            this.RetryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RetryBtn.Depth = 0;
            this.RetryBtn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.RetryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetryBtn.Icon = null;
            this.RetryBtn.Location = new System.Drawing.Point(8, 0);
            this.RetryBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RetryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetryBtn.Name = "RetryBtn";
            this.RetryBtn.Primary = false;
            this.RetryBtn.Size = new System.Drawing.Size(77, 37);
            this.RetryBtn.TabIndex = 1;
            this.RetryBtn.Text = "Retry";
            this.RetryBtn.UseVisualStyleBackColor = true;
            // 
            // IgnoreBox
            // 
            this.IgnoreBox.AutoSize = true;
            this.IgnoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IgnoreBox.Controls.Add(this.IgnoreBtn);
            this.IgnoreBox.Depth = 0;
            this.IgnoreBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.IgnoreBox.Location = new System.Drawing.Point(-85, 8);
            this.IgnoreBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.IgnoreBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.IgnoreBox.Name = "IgnoreBox";
            this.IgnoreBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.IgnoreBox.Size = new System.Drawing.Size(85, 37);
            this.IgnoreBox.TabIndex = 4;
            // 
            // IgnoreBtn
            // 
            this.IgnoreBtn.AutoSize = true;
            this.IgnoreBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IgnoreBtn.Depth = 0;
            this.IgnoreBtn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.IgnoreBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IgnoreBtn.Icon = null;
            this.IgnoreBtn.Location = new System.Drawing.Point(8, 0);
            this.IgnoreBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IgnoreBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.IgnoreBtn.Name = "IgnoreBtn";
            this.IgnoreBtn.Primary = false;
            this.IgnoreBtn.Size = new System.Drawing.Size(77, 37);
            this.IgnoreBtn.TabIndex = 1;
            this.IgnoreBtn.Text = "Ignore";
            this.IgnoreBtn.UseVisualStyleBackColor = true;
            // 
            // YesBox
            // 
            this.YesBox.AutoSize = true;
            this.YesBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YesBox.Controls.Add(this.YesBtn);
            this.YesBox.Depth = 0;
            this.YesBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.YesBox.Location = new System.Drawing.Point(0, 8);
            this.YesBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.YesBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesBox.Name = "YesBox";
            this.YesBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.YesBox.Size = new System.Drawing.Size(85, 37);
            this.YesBox.TabIndex = 3;
            // 
            // YesBtn
            // 
            this.YesBtn.AutoSize = true;
            this.YesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YesBtn.Depth = 0;
            this.YesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesBtn.Header = false;
            this.YesBtn.Icon = null;
            this.YesBtn.Location = new System.Drawing.Point(8, 0);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.YesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Primary = true;
            this.YesBtn.Size = new System.Drawing.Size(77, 37);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            // 
            // NoBox
            // 
            this.NoBox.AutoSize = true;
            this.NoBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoBox.Controls.Add(this.NoBtn);
            this.NoBox.Depth = 0;
            this.NoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.NoBox.Location = new System.Drawing.Point(85, 8);
            this.NoBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.NoBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoBox.Name = "NoBox";
            this.NoBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.NoBox.Size = new System.Drawing.Size(85, 37);
            this.NoBox.TabIndex = 2;
            // 
            // NoBtn
            // 
            this.NoBtn.AutoSize = true;
            this.NoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoBtn.Depth = 0;
            this.NoBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoBtn.Icon = null;
            this.NoBtn.Location = new System.Drawing.Point(8, 0);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Primary = false;
            this.NoBtn.Size = new System.Drawing.Size(77, 37);
            this.NoBtn.TabIndex = 1;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            // 
            // OkBox
            // 
            this.OkBox.AutoSize = true;
            this.OkBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkBox.Controls.Add(this.OkBtn);
            this.OkBox.Depth = 0;
            this.OkBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBox.Location = new System.Drawing.Point(170, 8);
            this.OkBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.OkBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkBox.Name = "OkBox";
            this.OkBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.OkBox.Size = new System.Drawing.Size(85, 37);
            this.OkBox.TabIndex = 1;
            // 
            // OkBtn
            // 
            this.OkBtn.AutoSize = true;
            this.OkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkBtn.Depth = 0;
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkBtn.Header = false;
            this.OkBtn.Icon = null;
            this.OkBtn.Location = new System.Drawing.Point(8, 0);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Primary = true;
            this.OkBtn.Size = new System.Drawing.Size(77, 37);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBox
            // 
            this.CancelBox.AutoSize = true;
            this.CancelBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBox.Controls.Add(this.CancelBtn);
            this.CancelBox.Depth = 0;
            this.CancelBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBox.Location = new System.Drawing.Point(255, 8);
            this.CancelBox.MinimumSize = new System.Drawing.Size(85, 0);
            this.CancelBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBox.Name = "CancelBox";
            this.CancelBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.CancelBox.Size = new System.Drawing.Size(85, 37);
            this.CancelBox.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(8, 0);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(77, 37);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // BottomDivider
            // 
            this.BottomDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BottomDivider.Depth = 0;
            this.BottomDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomDivider.Location = new System.Drawing.Point(16, 140);
            this.BottomDivider.MaximumSize = new System.Drawing.Size(0, 1);
            this.BottomDivider.MinimumSize = new System.Drawing.Size(0, 1);
            this.BottomDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomDivider.Name = "BottomDivider";
            this.BottomDivider.Size = new System.Drawing.Size(340, 1);
            this.BottomDivider.TabIndex = 4;
            this.BottomDivider.Text = "materialDivider1";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(16, 48);
            this.MainPanel.MaximumSize = new System.Drawing.Size(602, 292);
            this.MainPanel.MinimumSize = new System.Drawing.Size(340, 92);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(340, 92);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // MessageDialog
            // 
            this.AutoSize = true;
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(372, 202);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomDivider);
            this.Controls.Add(this.BottomActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 240);
            this.Name = "MessageDialog";
            this.Padding = new System.Windows.Forms.Padding(16, 48, 16, 16);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Caption";
            this.Shown += new System.EventHandler(this.MessageDialog_Shown);
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.AbortBox.ResumeLayout(false);
            this.AbortBox.PerformLayout();
            this.RetryBox.ResumeLayout(false);
            this.RetryBox.PerformLayout();
            this.IgnoreBox.ResumeLayout(false);
            this.IgnoreBox.PerformLayout();
            this.YesBox.ResumeLayout(false);
            this.YesBox.PerformLayout();
            this.NoBox.ResumeLayout(false);
            this.NoBox.PerformLayout();
            this.OkBox.ResumeLayout(false);
            this.OkBox.PerformLayout();
            this.CancelBox.ResumeLayout(false);
            this.CancelBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialPanel BottomActions;
        private MaterialSkin.Controls.MaterialPanel CancelBox;
        private MaterialSkin.Controls.MaterialPanel AbortBox;
        private MaterialSkin.Controls.MaterialFlatButton AbortBtn;
        private MaterialSkin.Controls.MaterialPanel RetryBox;
        private MaterialSkin.Controls.MaterialFlatButton RetryBtn;
        private MaterialSkin.Controls.MaterialPanel IgnoreBox;
        private MaterialSkin.Controls.MaterialFlatButton IgnoreBtn;
        private MaterialSkin.Controls.MaterialPanel YesBox;
        private MaterialSkin.Controls.MaterialRaisedButton YesBtn;
        private MaterialSkin.Controls.MaterialPanel NoBox;
        private MaterialSkin.Controls.MaterialFlatButton NoBtn;
        private MaterialSkin.Controls.MaterialPanel OkBox;
        private MaterialSkin.Controls.MaterialRaisedButton OkBtn;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialDivider BottomDivider;
        private System.Windows.Forms.Panel MainPanel;
    }
}
