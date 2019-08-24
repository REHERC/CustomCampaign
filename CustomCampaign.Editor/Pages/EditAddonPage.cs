using CustomCampaign.Editor.Forms.Dialogs;
using CustomCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Pages
{
    public partial class EditAddonPage : Classes.Page
    {
        public EditAddonPage()
        {
            InitializeComponent();
        }

        public override void OnDisplay()
        {
            base.OnDisplay();

            Dependencies_SelectedIndexChanged(Dependencies, new EventArgs());
        }

        public void Setup(Addon addon, string title)
        {
            data = addon;
            PageTitle = title;

            AddonName.Text = addon.name;
            AddonFile.Text = addon.module;

            Dependencies.Items.Clear();
            addon.dependencies.ForEach((dep) => Dependencies.Items.Add(dep));
        }

        private Addon data = new Addon();

        public Action<DialogResult, Addon> PageClosed = (result, level) => { };

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
                PageClosed(DialogResult.OK, data);
        }

        private void CancelBtn_Click(object sender, EventArgs e) => PageClosed(DialogResult.Cancel, data);
        private void AddonName_TextChanged(object sender, EventArgs e) => data.name = AddonName.Text;
        private void AddonFile_TextChanged(object sender, EventArgs e) => data.module = AddonFile.Text;
        private void Dependencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            flag &= Dependencies.SelectedIndex > -1; 
            flag &= Dependencies.SelectedIndex < Dependencies.Items.Count;

            EditBtn.Enabled = RemoveBtn.Enabled = flag;
            
        }

        void UpdateDataDependencies() => data.dependencies = Dependencies.Items.Cast<string>().ToList();

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string dep = InputDialog.Show("Add a dependency");
            if (!string.IsNullOrEmpty(dep))
                Dependencies.Items.Add(dep);
            UpdateDataDependencies();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int index = Dependencies.SelectedIndex;
            string dep = InputDialog.Show("Edit a dependency", "", Dependencies.Items[index] as string);
            if (!string.IsNullOrEmpty(dep))
                Dependencies.Items[index] = dep;
            UpdateDataDependencies();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int index = Dependencies.SelectedIndex;
            if (MessageBox.Show($"Are you sure you want to remove this dependency?", "Remove a dependency", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dependencies.Items.RemoveAt(index);
            UpdateDataDependencies();
        }
        private bool ValidateFields()
        {
            bool result = true;

            result &= AddonName.Text.Length > 0;
            result &= AddonFile.Text.Length > 0;

            return result;
        }
    }
}
