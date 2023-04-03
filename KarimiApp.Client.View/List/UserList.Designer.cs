using KarimiApp.Model;

namespace KarimiApp.Client.View.List
{
    partial class UserList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlUser = new DevExpress.XtraGrid.GridControl();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonUserRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlUser);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(856, 304);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlUser
            // 
            this.GridControlUser.DataSource = this.userModelBindingSource;
            this.GridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlUser.Location = new System.Drawing.Point(2, 36);
            this.GridControlUser.MainView = this.GridViewUser;
            this.GridControlUser.Name = "GridControlUser";
            this.GridControlUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlUser.Size = new System.Drawing.Size(692, 266);
            this.GridControlUser.TabIndex = 34;
            this.GridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewUser});
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(KarimiApp.Model.UserModel);
            // 
            // GridViewUser
            // 
            this.GridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Code,
            this.FirstName,
            this.Username,
            this.UserRole,
            this.PhoneNumber});
            this.GridViewUser.GridControl = this.GridControlUser;
            this.GridViewUser.Name = "GridViewUser";
            this.GridViewUser.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // Code
            // 
            this.Code.Caption = "کد کاربری";
            this.Code.FieldName = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "نام";
            this.FirstName.FieldName = "Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 1;
            // 
            // Username
            // 
            this.Username.Caption = "نام کاربری";
            this.Username.FieldName = "UserName";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 2;
            // 
            // UserRole
            // 
            this.UserRole.Caption = "نقش";
            this.UserRole.FieldName = "Role";
            this.UserRole.Name = "UserRole";
            this.UserRole.Visible = true;
            this.UserRole.VisibleIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "تلفن";
            this.PhoneNumber.FieldName = "MobileNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 34);
            this.panel2.TabIndex = 33;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(383, 6);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(245, 20);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.EditValueChanged += new System.EventHandler(this.TextBoxSearch_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonUserRefresh);
            this.panel1.Controls.Add(this.ButtonUserDelete);
            this.panel1.Controls.Add(this.ButtonUserEdit);
            this.panel1.Controls.Add(this.ButtonUserNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(694, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 300);
            this.panel1.TabIndex = 16;
            // 
            // ButtonUserRefresh
            // 
            this.ButtonUserRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonUserRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRefresh.ImageOptions.SvgImage")));
            this.ButtonUserRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonUserRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserRefresh.Name = "ButtonUserRefresh";
            this.ButtonUserRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonUserRefresh.TabIndex = 0;
            this.ButtonUserRefresh.Text = "بازنشانی";
            this.ButtonUserRefresh.Click += new System.EventHandler(this.ButtonUserRefresh_Click);
            // 
            // ButtonUserDelete
            // 
            this.ButtonUserDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonUserDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserDelete.ImageOptions.SvgImage")));
            this.ButtonUserDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonUserDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserDelete.Name = "ButtonUserDelete";
            this.ButtonUserDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonUserDelete.TabIndex = 0;
            this.ButtonUserDelete.Text = "حذف";
            this.ButtonUserDelete.Click += new System.EventHandler(this.ButtonUserDelete_Click);
            // 
            // ButtonUserEdit
            // 
            this.ButtonUserEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonUserEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserEdit.ImageOptions.SvgImage")));
            this.ButtonUserEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonUserEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserEdit.Name = "ButtonUserEdit";
            this.ButtonUserEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonUserEdit.TabIndex = 0;
            this.ButtonUserEdit.Text = "ویرایش";
            this.ButtonUserEdit.Click += new System.EventHandler(this.ButtonUserEdit_Click);
            // 
            // ButtonUserNew
            // 
            this.ButtonUserNew.Appearance.Options.UseTextOptions = true;
            this.ButtonUserNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserNew.ImageOptions.SvgImage")));
            this.ButtonUserNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonUserNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserNew.Name = "ButtonUserNew";
            this.ButtonUserNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonUserNew.TabIndex = 0;
            this.ButtonUserNew.Text = "جدید";
            this.ButtonUserNew.Click += new System.EventHandler(this.ButtonUserNew_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(856, 304);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonUserDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonUserEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonUserNew;
        private DevExpress.XtraGrid.GridControl GridControlUser;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewUser;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn UserRole;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userModelBindingSource;
    }
}