namespace KarimiApp.Client.View.Edit
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
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
            this.UserInfoTab = new DevExpress.XtraTab.XtraTabPage();
            this.ButtonUserRoleRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserRole = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxUserRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxUsername = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonInfoTab)).BeginInit();
            this.PersonInfoTab.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.UserInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxUserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(36, 63);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(163, 20);
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
            this.TextBoxFirstName.Size = new System.Drawing.Size(163, 20);
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
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 307);
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
            this.PersonInfoTab.Size = new System.Drawing.Size(352, 307);
            this.PersonInfoTab.TabIndex = 64;
            this.PersonInfoTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.UserInfoTab});
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
            this.xtraTabPage1.Size = new System.Drawing.Size(326, 305);
            this.xtraTabPage1.Text = "اطلاعات فردی";
            // 
            // UserInfoTab
            // 
            this.UserInfoTab.Controls.Add(this.ButtonUserRoleRefresh);
            this.UserInfoTab.Controls.Add(this.ButtonUserRole);
            this.UserInfoTab.Controls.Add(this.ComboBoxUserRole);
            this.UserInfoTab.Controls.Add(this.TextBoxUsername);
            this.UserInfoTab.Controls.Add(this.label1);
            this.UserInfoTab.Controls.Add(this.label4);
            this.UserInfoTab.Controls.Add(this.label3);
            this.UserInfoTab.Controls.Add(this.TextBoxPassword);
            this.UserInfoTab.Name = "UserInfoTab";
            this.UserInfoTab.Size = new System.Drawing.Size(326, 305);
            this.UserInfoTab.Text = "اطلاعات کاربری";
            // 
            // ButtonUserRoleRefresh
            // 
            this.ButtonUserRoleRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonUserRoleRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonUserRoleRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonUserRoleRefresh.Location = new System.Drawing.Point(54, 65);
            this.ButtonUserRoleRefresh.Name = "ButtonUserRoleRefresh";
            this.ButtonUserRoleRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonUserRoleRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonUserRoleRefresh.TabIndex = 71;
            this.ButtonUserRoleRefresh.Click += new System.EventHandler(this.ButtonUserRoleRefresh_Click);
            // 
            // ButtonUserRole
            // 
            this.ButtonUserRole.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonUserRole.Appearance.Options.UseBorderColor = true;
            this.ButtonUserRole.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonUserRole.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRole.ImageOptions.SvgImage")));
            this.ButtonUserRole.Location = new System.Drawing.Point(8, 65);
            this.ButtonUserRole.Name = "ButtonUserRole";
            this.ButtonUserRole.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonUserRole.Size = new System.Drawing.Size(37, 32);
            this.ButtonUserRole.TabIndex = 71;
            this.ButtonUserRole.Click += new System.EventHandler(this.ButtonUserRole_Click);
            // 
            // ComboBoxUserRole
            // 
            this.ComboBoxUserRole.Location = new System.Drawing.Point(97, 71);
            this.ComboBoxUserRole.Name = "ComboBoxUserRole";
            this.ComboBoxUserRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxUserRole.Size = new System.Drawing.Size(163, 20);
            this.ComboBoxUserRole.TabIndex = 22;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(97, 10);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(163, 20);
            this.TextBoxUsername.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "نام کاربری :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(259, 74);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "نقش :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(259, 39);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "رمز عبور :";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(97, 36);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(163, 20);
            this.TextBoxPassword.TabIndex = 21;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 307);
            this.Controls.Add(this.PersonInfoTab);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.customericon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "UserEdit";
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
            this.UserInfoTab.ResumeLayout(false);
            this.UserInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxUserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage UserInfoTab;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxUserRole;
        private DevExpress.XtraEditors.TextEdit TextBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TextBoxPassword;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRole;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRoleRefresh;
    }
}