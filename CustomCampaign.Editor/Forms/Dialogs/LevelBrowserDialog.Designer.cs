namespace CustomCampaign.Editor.Forms.Dialogs
{
    partial class LevelBrowserDialog
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ProjectTab = new System.Windows.Forms.TabPage();
            this.ProjectBrowser = new CustomCampaign.Editor.Controls.LevelBrowser();
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.SelectBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ImportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ActionsDivider = new MaterialSkin.Controls.MaterialDivider();
            this.RefreshBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabControl.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.BottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Location = new System.Drawing.Point(0, 40);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Primary = true;
            this.TabSelector.Size = new System.Drawing.Size(843, 36);
            this.TabSelector.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ProjectTab);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 76);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(843, 298);
            this.TabControl.TabIndex = 1;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.ProjectBrowser);
            this.ProjectTab.Location = new System.Drawing.Point(4, 22);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Size = new System.Drawing.Size(835, 272);
            this.ProjectTab.TabIndex = 0;
            this.ProjectTab.Text = "Project Resources";
            this.ProjectTab.UseVisualStyleBackColor = true;
            // 
            // ProjectBrowser
            // 
            this.ProjectBrowser.Depth = 0;
            this.ProjectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectBrowser.Location = new System.Drawing.Point(0, 0);
            this.ProjectBrowser.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProjectBrowser.Name = "ProjectBrowser";
            this.ProjectBrowser.Size = new System.Drawing.Size(835, 272);
            this.ProjectBrowser.TabIndex = 0;
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.SelectBtn);
            this.BottomActions.Controls.Add(this.ImportBtn);
            this.BottomActions.Controls.Add(this.CancelBtn);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(0, 375);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.BottomActions.Size = new System.Drawing.Size(843, 64);
            this.BottomActions.TabIndex = 2;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectBtn.AutoSize = true;
            this.SelectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectBtn.Depth = 0;
            this.SelectBtn.Header = false;
            this.SelectBtn.Icon = null;
            this.SelectBtn.Location = new System.Drawing.Point(636, 12);
            this.SelectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Primary = true;
            this.SelectBtn.Size = new System.Drawing.Size(112, 36);
            this.SelectBtn.TabIndex = 3;
            this.SelectBtn.Text = "Select Level";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.Depth = 0;
            this.ImportBtn.Header = false;
            this.ImportBtn.Icon = null;
            this.ImportBtn.Location = new System.Drawing.Point(17, 12);
            this.ImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Primary = true;
            this.ImportBtn.Size = new System.Drawing.Size(143, 36);
            this.ImportBtn.TabIndex = 2;
            this.ImportBtn.Text = "Import from file";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Visible = false;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(755, 12);
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
            // ActionsDivider
            // 
            this.ActionsDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ActionsDivider.Depth = 0;
            this.ActionsDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsDivider.Location = new System.Drawing.Point(0, 374);
            this.ActionsDivider.MaximumSize = new System.Drawing.Size(0, 1);
            this.ActionsDivider.MinimumSize = new System.Drawing.Size(0, 1);
            this.ActionsDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActionsDivider.Name = "ActionsDivider";
            this.ActionsDivider.Size = new System.Drawing.Size(843, 1);
            this.ActionsDivider.TabIndex = 3;
            this.ActionsDivider.Text = "materialDivider1";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.AutoSize = true;
            this.RefreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshBtn.Depth = 0;
            this.RefreshBtn.Header = true;
            this.RefreshBtn.Icon = null;
            this.RefreshBtn.Location = new System.Drawing.Point(749, 34);
            this.RefreshBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Primary = true;
            this.RefreshBtn.Size = new System.Drawing.Size(79, 36);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LevelBrowserDialog
            // 
            this.AcceptButton = this.SelectBtn;
            this.Bar = false;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(843, 439);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ActionsDivider);
            this.Controls.Add(this.BottomActions);
            this.Controls.Add(this.TabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.Name = "LevelBrowserDialog";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Select a level";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.LevelBrowserDialog_Validating);
            this.TabControl.ResumeLayout(false);
            this.ProjectTab.ResumeLayout(false);
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage ProjectTab;
        private MaterialSkin.Controls.MaterialPanel BottomActions;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private Controls.LevelBrowser ProjectBrowser;
        private MaterialSkin.Controls.MaterialDivider ActionsDivider;
        private MaterialSkin.Controls.MaterialRaisedButton ImportBtn;
        private MaterialSkin.Controls.MaterialRaisedButton RefreshBtn;
        private MaterialSkin.Controls.MaterialRaisedButton SelectBtn;
    }
}
