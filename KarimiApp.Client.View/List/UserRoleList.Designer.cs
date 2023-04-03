namespace KarimiApp.Client.View.List
{
    partial class UserRoleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlUserRole = new DevExpress.XtraGrid.GridControl();
            this.userRoleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewUserRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonUserRoleRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserRoleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserRoleEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUserRoleNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUserRole)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlUserRole);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(670, 193);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlUserRole
            // 
            this.GridControlUserRole.DataSource = this.userRoleModelBindingSource;
            this.GridControlUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlUserRole.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridControlUserRole.Location = new System.Drawing.Point(2, 28);
            this.GridControlUserRole.MainView = this.GridViewUserRole;
            this.GridControlUserRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridControlUserRole.Name = "GridControlUserRole";
            this.GridControlUserRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlUserRole.Size = new System.Drawing.Size(506, 163);
            this.GridControlUserRole.TabIndex = 35;
            this.GridControlUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewUserRole});
            // 
            // userRoleModelBindingSource
            // 
            this.userRoleModelBindingSource.DataSource = typeof(KarimiApp.Model.UserRoleModel);
            // 
            // GridViewUserRole
            // 
            this.GridViewUserRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colInfo});
            this.GridViewUserRole.DetailHeight = 268;
            this.GridViewUserRole.GridControl = this.GridControlUserRole;
            this.GridViewUserRole.Name = "GridViewUserRole";
            this.GridViewUserRole.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ردیف";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 102;
            // 
            // colName
            // 
            this.colName.Caption = "عنوان";
            this.colName.FieldName = "Title";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 316;
            // 
            // colInfo
            // 
            this.colInfo.Caption = "اطلاعات";
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.ShowUnboundExpressionMenu = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 26);
            this.panel2.TabIndex = 34;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(197, 5);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(448, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonUserRoleRefresh);
            this.panel1.Controls.Add(this.ButtonUserRoleDelete);
            this.panel1.Controls.Add(this.ButtonUserRoleEdit);
            this.panel1.Controls.Add(this.ButtonUserRoleNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(508, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 189);
            this.panel1.TabIndex = 17;
            // 
            // ButtonUserRoleRefresh
            // 
            this.ButtonUserRoleRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonUserRoleRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserRoleRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserRoleRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRoleRefresh.ImageOptions.SvgImage")));
            this.ButtonUserRoleRefresh.Location = new System.Drawing.Point(10, 122);
            this.ButtonUserRoleRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserRoleRefresh.Name = "ButtonUserRoleRefresh";
            this.ButtonUserRoleRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserRoleRefresh.Size = new System.Drawing.Size(140, 31);
            this.ButtonUserRoleRefresh.TabIndex = 0;
            this.ButtonUserRoleRefresh.Text = "بازنشانی";
            this.ButtonUserRoleRefresh.Click += new System.EventHandler(this.ButtonUserRoleRefresh_Click);
            // 
            // ButtonUserRoleDelete
            // 
            this.ButtonUserRoleDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonUserRoleDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserRoleDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserRoleDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRoleDelete.ImageOptions.SvgImage")));
            this.ButtonUserRoleDelete.Location = new System.Drawing.Point(10, 84);
            this.ButtonUserRoleDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserRoleDelete.Name = "ButtonUserRoleDelete";
            this.ButtonUserRoleDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserRoleDelete.Size = new System.Drawing.Size(140, 31);
            this.ButtonUserRoleDelete.TabIndex = 0;
            this.ButtonUserRoleDelete.Text = "حذف";
            this.ButtonUserRoleDelete.Click += new System.EventHandler(this.ButtonUserRoleDelete_Click);
            // 
            // ButtonUserRoleEdit
            // 
            this.ButtonUserRoleEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonUserRoleEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserRoleEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserRoleEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRoleEdit.ImageOptions.SvgImage")));
            this.ButtonUserRoleEdit.Location = new System.Drawing.Point(10, 46);
            this.ButtonUserRoleEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserRoleEdit.Name = "ButtonUserRoleEdit";
            this.ButtonUserRoleEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserRoleEdit.Size = new System.Drawing.Size(140, 31);
            this.ButtonUserRoleEdit.TabIndex = 0;
            this.ButtonUserRoleEdit.Text = "ویرایش";
            this.ButtonUserRoleEdit.Click += new System.EventHandler(this.ButtonUserRoleEdit_Click);
            // 
            // ButtonUserRoleNew
            // 
            this.ButtonUserRoleNew.Appearance.Options.UseTextOptions = true;
            this.ButtonUserRoleNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonUserRoleNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonUserRoleNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonUserRoleNew.ImageOptions.SvgImage")));
            this.ButtonUserRoleNew.Location = new System.Drawing.Point(10, 8);
            this.ButtonUserRoleNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserRoleNew.Name = "ButtonUserRoleNew";
            this.ButtonUserRoleNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonUserRoleNew.Size = new System.Drawing.Size(140, 31);
            this.ButtonUserRoleNew.TabIndex = 0;
            this.ButtonUserRoleNew.Text = "جدید";
            this.ButtonUserRoleNew.Click += new System.EventHandler(this.ButtonUserRoleNew_Click);
            // 
            // UserRoleList
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "UserRoleList";
            this.Size = new System.Drawing.Size(670, 193);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUserRole)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource userRoleModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRoleRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRoleDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRoleEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonUserRoleNew;
        private DevExpress.XtraGrid.GridControl GridControlUserRole;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}