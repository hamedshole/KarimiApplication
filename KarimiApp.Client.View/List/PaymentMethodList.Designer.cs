namespace KarimiApp.Client.View.List
{
    partial class PaymentMethodList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlPaymentMethod = new DevExpress.XtraGrid.GridControl();
            this.paymentMethodModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewPaymentMethod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPaymentMethodRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentMethodDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentMethodEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPaymentMethodNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaymentMethod)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlPaymentMethod);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(821, 296);
            this.PanelControlGridControl.TabIndex = 12;
            // 
            // GridControlPaymentMethod
            // 
            this.GridControlPaymentMethod.DataSource = this.paymentMethodModelBindingSource;
            this.GridControlPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlPaymentMethod.Location = new System.Drawing.Point(2, 36);
            this.GridControlPaymentMethod.MainView = this.GridViewPaymentMethod;
            this.GridControlPaymentMethod.Name = "GridControlPaymentMethod";
            this.GridControlPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlPaymentMethod.Size = new System.Drawing.Size(657, 258);
            this.GridControlPaymentMethod.TabIndex = 28;
            this.GridControlPaymentMethod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPaymentMethod});
            // 
            // paymentMethodModelBindingSource
            // 
            this.paymentMethodModelBindingSource.DataSource = typeof(KarimiApp.Model.PaymentMethodModel);
            // 
            // GridViewPaymentMethod
            // 
            this.GridViewPaymentMethod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colActive,
            this.colPaymentType,
            this.colPos});
            this.GridViewPaymentMethod.GridControl = this.GridControlPaymentMethod;
            this.GridViewPaymentMethod.Name = "GridViewPaymentMethod";
            this.GridViewPaymentMethod.OptionsView.ShowGroupPanel = false;
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
            this.colTitle.Width = 202;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 201;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "نوع پرداخت";
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 1;
            this.colPaymentType.Width = 112;
            // 
            // colPos
            // 
            this.colPos.Caption = "کارتخوان متصل";
            this.colPos.FieldName = "Pos";
            this.colPos.Name = "colPos";
            this.colPos.Visible = true;
            this.colPos.VisibleIndex = 2;
            this.colPos.Width = 117;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 34);
            this.panel2.TabIndex = 27;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(348, 6);
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
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonPaymentMethodRefresh);
            this.panel1.Controls.Add(this.ButtonPaymentMethodDelete);
            this.panel1.Controls.Add(this.ButtonPaymentMethodEdit);
            this.panel1.Controls.Add(this.ButtonPaymentMethodNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(659, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 292);
            this.panel1.TabIndex = 10;
            // 
            // ButtonPaymentMethodRefresh
            // 
            this.ButtonPaymentMethodRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentMethodRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentMethodRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentMethodRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentMethodRefresh.ImageOptions.SvgImage")));
            this.ButtonPaymentMethodRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonPaymentMethodRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentMethodRefresh.Name = "ButtonPaymentMethodRefresh";
            this.ButtonPaymentMethodRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentMethodRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentMethodRefresh.TabIndex = 0;
            this.ButtonPaymentMethodRefresh.Text = "بازنشانی";
            this.ButtonPaymentMethodRefresh.Click += new System.EventHandler(this.ButtonPaymentMethodRefresh_Click);
            // 
            // ButtonPaymentMethodDelete
            // 
            this.ButtonPaymentMethodDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentMethodDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentMethodDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentMethodDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentMethodDelete.ImageOptions.SvgImage")));
            this.ButtonPaymentMethodDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonPaymentMethodDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentMethodDelete.Name = "ButtonPaymentMethodDelete";
            this.ButtonPaymentMethodDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentMethodDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentMethodDelete.TabIndex = 0;
            this.ButtonPaymentMethodDelete.Text = "حذف";
            this.ButtonPaymentMethodDelete.Click += new System.EventHandler(this.ButtonPaymentMethodDelete_Click);
            // 
            // ButtonPaymentMethodEdit
            // 
            this.ButtonPaymentMethodEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentMethodEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentMethodEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentMethodEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentMethodEdit.ImageOptions.SvgImage")));
            this.ButtonPaymentMethodEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonPaymentMethodEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentMethodEdit.Name = "ButtonPaymentMethodEdit";
            this.ButtonPaymentMethodEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentMethodEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentMethodEdit.TabIndex = 0;
            this.ButtonPaymentMethodEdit.Text = "ویرایش";
            this.ButtonPaymentMethodEdit.Click += new System.EventHandler(this.ButtonPaymentMethodEdit_Click);
            // 
            // ButtonPaymentMethodNew
            // 
            this.ButtonPaymentMethodNew.Appearance.Options.UseTextOptions = true;
            this.ButtonPaymentMethodNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPaymentMethodNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPaymentMethodNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPaymentMethodNew.ImageOptions.SvgImage")));
            this.ButtonPaymentMethodNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonPaymentMethodNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPaymentMethodNew.Name = "ButtonPaymentMethodNew";
            this.ButtonPaymentMethodNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPaymentMethodNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonPaymentMethodNew.TabIndex = 0;
            this.ButtonPaymentMethodNew.Text = "جدید";
            this.ButtonPaymentMethodNew.Click += new System.EventHandler(this.ButtonPaymentMethodNew_Click);
            // 
            // PaymentMethodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PaymentMethodList";
            this.Size = new System.Drawing.Size(821, 296);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaymentMethod)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource paymentMethodModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentMethodRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentMethodDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentMethodEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonPaymentMethodNew;
        private DevExpress.XtraGrid.GridControl GridControlPaymentMethod;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colPos;
    }
}