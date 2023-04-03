namespace KarimiApp.Client.View.Edit
{
    partial class RegisterEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterEdit));
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.TextBoxMac = new DevExpress.XtraEditors.TextEdit();
            this.LabelMac = new System.Windows.Forms.Label();
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxActive = new DevExpress.XtraEditors.CheckEdit();
            this.TextBoxIp = new DevExpress.XtraEditors.TextEdit();
            this.LabelIp = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxComputerName = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxComputerName.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(11, 159);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(238, 96);
            this.TextBoxDescription.TabIndex = 58;
            // 
            // TextBoxMac
            // 
            this.TextBoxMac.Location = new System.Drawing.Point(11, 101);
            this.TextBoxMac.Name = "TextBoxMac";
            this.TextBoxMac.Size = new System.Drawing.Size(239, 20);
            this.TextBoxMac.TabIndex = 57;
            // 
            // LabelMac
            // 
            this.LabelMac.AutoSize = true;
            this.LabelMac.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelMac.Location = new System.Drawing.Point(252, 104);
            this.LabelMac.Name = "LabelMac";
            this.LabelMac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelMac.Size = new System.Drawing.Size(103, 13);
            this.LabelMac.TabIndex = 56;
            this.LabelMac.Text = "آدرس سخت افزاری :";
            this.LabelMac.Click += new System.EventHandler(this.LabelMac_Click);
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(20, 169);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(93, 20);
            this.TextBoxId.TabIndex = 54;
            this.TextBoxId.Visible = false;
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Location = new System.Drawing.Point(193, 120);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Properties.Caption = "      : فعال      ";
            this.CheckBoxActive.Size = new System.Drawing.Size(110, 44);
            this.CheckBoxActive.TabIndex = 53;
            // 
            // TextBoxIp
            // 
            this.TextBoxIp.Location = new System.Drawing.Point(11, 75);
            this.TextBoxIp.Name = "TextBoxIp";
            this.TextBoxIp.Size = new System.Drawing.Size(239, 20);
            this.TextBoxIp.TabIndex = 52;
            // 
            // LabelIp
            // 
            this.LabelIp.AutoSize = true;
            this.LabelIp.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelIp.Location = new System.Drawing.Point(256, 78);
            this.LabelIp.Name = "LabelIp";
            this.LabelIp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelIp.Size = new System.Drawing.Size(44, 13);
            this.LabelIp.TabIndex = 51;
            this.LabelIp.Text = "آی پی :";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelDescription.Location = new System.Drawing.Point(251, 160);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDescription.Size = new System.Drawing.Size(54, 13);
            this.LabelDescription.TabIndex = 50;
            this.LabelDescription.Text = "توضیحات :";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(12, 10);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(239, 20);
            this.TextBoxTitle.TabIndex = 49;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelTitle.Location = new System.Drawing.Point(257, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTitle.Size = new System.Drawing.Size(82, 13);
            this.LabelTitle.TabIndex = 48;
            this.LabelTitle.Text = "عنوان سیستم :";
            // 
            // TextBoxComputerName
            // 
            this.TextBoxComputerName.Location = new System.Drawing.Point(12, 45);
            this.TextBoxComputerName.Name = "TextBoxComputerName";
            this.TextBoxComputerName.Size = new System.Drawing.Size(239, 20);
            this.TextBoxComputerName.TabIndex = 47;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(257, 48);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(69, 13);
            this.LabelName.TabIndex = 46;
            this.LabelName.Text = "نام سیستم :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(367, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 262);
            this.panel1.TabIndex = 63;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Options.UseTextOptions = true;
            this.ButtonCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCancel.ImageOptions.SvgImage")));
            this.ButtonCancel.Location = new System.Drawing.Point(10, 60);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCancel.Size = new System.Drawing.Size(140, 40);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "لغو";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSubmit.ImageOptions.SvgImage")));
            this.ButtonSubmit.Location = new System.Drawing.Point(10, 10);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmit.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // RegisterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxMac);
            this.Controls.Add(this.LabelMac);
            this.Controls.Add(this.CheckBoxActive);
            this.Controls.Add(this.TextBoxIp);
            this.Controls.Add(this.LabelIp);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxComputerName);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.registericon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "RegisterEdit";
            this.Text = "RegisterEdit";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxComputerName.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.MemoEdit TextBoxDescription;
        private DevExpress.XtraEditors.TextEdit TextBoxMac;
        private System.Windows.Forms.Label LabelMac;
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.CheckEdit CheckBoxActive;
        private DevExpress.XtraEditors.TextEdit TextBoxIp;
        private System.Windows.Forms.Label LabelIp;
        private System.Windows.Forms.Label LabelDescription;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private DevExpress.XtraEditors.TextEdit TextBoxComputerName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
    }
}