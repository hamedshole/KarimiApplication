namespace KarimiApp.Client.View.List
{
    partial class PaymentTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentTypeList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.paymentTypeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPaymentTypeRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentTypeDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentTypeEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentTypeNew = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridControlPaymentType = new DevExpress.XtraGrid.GridControl();
            this.GridViewPaymentType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlPaymentType);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(818, 277);
            this.PanelControlGridControl.TabIndex = 10;
            // 
            // paymentTypeModelBindingSource
            // 
            this.paymentTypeModelBindingSource.DataSource = typeof(Model.PaymentTypeModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonPaymentTypeRefresh);
            this.panel1.Controls.Add(this.ButtonPaymentTypeDelete);
            this.panel1.Controls.Add(this.ButtonPaymentTypeEdit);
            this.panel1.Controls.Add(this.ButtonPaymentTypeNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(656, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 273);
            this.panel1.TabIndex = 11;
            // 
            // ButtonPaymentTypeRefresh
            // 
            this.ButtonPaymentTypeRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentTypeRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentTypeRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentTypeRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentTypeRefresh.ImageOptions.SvgImage")));
            this.ButtonPaymentTypeRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonPaymentTypeRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentTypeRefresh.Name = "ButtonPaymentTypeRefresh";
            this.ButtonPaymentTypeRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentTypeRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentTypeRefresh.TabIndex = 0;
            this.ButtonPaymentTypeRefresh.Text = "بازنشانی";
            this.ButtonPaymentTypeRefresh.Click += new System.EventHandler(this.ButtonItemRefresh_Click);
            // 
            // ButtonPaymentTypeDelete
            // 
            this.ButtonPaymentTypeDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentTypeDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentTypeDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentTypeDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentTypeDelete.ImageOptions.SvgImage")));
            this.ButtonPaymentTypeDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonPaymentTypeDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentTypeDelete.Name = "ButtonPaymentTypeDelete";
            this.ButtonPaymentTypeDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentTypeDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentTypeDelete.TabIndex = 0;
            this.ButtonPaymentTypeDelete.Text = "حذف";
            this.ButtonPaymentTypeDelete.Click += new System.EventHandler(this.ButtonPaymentTypeDelete_Click);
            // 
            // ButtonPaymentTypeEdit
            // 
            this.ButtonPaymentTypeEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentTypeEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentTypeEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentTypeEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentTypeEdit.ImageOptions.SvgImage")));
            this.ButtonPaymentTypeEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonPaymentTypeEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentTypeEdit.Name = "ButtonPaymentTypeEdit";
            this.ButtonPaymentTypeEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentTypeEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentTypeEdit.TabIndex = 0;
            this.ButtonPaymentTypeEdit.Text = "ویرایش";
            this.ButtonPaymentTypeEdit.Click += new System.EventHandler(this.ButtonPaymentTypeEdit_Click);
            // 
            // ButtonPaymentTypeNew
            // 
            this.ButtonPaymentTypeNew.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentTypeNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentTypeNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentTypeNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentTypeNew.ImageOptions.SvgImage")));
            this.ButtonPaymentTypeNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonPaymentTypeNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentTypeNew.Name = "ButtonPaymentTypeNew";
            this.ButtonPaymentTypeNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentTypeNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentTypeNew.TabIndex = 0;
            this.ButtonPaymentTypeNew.Text = "جدید";
            this.ButtonPaymentTypeNew.Click += new System.EventHandler(this.ButtonPaymentTypeNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 34);
            this.panel2.TabIndex = 28;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(345, 6);
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
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // GridControlPaymentType
            // 
            this.GridControlPaymentType.DataSource = this.paymentTypeModelBindingSource;
            this.GridControlPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlPaymentType.Location = new System.Drawing.Point(2, 36);
            this.GridControlPaymentType.MainView = this.GridViewPaymentType;
            this.GridControlPaymentType.Name = "GridControlPaymentType";
            this.GridControlPaymentType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlPaymentType.Size = new System.Drawing.Size(654, 239);
            this.GridControlPaymentType.TabIndex = 29;
            this.GridControlPaymentType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPaymentType});
            // 
            // GridViewPaymentType
            // 
            this.GridViewPaymentType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colActive});
            this.GridViewPaymentType.GridControl = this.GridControlPaymentType;
            this.GridViewPaymentType.Name = "GridViewPaymentType";
            this.GridViewPaymentType.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "عنوان";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 231;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 1;
            this.colActive.Width = 101;
            // 
            // PaymentTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PaymentTypeList";
            this.Size = new System.Drawing.Size(818, 277);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaymentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource paymentTypeModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentTypeRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentTypeDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentTypeEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentTypeNew;
        private DevExpress.XtraGrid.GridControl GridControlPaymentType;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}