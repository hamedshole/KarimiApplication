namespace KarimiApp.Client.View.List
{
    partial class BatchList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.batchModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStorePayouts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemCashierVariant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAccountsValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSellWithoutCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnprnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.batchModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonPrint});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(831, 306);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // batchModelBindingSource
            // 
            this.batchModelBindingSource.DataSource = typeof(KarimiApp.Model.BatchModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStatus,
            this.colOpenTime,
            this.colCloseTime,
            this.colBatchUser,
            this.colCredit,
            this.colIncome,
            this.colStorePayouts,
            this.colSystemCashierVariant,
            this.colSystemSum,
            this.colTotalAccountsValue,
            this.colTotalSell,
            this.colTotalSellWithoutCredit,
            this.gridColumnprnt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "زمان باز کردن";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            // 
            // colOpenTime
            // 
            this.colOpenTime.Caption = "زمان باز کردن";
            this.colOpenTime.FieldName = "OpenTime";
            this.colOpenTime.Name = "colOpenTime";
            this.colOpenTime.Visible = true;
            this.colOpenTime.VisibleIndex = 2;
            // 
            // colCloseTime
            // 
            this.colCloseTime.Caption = "زمان بستن";
            this.colCloseTime.FieldName = "CloseTime";
            this.colCloseTime.Name = "colCloseTime";
            this.colCloseTime.Visible = true;
            this.colCloseTime.VisibleIndex = 1;
            // 
            // colBatchUser
            // 
            this.colBatchUser.Caption = "کاربر";
            this.colBatchUser.FieldName = "BatchUser";
            this.colBatchUser.Name = "colBatchUser";
            this.colBatchUser.Visible = true;
            this.colBatchUser.VisibleIndex = 3;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            // 
            // colIncome
            // 
            this.colIncome.FieldName = "Income";
            this.colIncome.Name = "colIncome";
            // 
            // colStorePayouts
            // 
            this.colStorePayouts.FieldName = "StorePayouts";
            this.colStorePayouts.Name = "colStorePayouts";
            // 
            // colSystemCashierVariant
            // 
            this.colSystemCashierVariant.FieldName = "SystemCashierVariant";
            this.colSystemCashierVariant.Name = "colSystemCashierVariant";
            // 
            // colSystemSum
            // 
            this.colSystemSum.FieldName = "SystemSum";
            this.colSystemSum.Name = "colSystemSum";
            // 
            // colTotalAccountsValue
            // 
            this.colTotalAccountsValue.FieldName = "TotalAccountsValue";
            this.colTotalAccountsValue.Name = "colTotalAccountsValue";
            // 
            // colTotalSell
            // 
            this.colTotalSell.FieldName = "TotalSell";
            this.colTotalSell.Name = "colTotalSell";
            // 
            // colTotalSellWithoutCredit
            // 
            this.colTotalSellWithoutCredit.FieldName = "TotalSellWithoutCredit";
            this.colTotalSellWithoutCredit.Name = "colTotalSellWithoutCredit";
            // 
            // gridColumnprnt
            // 
            this.gridColumnprnt.Caption = "gridColumn1";
            this.gridColumnprnt.ColumnEdit = this.ButtonPrint;
            this.gridColumnprnt.Name = "gridColumnprnt";
            this.gridColumnprnt.Visible = true;
            this.gridColumnprnt.VisibleIndex = 4;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.ButtonPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonPrint_ButtonClick);
            // 
            // BatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 306);
            this.Controls.Add(this.gridControl1);
            this.Name = "BatchList";
            this.Text = "BatchList";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource batchModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colStorePayouts;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemCashierVariant;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemSum;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAccountsValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSell;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSellWithoutCredit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnprnt;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonPrint;
    }
}