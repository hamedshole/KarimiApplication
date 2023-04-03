namespace KarimiApp.Client.View.Edit
{
    partial class PaymentTypeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentTypeEdit));
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxActive = new DevExpress.XtraEditors.CheckEdit();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(10, 103);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(140, 20);
            this.TextBoxId.TabIndex = 51;
            this.TextBoxId.Visible = false;
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Location = new System.Drawing.Point(124, 33);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Properties.Caption = "      : فعال      ";
            this.CheckBoxActive.Size = new System.Drawing.Size(104, 44);
            this.CheckBoxActive.TabIndex = 50;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(21, 7);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(157, 20);
            this.TextBoxTitle.TabIndex = 49;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(184, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(40, 13);
            this.LabelName.TabIndex = 48;
            this.LabelName.Text = "عنوان :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(234, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 103);
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
            this.ButtonCancel.TabIndex = 1;
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
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // PaymentTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 103);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckBoxActive);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.paymenttypeicon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PaymentTypeEdit";
            this.Text = "PaymentTypeEdit";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.CheckEdit CheckBoxActive;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
    }
}