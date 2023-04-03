namespace KarimiApp.Client.View.Edit
{
    partial class SupplierEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEdit));
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
            this.PersonInfoTab = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.SupplierInfoTab = new DevExpress.XtraTab.XtraTabPage();
            this.ButtonCompanyRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSupplierCompanyNew = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxSupplierCompany = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonInfoTab)).BeginInit();
            this.PersonInfoTab.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SupplierInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSupplierCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(36, 63);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(163, 36);
            this.TextBoxPhoneNumber.TabIndex = 25;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelPhoneNumber.Location = new System.Drawing.Point(205, 74);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPhoneNumber.Size = new System.Drawing.Size(35, 13);
            this.LabelPhoneNumber.TabIndex = 24;
            this.LabelPhoneNumber.Text = "تلفن :";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(36, 8);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(163, 36);
            this.TextBoxFirstName.TabIndex = 15;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(205, 19);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(27, 13);
            this.LabelName.TabIndex = 14;
            this.LabelName.Text = "نام :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(36, 122);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(163, 96);
            this.TextBoxAddress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(205, 124);
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
            this.panel1.Location = new System.Drawing.Point(365, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 275);
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
            // PersonInfoTab
            // 
            this.PersonInfoTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonInfoTab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
            this.PersonInfoTab.Location = new System.Drawing.Point(0, 0);
            this.PersonInfoTab.Name = "PersonInfoTab";
            this.PersonInfoTab.SelectedTabPage = this.xtraTabPage1;
            this.PersonInfoTab.Size = new System.Drawing.Size(365, 275);
            this.PersonInfoTab.TabIndex = 64;
            this.PersonInfoTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.SupplierInfoTab});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.TextBoxFirstName);
            this.xtraTabPage1.Controls.Add(this.LabelName);
            this.xtraTabPage1.Controls.Add(this.TextBoxAddress);
            this.xtraTabPage1.Controls.Add(this.TextBoxPhoneNumber);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.LabelPhoneNumber);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(339, 273);
            this.xtraTabPage1.Text = "اطلاعات فردی";
            // 
            // SupplierInfoTab
            // 
            this.SupplierInfoTab.Controls.Add(this.ButtonCompanyRefresh);
            this.SupplierInfoTab.Controls.Add(this.ButtonSupplierCompanyNew);
            this.SupplierInfoTab.Controls.Add(this.ComboBoxSupplierCompany);
            this.SupplierInfoTab.Controls.Add(this.label4);
            this.SupplierInfoTab.Name = "SupplierInfoTab";
            this.SupplierInfoTab.Size = new System.Drawing.Size(339, 273);
            this.SupplierInfoTab.Text = "اطلاعات تامین کننده";
            // 
            // ButtonCompanyRefresh
            // 
            this.ButtonCompanyRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonCompanyRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonCompanyRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonCompanyRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCompanyRefresh.ImageOptions.SvgImage")));
            this.ButtonCompanyRefresh.Location = new System.Drawing.Point(64, 5);
            this.ButtonCompanyRefresh.Name = "ButtonCompanyRefresh";
            this.ButtonCompanyRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonCompanyRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonCompanyRefresh.TabIndex = 71;
            this.ButtonCompanyRefresh.Click += new System.EventHandler(this.ButtonCompanyRefresh_Click);
            // 
            // ButtonSupplierCompanyNew
            // 
            this.ButtonSupplierCompanyNew.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonSupplierCompanyNew.Appearance.Options.UseBorderColor = true;
            this.ButtonSupplierCompanyNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSupplierCompanyNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSupplierCompanyNew.ImageOptions.SvgImage")));
            this.ButtonSupplierCompanyNew.Location = new System.Drawing.Point(21, 5);
            this.ButtonSupplierCompanyNew.Name = "ButtonSupplierCompanyNew";
            this.ButtonSupplierCompanyNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonSupplierCompanyNew.Size = new System.Drawing.Size(37, 32);
            this.ButtonSupplierCompanyNew.TabIndex = 71;
            this.ButtonSupplierCompanyNew.Click += new System.EventHandler(this.ButtonSupplierCompanyNew_Click);
            // 
            // ComboBoxSupplierCompany
            // 
            this.ComboBoxSupplierCompany.Location = new System.Drawing.Point(107, 11);
            this.ComboBoxSupplierCompany.Name = "ComboBoxSupplierCompany";
            this.ComboBoxSupplierCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSupplierCompany.Size = new System.Drawing.Size(163, 20);
            this.ComboBoxSupplierCompany.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(276, 14);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "شرکت :";
            // 
            // SupplierEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 275);
            this.Controls.Add(this.PersonInfoTab);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.customericon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "SupplierEdit";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonInfoTab)).EndInit();
            this.PersonInfoTab.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.SupplierInfoTab.ResumeLayout(false);
            this.SupplierInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSupplierCompany.Properties)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraTab.XtraTabControl PersonInfoTab;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage SupplierInfoTab;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxSupplierCompany;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton ButtonSupplierCompanyNew;
        private DevExpress.XtraEditors.SimpleButton ButtonCompanyRefresh;
    }
}