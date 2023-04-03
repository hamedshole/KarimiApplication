namespace KarimiApp.Client.View.List
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlCustomer = new DevExpress.XtraGrid.GridControl();
            this.GridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCustomerRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCustomerDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCustomerEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCustomerNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(KarimiApp.Model.PersonModel);
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlCustomer);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(950, 371);
            this.PanelControlGridControl.TabIndex = 6;
            // 
            // GridControlCustomer
            // 
            this.GridControlCustomer.DataSource = this.customerModelBindingSource;
            this.GridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlCustomer.Location = new System.Drawing.Point(2, 36);
            this.GridControlCustomer.MainView = this.GridViewCustomer;
            this.GridControlCustomer.Name = "GridControlCustomer";
            this.GridControlCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlCustomer.Size = new System.Drawing.Size(761, 333);
            this.GridControlCustomer.TabIndex = 13;
            this.GridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCustomer});
            // 
            // GridViewCustomer
            // 
            this.GridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colFirstName,
            this.colPhoneNumber,
            this.colActive,
            this.colBalance});
            this.GridViewCustomer.GridControl = this.GridControlCustomer;
            this.GridViewCustomer.Name = "GridViewCustomer";
            this.GridViewCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCode
            // 
            this.colCode.Caption = "کد مشتری";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "نام";
            this.colFirstName.FieldName = "Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "تلفن";
            this.colPhoneNumber.FieldName = "MobileNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "حساب";
            this.colBalance.DisplayFormat.FormatString = "#,# ریال";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 34);
            this.panel2.TabIndex = 12;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(452, 6);
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
            this.label1.Location = new System.Drawing.Point(703, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.ButtonCustomerRefresh);
            this.panel1.Controls.Add(this.ButtonCustomerDelete);
            this.panel1.Controls.Add(this.ButtonCustomerEdit);
            this.panel1.Controls.Add(this.ButtonCustomerNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(763, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 367);
            this.panel1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(10, 160);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "تسویه";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ButtonCustomerRefresh
            // 
            this.ButtonCustomerRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCustomerRefresh.ImageOptions.SvgImage")));
            this.ButtonCustomerRefresh.Location = new System.Drawing.Point(10, 210);
            this.ButtonCustomerRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerRefresh.Name = "ButtonCustomerRefresh";
            this.ButtonCustomerRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerRefresh.Size = new System.Drawing.Size(163, 40);
            this.ButtonCustomerRefresh.TabIndex = 0;
            this.ButtonCustomerRefresh.Text = "بازنشانی";
            this.ButtonCustomerRefresh.Click += new System.EventHandler(this.ButtonCustomerRefresh_Click);
            // 
            // ButtonCustomerDelete
            // 
            this.ButtonCustomerDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCustomerDelete.ImageOptions.SvgImage")));
            this.ButtonCustomerDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonCustomerDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerDelete.Name = "ButtonCustomerDelete";
            this.ButtonCustomerDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerDelete.Size = new System.Drawing.Size(163, 40);
            this.ButtonCustomerDelete.TabIndex = 0;
            this.ButtonCustomerDelete.Text = "حذف";
            this.ButtonCustomerDelete.Click += new System.EventHandler(this.ButtonCustomerDelete_Click);
            // 
            // ButtonCustomerEdit
            // 
            this.ButtonCustomerEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCustomerEdit.ImageOptions.SvgImage")));
            this.ButtonCustomerEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonCustomerEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerEdit.Name = "ButtonCustomerEdit";
            this.ButtonCustomerEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerEdit.Size = new System.Drawing.Size(163, 40);
            this.ButtonCustomerEdit.TabIndex = 0;
            this.ButtonCustomerEdit.Text = "ویرایش";
            this.ButtonCustomerEdit.Click += new System.EventHandler(this.ButtonCustomerEdit_Click);
            // 
            // ButtonCustomerNew
            // 
            this.ButtonCustomerNew.Appearance.Options.UseTextOptions = true;
            this.ButtonCustomerNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCustomerNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCustomerNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCustomerNew.ImageOptions.SvgImage")));
            this.ButtonCustomerNew.Location = new System.Drawing.Point(10, 9);
            this.ButtonCustomerNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCustomerNew.Name = "ButtonCustomerNew";
            this.ButtonCustomerNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCustomerNew.Size = new System.Drawing.Size(163, 40);
            this.ButtonCustomerNew.TabIndex = 0;
            this.ButtonCustomerNew.Text = "جدید";
            this.ButtonCustomerNew.Click += new System.EventHandler(this.ButtonCustomerNew_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "CustomerList";
            this.Size = new System.Drawing.Size(950, 371);
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource customerModelBindingSource;
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonCustomerNew;
        private DevExpress.XtraGrid.GridControl GridControlCustomer;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}