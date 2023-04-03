namespace KarimiApp.Client.View.Edit
{
    partial class PaymentMethodEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodEdit));
            this.CheckBoxActive = new DevExpress.XtraEditors.CheckEdit();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.ComboBoxPaymentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxPos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxPosCom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxPosTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.ButtonPaymentTypeNew = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPosNew = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentMethodRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPosRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPos.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Location = new System.Drawing.Point(278, 106);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Properties.Caption = "      : فعال      ";
            this.CheckBoxActive.Size = new System.Drawing.Size(112, 44);
            this.CheckBoxActive.TabIndex = 73;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(167, 7);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(140, 20);
            this.TextBoxTitle.TabIndex = 66;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(313, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(40, 13);
            this.LabelName.TabIndex = 65;
            this.LabelName.Text = "عنوان :";
            // 
            // ComboBoxPaymentType
            // 
            this.ComboBoxPaymentType.Location = new System.Drawing.Point(167, 45);
            this.ComboBoxPaymentType.Name = "ComboBoxPaymentType";
            this.ComboBoxPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPaymentType.Size = new System.Drawing.Size(139, 20);
            this.ComboBoxPaymentType.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(313, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "نوع پرداخت :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(313, 83);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "پایانه مورد استفاده :";
            // 
            // ComboBoxPos
            // 
            this.ComboBoxPos.Location = new System.Drawing.Point(102, 80);
            this.ComboBoxPos.Name = "ComboBoxPos";
            this.ComboBoxPos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPos.Size = new System.Drawing.Size(202, 20);
            this.ComboBoxPos.TabIndex = 75;
            this.ComboBoxPos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxPosCom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxPosTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(56, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(319, 70);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پایانه ";
            // 
            // TextBoxPosCom
            // 
            this.TextBoxPosCom.AutoSize = true;
            this.TextBoxPosCom.Location = new System.Drawing.Point(93, 46);
            this.TextBoxPosCom.Name = "TextBoxPosCom";
            this.TextBoxPosCom.Size = new System.Drawing.Size(35, 13);
            this.TextBoxPosCom.TabIndex = 0;
            this.TextBoxPosCom.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "شماره کام :";
            // 
            // TextBoxPosTitle
            // 
            this.TextBoxPosTitle.AutoSize = true;
            this.TextBoxPosTitle.Location = new System.Drawing.Point(93, 26);
            this.TextBoxPosTitle.Name = "TextBoxPosTitle";
            this.TextBoxPosTitle.Size = new System.Drawing.Size(35, 13);
            this.TextBoxPosTitle.TabIndex = 0;
            this.TextBoxPosTitle.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "عنوان :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(432, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 241);
            this.panel1.TabIndex = 77;
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
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(81, 123);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(67, 20);
            this.TextBoxId.TabIndex = 0;
            this.TextBoxId.Visible = false;
            // 
            // ButtonPaymentTypeNew
            // 
            this.ButtonPaymentTypeNew.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonPaymentTypeNew.Appearance.Options.UseBorderColor = true;
            this.ButtonPaymentTypeNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentTypeNew.ImageOptions.SvgImage")));
            this.ButtonPaymentTypeNew.Location = new System.Drawing.Point(81, 39);
            this.ButtonPaymentTypeNew.Name = "ButtonPaymentTypeNew";
            this.ButtonPaymentTypeNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonPaymentTypeNew.Size = new System.Drawing.Size(37, 32);
            this.ButtonPaymentTypeNew.TabIndex = 78;
            this.ButtonPaymentTypeNew.Click += new System.EventHandler(this.ButtonPaymentTypeNew_Click);
            // 
            // ButtonPosNew
            // 
            this.ButtonPosNew.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonPosNew.Appearance.Options.UseBorderColor = true;
            this.ButtonPosNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosNew.ImageOptions.SvgImage")));
            this.ButtonPosNew.Location = new System.Drawing.Point(12, 74);
            this.ButtonPosNew.Name = "ButtonPosNew";
            this.ButtonPosNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonPosNew.Size = new System.Drawing.Size(37, 32);
            this.ButtonPosNew.TabIndex = 78;
            this.ButtonPosNew.Click += new System.EventHandler(this.ButtonPosNew_Click);
            // 
            // ButtonPaymentMethodRefresh
            // 
            this.ButtonPaymentMethodRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonPaymentMethodRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonPaymentMethodRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentMethodRefresh.ImageOptions.SvgImage")));
            this.ButtonPaymentMethodRefresh.Location = new System.Drawing.Point(124, 39);
            this.ButtonPaymentMethodRefresh.Name = "ButtonPaymentMethodRefresh";
            this.ButtonPaymentMethodRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonPaymentMethodRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonPaymentMethodRefresh.TabIndex = 78;
            this.ButtonPaymentMethodRefresh.Click += new System.EventHandler(this.ButtonPaymentMethodRefresh_Click);
            // 
            // ButtonPosRefresh
            // 
            this.ButtonPosRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonPosRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonPosRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosRefresh.ImageOptions.SvgImage")));
            this.ButtonPosRefresh.Location = new System.Drawing.Point(55, 74);
            this.ButtonPosRefresh.Name = "ButtonPosRefresh";
            this.ButtonPosRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonPosRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonPosRefresh.TabIndex = 78;
            this.ButtonPosRefresh.Click += new System.EventHandler(this.ButtonPosRefresh_Click);
            // 
            // PaymentMethodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 241);
            this.Controls.Add(this.ButtonPosRefresh);
            this.Controls.Add(this.ButtonPosNew);
            this.Controls.Add(this.ButtonPaymentMethodRefresh);
            this.Controls.Add(this.ButtonPaymentTypeNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxPos);
            this.Controls.Add(this.ComboBoxPaymentType);
            this.Controls.Add(this.CheckBoxActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.paymentmethodicon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PaymentMethodEdit";
            this.Text = "PaymentMethodEdit";
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPos.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit CheckBoxActive;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label LabelName;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxPaymentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TextBoxPosCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TextBoxPosTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentTypeNew;
        private DevExpress.XtraEditors.SimpleButton ButtonPosNew;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentMethodRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonPosRefresh;
    }
}