﻿using CustomCampaign.Editor.Pages;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class MainForm : MaterialForm
    {
        private SystemMenu systemmenu;

        public MainForm()
        {
            Globals.SkinManager.AddFormToManage(this);
            InitializeComponent();

            AddPage(new StartPage());
            AddPage(new NewCampaignWizard());
            AddPage(new EditorMainPage());
            AddPage(new EditLevelPage());

            systemmenu = new SystemMenu(this);

            systemmenu.AddCommand("h", () => {
                MessageBox.Show(Constants.BIG_SPIN_MESSAGE);
                Process.Start(Constants.BIG_SPIN);
            }, true, false);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            systemmenu.HandleMessage(ref m);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SetPage("pages:home");
        }

        private void BugReportBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/REHERC/CustomCampaign/issues");
        }

        private void FormTitle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new SettingsForm().ShowDialog();
            Show();
        }

        readonly Queue<Keys> KeyStrokes = new Queue<Keys>();
        DateTime LastInput = DateTime.UtcNow;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((DateTime.UtcNow - LastInput).TotalSeconds > 1.5f)
                KeyStrokes.Clear();
            KeyStrokes.Enqueue(keyData);

            string code = "";
            foreach (Keys key in KeyStrokes)
                code = $"{code}{key.ToString()}";

            foreach (var item in Secrets)
                if (code.Contains(item.Key))
                {
                    item.Value();
                    KeyStrokes.Clear();
                }

            LastInput = DateTime.UtcNow;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private readonly Dictionary<string, Action> Secrets = new Dictionary<string, Action>() {
            { "UpUpDownDownLeftRightLeftRightBA", () => {
                Globals.MainWindow.Hide();
                new PizzaForm().ShowDialog();
                Globals.MainWindow.Show();
            }}
        };

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.IsFileOpened && MessageBox.Show("Are you sure you want to close this window?\nAny unsaved changes will be discarded!", "Quit application?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
