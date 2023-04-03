namespace KarimiApp.Client.View.Edit
{
    partial class PaymentEdit
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
            this.TextBoxValue = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCustomerCode = new System.Windows.Forms.Label();
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCustomerBalance = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonMellat = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaman = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCash = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCustomerSelect = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.Label();
            this.ComboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCustomerBalance.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(95, 178);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Properties.DisplayFormat.FormatString = "*#*";
            this.TextBoxValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TextBoxValue.Size = new System.Drawing.Size(312, 20);
            this.TextBoxValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "میزان بدهی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "مقدار :";
            // 
            // TextBoxCustomerCode
            // 
            this.TextBoxCustomerCode.AutoSize = true;
            this.TextBoxCustomerCode.Location = new System.Drawing.Point(225, 31);
            this.TextBoxCustomerCode.Name = "TextBoxCustomerCode";
            this.TextBoxCustomerCode.Size = new System.Drawing.Size(25, 13);
            this.TextBoxCustomerCode.TabIndex = 7;
            this.TextBoxCustomerCode.Text = "000";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(95, 204);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(312, 96);
            this.TextBoxDescription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "توضیحات(بابت) :";
            // 
            // TextBoxCustomerBalance
            // 
            this.TextBoxCustomerBalance.Enabled = false;
            this.TextBoxCustomerBalance.Location = new System.Drawing.Point(114, 100);
            this.TextBoxCustomerBalance.Name = "TextBoxCustomerBalance";
            this.TextBoxCustomerBalance.Properties.DisplayFormat.FormatString = "*#*";
            this.TextBoxCustomerBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TextBoxCustomerBalance.Size = new System.Drawing.Size(109, 20);
            this.TextBoxCustomerBalance.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonMellat);
            this.panel1.Controls.Add(this.ButtonSaman);
            this.panel1.Controls.Add(this.ButtonCash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(539, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 365);
            this.panel1.TabIndex = 10;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Options.UseTextOptions = true;
            this.ButtonCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.Location = new System.Drawing.Point(15, 166);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCancel.Size = new System.Drawing.Size(168, 40);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "لغو";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonMellat
            // 
            this.ButtonMellat.Appearance.Options.UseTextOptions = true;
            this.ButtonMellat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonMellat.ImageOptions.Image = global::KarimiApp.Client.View.Properties.Resources.saman;
            this.ButtonMellat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonMellat.Location = new System.Drawing.Point(15, 112);
            this.ButtonMellat.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMellat.Name = "ButtonMellat";
            this.ButtonMellat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonMellat.Size = new System.Drawing.Size(168, 40);
            this.ButtonMellat.TabIndex = 5;
            this.ButtonMellat.Text = "ملت";
            this.ButtonMellat.Visible = false;
            this.ButtonMellat.Click += new System.EventHandler(this.ButtonMellat_Click);
            // 
            // ButtonSaman
            // 
            this.ButtonSaman.Appearance.Options.UseTextOptions = true;
            this.ButtonSaman.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSaman.ImageOptions.Image = global::KarimiApp.Client.View.Properties.Resources.mellat;
            this.ButtonSaman.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSaman.Location = new System.Drawing.Point(15, 64);
            this.ButtonSaman.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSaman.Name = "ButtonSaman";
            this.ButtonSaman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSaman.Size = new System.Drawing.Size(168, 40);
            this.ButtonSaman.TabIndex = 5;
            this.ButtonSaman.Text = "سامان";
            this.ButtonSaman.Visible = false;
            this.ButtonSaman.Click += new System.EventHandler(this.ButtonSaman_Click);
            // 
            // ButtonCash
            // 
            this.ButtonCash.Appearance.Options.UseTextOptions = true;
            this.ButtonCash.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCash.ImageOptions.Image = global::KarimiApp.Client.View.Properties.Resources.cash;
            this.ButtonCash.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCash.Location = new System.Drawing.Point(15, 14);
            this.ButtonCash.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCash.Name = "ButtonCash";
            this.ButtonCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCash.Size = new System.Drawing.Size(168, 40);
            this.ButtonCash.TabIndex = 6;
            this.ButtonCash.Text = "نقد";
            this.ButtonCash.Click += new System.EventHandler(this.ButtonCash_Click);
            // 
            // ButtonCustomerSelect
            // 
            this.ButtonCustomerSelect.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerSelect.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerSelect.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerSelect.Location = new System.Drawing.Point(413, 45);
            this.ButtonCustomerSelect.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerSelect.Name = "ButtonCustomerSelect";
            this.ButtonCustomerSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerSelect.Size = new System.Drawing.Size(123, 30);
            this.ButtonCustomerSelect.TabIndex = 6;
            this.ButtonCustomerSelect.Text = "انتخاب مشتری";
            this.ButtonCustomerSelect.Click += new System.EventHandler(this.ButtonCustomerSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxCustomerBalance);
            this.groupBox1.Controls.Add(this.TextBoxCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxCustomerCode);
            this.groupBox1.Location = new System.Drawing.Point(95, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتری";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "نام :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "کد :";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.AutoSize = true;
            this.TextBoxCustomerName.Location = new System.Drawing.Point(77, 64);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(25, 13);
            this.TextBoxCustomerName.TabIndex = 7;
            this.TextBoxCustomerName.Text = "000";
            // 
            // ComboBoxTransactionType
            // 
            this.ComboBoxTransactionType.FormattingEnabled = true;
            this.ComboBoxTransactionType.Items.AddRange(new object[] {
            "دریافت وجه",
            "پرداخت وجه"});
            this.ComboBoxTransactionType.Location = new System.Drawing.Point(286, 11);
            this.ComboBoxTransactionType.Name = "ComboBoxTransactionType";
            this.ComboBoxTransactionType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTransactionType.TabIndex = 12;
            this.ComboBoxTransactionType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "نوع تراکنش :";
            // 
            // PaymentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 365);
            this.Controls.Add(this.ComboBoxTransactionType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.ButtonCustomerSelect);
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PaymentEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCustomerBalance.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TextBoxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TextBoxCustomerCode;
        private DevExpress.XtraEditors.MemoEdit TextBoxDescription;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TextBoxCustomerBalance;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonMellat;
        private DevExpress.XtraEditors.SimpleButton ButtonSaman;
        private DevExpress.XtraEditors.SimpleButton ButtonCash;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextBoxCustomerName;
        private System.Windows.Forms.ComboBox ComboBoxTransactionType;
        private System.Windows.Forms.Label label10;
    }
}
