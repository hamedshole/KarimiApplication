namespace KarimiApp.Client.View.Settings
{
    partial class ClientFirstConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFirstConfig));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCloseCross = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonApply = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.TextBoxServerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxBranch = new System.Windows.Forms.TextBox();
            this.TextBoxStore = new System.Windows.Forms.TextBox();
            this.TextBoxWebsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCloseCross);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 61);
            this.panel1.TabIndex = 0;
            // 
            // ButtonCloseCross
            // 
            this.ButtonCloseCross.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonCloseCross.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCloseCross.ImageOptions.SvgImage")));
            this.ButtonCloseCross.Location = new System.Drawing.Point(402, 12);
            this.ButtonCloseCross.Name = "ButtonCloseCross";
            this.ButtonCloseCross.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonCloseCross.Size = new System.Drawing.Size(30, 30);
            this.ButtonCloseCross.TabIndex = 0;
            this.ButtonCloseCross.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "تنظیمات اولیه";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonClose);
            this.panel3.Controls.Add(this.ButtonApply);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 51);
            this.panel3.TabIndex = 0;
            // 
            // ButtonClose
            // 
            this.ButtonClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonClose.ImageOptions.SvgImage")));
            this.ButtonClose.Location = new System.Drawing.Point(182, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(103, 33);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "لغو";
            this.ButtonClose.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonApply.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonApply.ImageOptions.SvgImage")));
            this.ButtonApply.Location = new System.Drawing.Point(70, 6);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(106, 33);
            this.ButtonApply.TabIndex = 1;
            this.ButtonApply.Text = "ذخیره";
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 229);
            this.panel2.TabIndex = 4;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(435, 229);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.TextBoxServerAddress);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(433, 196);
            this.xtraTabPage1.Text = "اطلاعات سرور";
            // 
            // TextBoxServerAddress
            // 
            this.TextBoxServerAddress.Location = new System.Drawing.Point(124, 3);
            this.TextBoxServerAddress.Name = "TextBoxServerAddress";
            this.TextBoxServerAddress.Size = new System.Drawing.Size(213, 21);
            this.TextBoxServerAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 6);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "آدرس سرور :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.TextBoxAddress);
            this.xtraTabPage2.Controls.Add(this.TextBoxPhone);
            this.xtraTabPage2.Controls.Add(this.TextBoxWebsite);
            this.xtraTabPage2.Controls.Add(this.TextBoxBranch);
            this.xtraTabPage2.Controls.Add(this.TextBoxStore);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(433, 196);
            this.xtraTabPage2.Text = "اطلاعات فروشگاه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 114);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "آدرس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 33);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام شعبه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 6);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام فروشگاه :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(11, 111);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(335, 79);
            this.TextBoxAddress.TabIndex = 4;
            // 
            // TextBoxBranch
            // 
            this.TextBoxBranch.Location = new System.Drawing.Point(181, 30);
            this.TextBoxBranch.Name = "TextBoxBranch";
            this.TextBoxBranch.Size = new System.Drawing.Size(165, 21);
            this.TextBoxBranch.TabIndex = 1;
            // 
            // TextBoxStore
            // 
            this.TextBoxStore.Location = new System.Drawing.Point(181, 3);
            this.TextBoxStore.Name = "TextBoxStore";
            this.TextBoxStore.Size = new System.Drawing.Size(165, 21);
            this.TextBoxStore.TabIndex = 0;
            // 
            // TextBoxWebsite
            // 
            this.TextBoxWebsite.Location = new System.Drawing.Point(181, 57);
            this.TextBoxWebsite.Name = "TextBoxWebsite";
            this.TextBoxWebsite.Size = new System.Drawing.Size(165, 21);
            this.TextBoxWebsite.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 60);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "وب سایت :";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(181, 84);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(165, 21);
            this.TextBoxPhone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 87);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "تلفن :";
            // 
            // ClientFirstConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientFirstConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات اولیه";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCloseCross;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton ButtonClose;
        private DevExpress.XtraEditors.SimpleButton ButtonApply;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TextBox TextBoxServerAddress;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxBranch;
        private System.Windows.Forms.TextBox TextBoxStore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxWebsite;
    }
}