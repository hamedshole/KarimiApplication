using System;
using System.Configuration;

namespace KarimiApp.Client.View.Settings
{
    public partial class ClientFirstConfig : DevExpress.XtraEditors.XtraForm
    {
        Configuration config;
        AppSettingsSection app;
        public ClientFirstConfig()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            if (app.Settings.Count != 0)
            {
                this.TextBoxStore.Text = app.Settings["storeName"].Value;
                this.TextBoxBranch.Text = app.Settings["branchName"].Value;
                this.TextBoxServerAddress.Text = app.Settings["serverAddress"].Value;
                this.TextBoxAddress.Text = app.Settings["storeAddress"].Value;
                this.TextBoxPhone.Text = app.Settings["storePhone"].Value;
                this.TextBoxWebsite.Text = app.Settings["storeWebsite"].Value;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            if (app.Settings.Count != 0)
            {
                app.Settings["storeName"].Value = this.TextBoxStore.Text;
                app.Settings["branchName"].Value = this.TextBoxBranch.Text;
                app.Settings["serverAddress"].Value = this.TextBoxServerAddress.Text;
                app.Settings["storeAddress"].Value = this.TextBoxAddress.Text;
                app.Settings["storePhone"].Value = this.TextBoxPhone.Text;
                app.Settings["storeWebsite"].Value = this.TextBoxWebsite.Text;
            }
            else
            {
                app.Settings.Add("storeName", TextBoxStore.Text);
                app.Settings.Add("branchName", TextBoxBranch.Text);
                app.Settings.Add("serverAddress", TextBoxServerAddress.Text);
                app.Settings.Add("storePhone", TextBoxPhone.Text);
                app.Settings.Add("storeAddress", TextBoxAddress.Text);
                app.Settings.Add("storeWebsite", this.TextBoxWebsite.Text);
            }
            config.Save(ConfigurationSaveMode.Modified);
            System.Windows.Forms.MessageBox.Show("تنظیمات اعمال شد");
        }
    }
}