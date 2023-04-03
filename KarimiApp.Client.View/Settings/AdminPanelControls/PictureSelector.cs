using KarimiApp.Model;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Settings.AdminPanelControls
{
    public partial class PictureSelector : DevExpress.XtraEditors.XtraUserControl
    {
        SettingsModel settings;
        public PictureSelector()
        {
            InitializeComponent();
            if (!System.IO.File.Exists("Settings/settings.hshk"))
            {
                settings =new SettingsModel();
            }
            else
            {
                settings = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk"));
                if (this.settings.CustomSplashImage != null && System.IO.File.Exists(this.settings.CustomSplashImage))
                {
                    this.pictureBox1.Image = Image.FromFile(this.settings.CustomSplashImage);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (this.settings.CustomCashierGirdBg != null && System.IO.File.Exists(this.settings.CustomCashierGirdBg))
                {
                    this.pictureBox2.Image = Image.FromFile(this.settings.CustomCashierGirdBg);
                    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    this.pictureBox1.Image = Image.FromFile(this.settings.DefaultSplashImage);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox2.Image = Image.FromFile(this.settings.DefaultCashierGridBg);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image files (*.jpg,*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // System.IO.File.Copy(
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.settings.CustomSplashImage = openFileDialog.FileName;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("Settings/settings.hshk");
            System.IO.File.WriteAllText("Settings/settings.hshk", JsonConvert.SerializeObject(this.settings));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image files (*.jpg,*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // System.IO.File.Copy(
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.settings.CustomCashierGirdBg = openFileDialog.FileName;
            }
        }
    }
}
