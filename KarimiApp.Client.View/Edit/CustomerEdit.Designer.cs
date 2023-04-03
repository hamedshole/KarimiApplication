namespace KarimiApp.Client.View.Edit
{
    partial class PersonEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonEdit));
            this.TextBoxPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxAddress = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmitClear = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(12, 42);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(163, 20);
            this.TextBoxPhoneNumber.TabIndex = 25;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelPhoneNumber.Location = new System.Drawing.Point(181, 44);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPhoneNumber.Size = new System.Drawing.Size(35, 13);
            this.LabelPhoneNumber.TabIndex = 24;
            this.LabelPhoneNumber.Text = "تلفن :";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(163, 20);
            this.TextBoxFirstName.TabIndex = 15;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(181, 14);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(27, 13);
            this.LabelName.TabIndex = 14;
            this.LabelName.Text = "نام :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(12, 73);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(163, 96);
            this.TextBoxAddress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(181, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "آدرس :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmitClear);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 300);
            this.panel1.TabIndex = 63;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Options.UseTextOptions = true;
            this.ButtonCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCancel.ImageOptions.SvgImage")));
            this.ButtonCancel.Location = new System.Drawing.Point(10, 110);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCancel.Size = new System.Drawing.Size(140, 40);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "لغو";
            // 
            // ButtonSubmitClear
            // 
            this.ButtonSubmitClear.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmitClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmitClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmitClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSubmitClear.ImageOptions.SvgImage")));
            this.ButtonSubmitClear.Location = new System.Drawing.Point(10, 60);
            this.ButtonSubmitClear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmitClear.Name = "ButtonSubmitClear";
            this.ButtonSubmitClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmitClear.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmitClear.TabIndex = 2;
            this.ButtonSubmitClear.Text = "ثبت و جدید";
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
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(50, 153);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 52;
            this.TextBoxId.Visible = false;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.customericon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PersonEdit";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TextBoxPhoneNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private DevExpress.XtraEditors.TextEdit TextBoxFirstName;
        private System.Windows.Forms.Label LabelName;
        private DevExpress.XtraEditors.MemoEdit TextBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitClear;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
        private DevExpress.XtraEditors.TextEdit TextBoxId;
    }
}