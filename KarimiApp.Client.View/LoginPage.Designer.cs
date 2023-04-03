namespace KarimiApp.Client.View
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxUsername = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSettings = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 228);
            this.panel1.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCancel.Appearance.Options.UseForeColor = true;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCancel.ImageOptions.SvgImage")));
            this.ButtonCancel.Location = new System.Drawing.Point(4, 187);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonCancel.Size = new System.Drawing.Size(88, 37);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "لغو";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonLogin.Appearance.Options.UseForeColor = true;
            this.ButtonLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonLogin.ImageOptions.SvgImage")));
            this.ButtonLogin.Location = new System.Drawing.Point(108, 187);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonLogin.Size = new System.Drawing.Size(88, 37);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "ورود";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KarimiApp.Client.View.Properties.Resources.loginLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pictureBox1.Size = new System.Drawing.Size(201, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(208, 98);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(159, 42);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(208, 130);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Properties.UseSystemPasswordChar = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(159, 42);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز عبور :";
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSettings.ImageOptions.SvgImage")));
            this.ButtonSettings.Location = new System.Drawing.Point(405, 187);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonSettings.Size = new System.Drawing.Size(35, 37);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // LoginPage
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 228);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit TextBoxUsername;
        private DevExpress.XtraEditors.TextEdit TextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton ButtonLogin;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSettings;
    }
}