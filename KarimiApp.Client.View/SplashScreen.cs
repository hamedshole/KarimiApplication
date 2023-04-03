using KarimiApp.Model;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KarimiApp.Client.View
{
    public partial class SplashScreen : DevExpress.XtraSplashScreen.SplashScreen
    {
       SettingsModel settings;
        public SplashScreen()
        {
            this.settings = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk"));
            
            InitializeComponent();
            if (System.IO.File.Exists(this.settings.CustomSplashImage))
            {
                pictureBox1.Image = Image.FromFile(settings.CustomSplashImage);
            }
            else
            {
                MessageBox.Show("تصویر انتخاب شده توسط کاربر وجود ندارد.از تصویر پیش فرض استفاده میشود");
                pictureBox1.Image = Image.FromFile(settings.DefaultSplashImage);
            }
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}