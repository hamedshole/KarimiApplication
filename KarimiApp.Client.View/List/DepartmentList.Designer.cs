namespace KarimiApp.Client.View.List
{
    partial class DepartmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlDepartment = new DevExpress.XtraGrid.GridControl();
            this.departmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCustomerRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmentDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmentEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmentNew = new DevExpress.XtraEditors.SimpleButton();
            this.colDefaultInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartment)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlDepartment);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(831, 390);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlDepartment
            // 
            this.GridControlDepartment.DataSource = this.departmentModelBindingSource;
            this.GridControlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlDepartment.Location = new System.Drawing.Point(2, 36);
            this.GridControlDepartment.MainView = this.GridViewDepartment;
            this.GridControlDepartment.Name = "GridControlDepartment";
            this.GridControlDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlDepartment.Size = new System.Drawing.Size(667, 352);
            this.GridControlDepartment.TabIndex = 14;
            this.GridControlDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDepartment});
            // 
            // departmentModelBindingSource
            // 
            this.departmentModelBindingSource.DataSource = typeof(KarimiApp.Model.DepartmentModel);
            // 
            // GridViewDepartment
            // 
            this.GridViewDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDefaultInventory,
            this.colDescription,
            this.colActive});
            this.GridViewDepartment.GridControl = this.GridControlDepartment;
            this.GridViewDepartment.Name = "GridViewDepartment";
            this.GridViewDepartment.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "نام";
            this.colName.FieldName = "Title";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "توضیحات";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 278;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 121;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 34);
            this.panel2.TabIndex = 13;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(358, 6);
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
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCustomerRefresh);
            this.panel1.Controls.Add(this.ButtonDepartmentDelete);
            this.panel1.Controls.Add(this.ButtonDepartmentEdit);
            this.panel1.Controls.Add(this.ButtonDepartmentNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(669, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 386);
            this.panel1.TabIndex = 5;
            // 
            // ButtonCustomerRefresh
            // 
            this.ButtonCustomerRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCustomerRefresh.ImageOptions.SvgImage")));
            this.ButtonCustomerRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonCustomerRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerRefresh.Name = "ButtonCustomerRefresh";
            this.ButtonCustomerRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonCustomerRefresh.TabIndex = 0;
            this.ButtonCustomerRefresh.Text = "بازنشانی";
            this.ButtonCustomerRefresh.Click += new System.EventHandler(this.ButtonDepartmentRefresh_Click);
            // 
            // ButtonDepartmentDelete
            // 
            this.ButtonDepartmentDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonDepartmentDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonDepartmentDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonDepartmentDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDepartmentDelete.ImageOptions.SvgImage")));
            this.ButtonDepartmentDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonDepartmentDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDepartmentDelete.Name = "ButtonDepartmentDelete";
            this.ButtonDepartmentDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDepartmentDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonDepartmentDelete.TabIndex = 0;
            this.ButtonDepartmentDelete.Text = "حذف";
            this.ButtonDepartmentDelete.Click += new System.EventHandler(this.ButtonDepartmentDelete_Click);
            // 
            // ButtonDepartmentEdit
            // 
            this.ButtonDepartmentEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonDepartmentEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonDepartmentEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonDepartmentEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDepartmentEdit.ImageOptions.SvgImage")));
            this.ButtonDepartmentEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonDepartmentEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDepartmentEdit.Name = "ButtonDepartmentEdit";
            this.ButtonDepartmentEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDepartmentEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonDepartmentEdit.TabIndex = 0;
            this.ButtonDepartmentEdit.Text = "ویرایش";
            this.ButtonDepartmentEdit.Click += new System.EventHandler(this.ButtonDepartmentEdit_Click);
            // 
            // ButtonDepartmentNew
            // 
            this.ButtonDepartmentNew.Appearance.Options.UseTextOptions = true;
            this.ButtonDepartmentNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonDepartmentNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonDepartmentNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDepartmentNew.ImageOptions.SvgImage")));
            this.ButtonDepartmentNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonDepartmentNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDepartmentNew.Name = "ButtonDepartmentNew";
            this.ButtonDepartmentNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDepartmentNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonDepartmentNew.TabIndex = 0;
            this.ButtonDepartmentNew.Text = "جدید";
            this.ButtonDepartmentNew.Click += new System.EventHandler(this.ButtonDepartmentNew_Click);
            // 
            // colDefaultInventory
            // 
            this.colDefaultInventory.Caption = "انبار پیش فرض";
            this.colDefaultInventory.FieldName = "DefaultInventory";
            this.colDefaultInventory.Name = "colDefaultInventory";
            this.colDefaultInventory.Visible = true;
            this.colDefaultInventory.VisibleIndex = 1;
            // 
            // DepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "DepartmentList";
            this.Size = new System.Drawing.Size(831, 390);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource departmentModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmentDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmentEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmentNew;
        private DevExpress.XtraGrid.GridControl GridControlDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultInventory;
    }
}