using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Settings
{
    public partial class ImageSelector : DevExpress.XtraEditors.XtraForm
    {
        Image selectedImage;
        public PictureBox picture;
        public ImageSelector()
        {
            DirectoryInfo directory = new DirectoryInfo(@"pics/");
            List<DirectoryInfo> directories = directory.GetDirectories().ToList();
            InitializeComponent();
            foreach (var item in directories)
            {
                TabPage tab = new TabPage();
                tab.Name = "tab_" + item.Name;
                tab.Text = item.Name;
                List<FileInfo> files = item.GetFiles("*.png").ToList();
                FlowLayoutPanel panel = new FlowLayoutPanel();
                foreach (var fileitem in files)
                {
                    picture = new PictureBox();
                    picture.Cursor = Cursors.Hand;
                    picture.Image = Image.FromFile(fileitem.FullName);
                    picture.ImageLocation = fileitem.FullName;
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Size = new Size(32, 32);
                    picture.Click += Picture_Click;
                    panel.Controls.Add(picture);
                }
                panel.Dock = DockStyle.Fill;
                tab.Controls.Add(panel);
                tabControl1.TabPages.Add(tab);
            }

        }

        private void Picture_Click(object sender, EventArgs e)
        {
            selectedImage = (sender as PictureBox).Image;
            pictureBox1.Image = (sender as PictureBox).Image;
            pictureBox1.ImageLocation = ((sender as PictureBox).ImageLocation);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string GetImage()
        {
            return pictureBox1.ImageLocation;
            // return selectedImage;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
