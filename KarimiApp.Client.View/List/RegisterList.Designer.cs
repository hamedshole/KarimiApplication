namespace KarimiApp.Client.View.List
{
    partial class RegisterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.registerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRegisterRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRegisterDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRegisterEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRegisterNew = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridControlRegister = new DevExpress.XtraGrid.GridControl();
            this.GridViewRegister = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComputerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIpAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMacAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlRegister);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(853, 317);
            this.PanelControlGridControl.TabIndex = 10;
            // 
            // registerModelBindingSource
            // 
            this.registerModelBindingSource.DataSource = typeof(Model.RegisterModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonRegisterRefresh);
            this.panel1.Controls.Add(this.ButtonRegisterDelete);
            this.panel1.Controls.Add(this.ButtonRegisterEdit);
            this.panel1.Controls.Add(this.ButtonRegisterNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(691, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 313);
            this.panel1.TabIndex = 14;
            // 
            // ButtonRegisterRefresh
            // 
            this.ButtonRegisterRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonRegisterRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonRegisterRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonRegisterRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRegisterRefresh.ImageOptions.SvgImage")));
            this.ButtonRegisterRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonRegisterRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRegisterRefresh.Name = "ButtonRegisterRefresh";
            this.ButtonRegisterRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonRegisterRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonRegisterRefresh.TabIndex = 0;
            this.ButtonRegisterRefresh.Text = "بازنشانی";
            this.ButtonRegisterRefresh.Click += new System.EventHandler(this.ButtonRegisterRefresh_Click);
            // 
            // ButtonRegisterDelete
            // 
            this.ButtonRegisterDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonRegisterDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonRegisterDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonRegisterDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRegisterDelete.ImageOptions.SvgImage")));
            this.ButtonRegisterDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonRegisterDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRegisterDelete.Name = "ButtonRegisterDelete";
            this.ButtonRegisterDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonRegisterDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonRegisterDelete.TabIndex = 0;
            this.ButtonRegisterDelete.Text = "حذف";
            this.ButtonRegisterDelete.Click += new System.EventHandler(this.ButtonRegisterDelete_Click);
            // 
            // ButtonRegisterEdit
            // 
            this.ButtonRegisterEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonRegisterEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonRegisterEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonRegisterEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRegisterEdit.ImageOptions.SvgImage")));
            this.ButtonRegisterEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonRegisterEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRegisterEdit.Name = "ButtonRegisterEdit";
            this.ButtonRegisterEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonRegisterEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonRegisterEdit.TabIndex = 0;
            this.ButtonRegisterEdit.Text = "ویرایش";
            this.ButtonRegisterEdit.Click += new System.EventHandler(this.ButtonRegisterEdit_Click);
            // 
            // ButtonRegisterNew
            // 
            this.ButtonRegisterNew.Appearance.Options.UseTextOptions = true;
            this.ButtonRegisterNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonRegisterNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonRegisterNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRegisterNew.ImageOptions.SvgImage")));
            this.ButtonRegisterNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonRegisterNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRegisterNew.Name = "ButtonRegisterNew";
            this.ButtonRegisterNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonRegisterNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonRegisterNew.TabIndex = 0;
            this.ButtonRegisterNew.Text = "جدید";
            this.ButtonRegisterNew.Click += new System.EventHandler(this.ButtonRegisterNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 34);
            this.panel2.TabIndex = 31;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(380, 6);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(245, 36);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.EditValueChanged += new System.EventHandler(this.TextBoxSearch_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(631, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // GridControlRegister
            // 
            this.GridControlRegister.DataSource = this.registerModelBindingSource;
            this.GridControlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlRegister.Location = new System.Drawing.Point(2, 36);
            this.GridControlRegister.MainView = this.GridViewRegister;
            this.GridControlRegister.Name = "GridControlRegister";
            this.GridControlRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlRegister.Size = new System.Drawing.Size(689, 279);
            this.GridControlRegister.TabIndex = 32;
            this.GridControlRegister.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewRegister});
            // 
            // GridViewRegister
            // 
            this.GridViewRegister.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colComputerName,
            this.colDescription,
            this.colIpAddress,
            this.colMacAddress,
            this.colActive});
            this.GridViewRegister.GridControl = this.GridControlRegister;
            this.GridViewRegister.Name = "GridViewRegister";
            this.GridViewRegister.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colTitle
            // 
            this.colTitle.Caption = "عنوان";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colComputerName
            // 
            this.colComputerName.Caption = "نام سیستم";
            this.colComputerName.FieldName = "ComputerName";
            this.colComputerName.Name = "colComputerName";
            this.colComputerName.Visible = true;
            this.colComputerName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "توضیحات";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colIpAddress
            // 
            this.colIpAddress.Caption = "آی پی";
            this.colIpAddress.FieldName = "IpAddress";
            this.colIpAddress.Name = "colIpAddress";
            this.colIpAddress.Visible = true;
            this.colIpAddress.VisibleIndex = 3;
            // 
            // colMacAddress
            // 
            this.colMacAddress.Caption = "آدرس مک";
            this.colMacAddress.FieldName = "MacAddress";
            this.colMacAddress.Name = "colMacAddress";
            this.colMacAddress.Visible = true;
            this.colMacAddress.VisibleIndex = 4;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            // 
            // RegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "RegisterList";
            this.Size = new System.Drawing.Size(853, 317);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource registerModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterNew;
        private DevExpress.XtraGrid.GridControl GridControlRegister;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewRegister;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colComputerName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIpAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMacAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}