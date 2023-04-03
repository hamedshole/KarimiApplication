namespace KarimiApp.Client.View.Edit
{
    partial class AddInventoryItemDetail
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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInventoryItemDetail));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.inventoryLogModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxStock = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxDepartment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxSellPrice = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxWeighed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxBuyPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxBarcode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.inventoryLogModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 161);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(766, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inventoryLogModelBindingSource
            // 
            this.inventoryLogModelBindingSource.DataSource = typeof(KarimiApp.Model.InventoryLogModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInventory,
            this.colItem,
            this.colIo,
            this.colRecordTime,
            this.colBuyPrice,
            this.colSellPrice,
            this.colAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInventory
            // 
            this.colInventory.Caption = "انبار";
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            this.colInventory.Visible = true;
            this.colInventory.VisibleIndex = 1;
            this.colInventory.Width = 79;
            // 
            // colItem
            // 
            this.colItem.Caption = "کالا";
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            this.colItem.Width = 172;
            // 
            // colIo
            // 
            this.colIo.Caption = "خرید/فروش";
            this.colIo.FieldName = "Io";
            this.colIo.Name = "colIo";
            this.colIo.Visible = true;
            this.colIo.VisibleIndex = 2;
            this.colIo.Width = 61;
            // 
            // colRecordTime
            // 
            this.colRecordTime.Caption = "زمان";
            this.colRecordTime.FieldName = "RecordTime";
            this.colRecordTime.Name = "colRecordTime";
            this.colRecordTime.Visible = true;
            this.colRecordTime.VisibleIndex = 6;
            this.colRecordTime.Width = 93;
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.Caption = "قیمت خرید";
            this.colBuyPrice.DisplayFormat.FormatString = "#,# ریال";
            this.colBuyPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBuyPrice.FieldName = "BuyPrice";
            this.colBuyPrice.Name = "colBuyPrice";
            this.colBuyPrice.Visible = true;
            this.colBuyPrice.VisibleIndex = 3;
            this.colBuyPrice.Width = 82;
            // 
            // colSellPrice
            // 
            this.colSellPrice.Caption = "قیمت فروش";
            this.colSellPrice.DisplayFormat.FormatString = "#,# ریال";
            this.colSellPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSellPrice.FieldName = "SellPrice";
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.Visible = true;
            this.colSellPrice.VisibleIndex = 4;
            this.colSellPrice.Width = 82;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "مقدار";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            this.colAmount.Width = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کالا :";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.itemModelBindingSource;
            this.listBoxControl1.DisplayMember = "Name";
            this.listBoxControl1.ItemHeight = 32;
            this.listBoxControl1.Location = new System.Drawing.Point(201, 33);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(375, 141);
            this.listBoxControl1.TabIndex = 4;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.FieldName = "Name";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "Name";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "Barcode";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "Barcode";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "template1";
            tableRowDefinition1.Length.Value = 15D;
            tableRowDefinition2.Length.Value = 13D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            this.listBoxControl1.Templates.Add(itemTemplateBase1);
            this.listBoxControl1.ValueMember = "Name";
            this.listBoxControl1.Visible = false;
            // 
            // itemModelBindingSource
            // 
            this.itemModelBindingSource.DataSource = typeof(KarimiApp.Model.ItemModel);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(201, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(375, 21);
            this.TextBoxSearch.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TextBoxDepartment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxSellPrice);
            this.groupBox1.Controls.Add(this.TextBoxCategory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxWeighed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxBuyPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBoxBarcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(742, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کالا";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.TextBoxStock);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(6, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 28);
            this.panel1.TabIndex = 1;
            // 
            // TextBoxStock
            // 
            this.TextBoxStock.AutoSize = true;
            this.TextBoxStock.Location = new System.Drawing.Point(20, 7);
            this.TextBoxStock.Name = "TextBoxStock";
            this.TextBoxStock.Size = new System.Drawing.Size(71, 13);
            this.TextBoxStock.TabIndex = 0;
            this.TextBoxStock.Text = "................";
            this.TextBoxStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "موجودی :";
            // 
            // TextBoxDepartment
            // 
            this.TextBoxDepartment.AutoSize = true;
            this.TextBoxDepartment.Location = new System.Drawing.Point(296, 85);
            this.TextBoxDepartment.Name = "TextBoxDepartment";
            this.TextBoxDepartment.Size = new System.Drawing.Size(71, 13);
            this.TextBoxDepartment.TabIndex = 0;
            this.TextBoxDepartment.Text = "................";
            this.TextBoxDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "غرفه :";
            // 
            // TextBoxSellPrice
            // 
            this.TextBoxSellPrice.AutoSize = true;
            this.TextBoxSellPrice.Location = new System.Drawing.Point(296, 55);
            this.TextBoxSellPrice.Name = "TextBoxSellPrice";
            this.TextBoxSellPrice.Size = new System.Drawing.Size(71, 13);
            this.TextBoxSellPrice.TabIndex = 0;
            this.TextBoxSellPrice.Text = "................";
            this.TextBoxSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.AutoSize = true;
            this.TextBoxCategory.Location = new System.Drawing.Point(26, 27);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(71, 13);
            this.TextBoxCategory.TabIndex = 0;
            this.TextBoxCategory.Text = "................";
            this.TextBoxCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "قیمت فروش :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "دسته کالا :";
            // 
            // TextBoxWeighed
            // 
            this.TextBoxWeighed.AutoSize = true;
            this.TextBoxWeighed.Location = new System.Drawing.Point(540, 85);
            this.TextBoxWeighed.Name = "TextBoxWeighed";
            this.TextBoxWeighed.Size = new System.Drawing.Size(71, 13);
            this.TextBoxWeighed.TabIndex = 0;
            this.TextBoxWeighed.Text = "................";
            this.TextBoxWeighed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "نوع کالا :";
            // 
            // TextBoxBuyPrice
            // 
            this.TextBoxBuyPrice.AutoSize = true;
            this.TextBoxBuyPrice.Location = new System.Drawing.Point(540, 55);
            this.TextBoxBuyPrice.Name = "TextBoxBuyPrice";
            this.TextBoxBuyPrice.Size = new System.Drawing.Size(71, 13);
            this.TextBoxBuyPrice.TabIndex = 0;
            this.TextBoxBuyPrice.Text = "................";
            this.TextBoxBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "قیمت خرید :";
            // 
            // TextBoxBarcode
            // 
            this.TextBoxBarcode.AutoSize = true;
            this.TextBoxBarcode.Location = new System.Drawing.Point(296, 27);
            this.TextBoxBarcode.Name = "TextBoxBarcode";
            this.TextBoxBarcode.Size = new System.Drawing.Size(71, 13);
            this.TextBoxBarcode.TabIndex = 0;
            this.TextBoxBarcode.Text = "................";
            this.TextBoxBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "بارکد :";
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoSize = true;
            this.TextBoxName.Location = new System.Drawing.Point(540, 27);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(71, 13);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Text = "................";
            this.TextBoxName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 34);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "افزودن";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AddInventoryItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 361);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "AddInventoryItemDetail";
            this.Text = "AddInventoryItem";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource inventoryLogModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIo;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.BindingSource itemModelBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextBoxStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TextBoxSellPrice;
        private System.Windows.Forms.Label TextBoxCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TextBoxBuyPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TextBoxDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TextBoxWeighed;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label TextBoxBarcode;
        private System.Windows.Forms.Label label5;
    }
}