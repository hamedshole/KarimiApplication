namespace KarimiApp.Client.View.List
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlItem = new DevExpress.XtraGrid.GridControl();
            this.inventoryItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeighed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonItemRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemNew = new DevExpress.XtraEditors.SimpleButton();
            this.colMemory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewItem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlItem);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(804, 310);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlItem
            // 
            this.GridControlItem.DataSource = this.inventoryItemModelBindingSource;
            this.GridControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlItem.Location = new System.Drawing.Point(2, 36);
            this.GridControlItem.MainView = this.GridViewItem;
            this.GridControlItem.Name = "GridControlItem";
            this.GridControlItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlItem.Size = new System.Drawing.Size(640, 272);
            this.GridControlItem.TabIndex = 27;
            this.GridControlItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewItem});
            // 
            // inventoryItemModelBindingSource
            // 
            this.inventoryItemModelBindingSource.DataSource = typeof(KarimiApp.Model.ItemModel);
            // 
            // GridViewItem
            // 
            this.GridViewItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colBarcode,
            this.colDepartment,
            this.colCategory,
            this.colName,
            this.colWeighed,
            this.colSellPrice,
            this.colActive,
            this.colBuyPrice,
            this.colStock,
            this.colMemory});
            this.GridViewItem.GridControl = this.GridControlItem;
            this.GridViewItem.Name = "GridViewItem";
            this.GridViewItem.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCode
            // 
            this.colCode.Caption = "کد کالا";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "بارکد";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 1;
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "غرفه";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 2;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "دسته کالا";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.Caption = "نام کالا";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            // 
            // colWeighed
            // 
            this.colWeighed.Caption = "وزنی";
            this.colWeighed.FieldName = "Weighed";
            this.colWeighed.Name = "colWeighed";
            this.colWeighed.Visible = true;
            this.colWeighed.VisibleIndex = 5;
            // 
            // colSellPrice
            // 
            this.colSellPrice.Caption = "قیمت فروش";
            this.colSellPrice.DisplayFormat.FormatString = "#,# ریال";
            this.colSellPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSellPrice.FieldName = "SellPrice";
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.Visible = true;
            this.colSellPrice.VisibleIndex = 8;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.Caption = "قیمت خرید";
            this.colBuyPrice.DisplayFormat.FormatString = "#,# ریال";
            this.colBuyPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBuyPrice.FieldName = "BuyPrice";
            this.colBuyPrice.Name = "colBuyPrice";
            this.colBuyPrice.Visible = true;
            this.colBuyPrice.VisibleIndex = 7;
            // 
            // colStock
            // 
            this.colStock.Caption = "موجودی";
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 34);
            this.panel2.TabIndex = 26;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(331, 6);
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
            this.label1.Location = new System.Drawing.Point(582, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonItemRefresh);
            this.panel1.Controls.Add(this.ButtonItemDelete);
            this.panel1.Controls.Add(this.ButtonItemEdit);
            this.panel1.Controls.Add(this.ButtonItemNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(642, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 306);
            this.panel1.TabIndex = 9;
            // 
            // ButtonItemRefresh
            // 
            this.ButtonItemRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonItemRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemRefresh.ImageOptions.SvgImage")));
            this.ButtonItemRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonItemRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemRefresh.Name = "ButtonItemRefresh";
            this.ButtonItemRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemRefresh.TabIndex = 0;
            this.ButtonItemRefresh.Text = "بازنشانی";
            this.ButtonItemRefresh.Click += new System.EventHandler(this.ButtonItemRefresh_Click);
            // 
            // ButtonItemDelete
            // 
            this.ButtonItemDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonItemDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemDelete.ImageOptions.SvgImage")));
            this.ButtonItemDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonItemDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemDelete.Name = "ButtonItemDelete";
            this.ButtonItemDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemDelete.TabIndex = 0;
            this.ButtonItemDelete.Text = "حذف";
            this.ButtonItemDelete.Click += new System.EventHandler(this.ButtonItemDelete_Click);
            // 
            // ButtonItemEdit
            // 
            this.ButtonItemEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonItemEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemEdit.ImageOptions.SvgImage")));
            this.ButtonItemEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonItemEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemEdit.Name = "ButtonItemEdit";
            this.ButtonItemEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemEdit.TabIndex = 0;
            this.ButtonItemEdit.Text = "ویرایش";
            this.ButtonItemEdit.Click += new System.EventHandler(this.ButtonItemEdit_Click);
            // 
            // ButtonItemNew
            // 
            this.ButtonItemNew.Appearance.Options.UseTextOptions = true;
            this.ButtonItemNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemNew.ImageOptions.SvgImage")));
            this.ButtonItemNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonItemNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemNew.Name = "ButtonItemNew";
            this.ButtonItemNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemNew.TabIndex = 0;
            this.ButtonItemNew.Text = "جدید";
            this.ButtonItemNew.Click += new System.EventHandler(this.ButtonItemNew_Click);
            // 
            // colMemory
            // 
            this.colMemory.Caption = "حافظه";
            this.colMemory.FieldName = "Memory";
            this.colMemory.Name = "colMemory";
            this.colMemory.Visible = true;
            this.colMemory.VisibleIndex = 0;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "ItemList";
            this.Size = new System.Drawing.Size(804, 310);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource inventoryItemModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonItemRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonItemDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonItemEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonItemNew;
        private DevExpress.XtraGrid.GridControl GridControlItem;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewItem;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colWeighed;
        private DevExpress.XtraGrid.Columns.GridColumn colSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyPrice;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colMemory;
    }
}