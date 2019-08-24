namespace CustomCampaign.Editor.Forms.Dialogs
{
    partial class InputDialog
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
            this.InputBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SubmitBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.MainPanel.SuspendLayout();
            this.BottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InputBox);
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(16, 40);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(421, 40);
            this.MainPanel.TabIndex = 0;
            // 
            // InputBox
            // 
            this.InputBox.Depth = 0;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputBox.Hint = "";
            this.InputBox.Location = new System.Drawing.Point(0, 17);
            this.InputBox.MaxLength = 32767;
            this.InputBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.SelectedText = "";
            this.InputBox.SelectionLength = 0;
            this.InputBox.SelectionStart = 0;
            this.InputBox.Size = new System.Drawing.Size(421, 23);
            this.InputBox.TabIndex = 0;
            this.InputBox.TabStop = false;
            this.InputBox.UseSystemPasswordChar = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(349, 9);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.AutoSize = true;
            this.SubmitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitBtn.Depth = 0;
            this.SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitBtn.Header = false;
            this.SubmitBtn.Icon = null;
            this.SubmitBtn.Location = new System.Drawing.Point(270, 9);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SubmitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Primary = true;
            this.SubmitBtn.Size = new System.Drawing.Size(71, 36);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.SubmitBtn);
            this.BottomActions.Controls.Add(this.CancelBtn);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(16, 80);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BottomActions.Size = new System.Drawing.Size(421, 45);
            this.BottomActions.TabIndex = 1;
            // 
            // InputDialog
            // 
            this.AcceptButton = this.SubmitBtn;
            this.Bar = false;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(453, 141);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            this.Padding = new System.Windows.Forms.Padding(16, 40, 16, 16);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Input prompt title";
            this.MainPanel.ResumeLayout(false);
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialPanel MainPanel;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialPanel BottomActions;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitBtn;
        protected MaterialSkin.Controls.MaterialSingleLineTextField InputBox;
    }
}
