namespace KarimiApp.Client.View.List
{
    partial class InventoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlInventory = new DevExpress.XtraGrid.GridControl();
            this.inventoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeeper = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonInventoryRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlInventory);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(792, 380);
            this.PanelControlGridControl.TabIndex = 10;
            // 
            // GridControlInventory
            // 
            this.GridControlInventory.DataSource = this.inventoryModelBindingSource;
            this.GridControlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlInventory.Location = new System.Drawing.Point(2, 36);
            this.GridControlInventory.MainView = this.GridViewInventory;
            this.GridControlInventory.Name = "GridControlInventory";
            this.GridControlInventory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlInventory.Size = new System.Drawing.Size(628, 342);
            this.GridControlInventory.TabIndex = 24;
            this.GridControlInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInventory});
            // 
            // inventoryModelBindingSource
            // 
            this.inventoryModelBindingSource.DataSource = typeof(KarimiApp.Model.InventoryModel);
            // 
            // GridViewInventory
            // 
            this.GridViewInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colDescription,
            this.colKeeper,
            this.colInventoryType,
            this.colActive});
            this.GridViewInventory.GridControl = this.GridControlInventory;
            this.GridViewInventory.Name = "GridViewInventory";
            this.GridViewInventory.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colTitle
            // 
            this.colTitle.Caption = "نام";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "توضیحات";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 203;
            // 
            // colKeeper
            // 
            this.colKeeper.Caption = "مسئول انبار";
            this.colKeeper.FieldName = "Keeper";
            this.colKeeper.Name = "colKeeper";
            this.colKeeper.Visible = true;
            this.colKeeper.VisibleIndex = 1;
            this.colKeeper.Width = 150;
            // 
            // colInventoryType
            // 
            this.colInventoryType.Caption = "نوع انبار";
            this.colInventoryType.FieldName = "Group";
            this.colInventoryType.Name = "colInventoryType";
            this.colInventoryType.Visible = true;
            this.colInventoryType.VisibleIndex = 2;
            this.colInventoryType.Width = 100;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 34);
            this.panel2.TabIndex = 23;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(319, 6);
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
            this.label1.Location = new System.Drawing.Point(570, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonInventoryRefresh);
            this.panel1.Controls.Add(this.ButtonInventoryDelete);
            this.panel1.Controls.Add(this.ButtonInventoryEdit);
            this.panel1.Controls.Add(this.ButtonInventoryNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 376);
            this.panel1.TabIndex = 6;
            // 
            // ButtonInventoryRefresh
            // 
            this.ButtonInventoryRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryRefresh.ImageOptions.SvgImage")));
            this.ButtonInventoryRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonInventoryRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryRefresh.Name = "ButtonInventoryRefresh";
            this.ButtonInventoryRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryRefresh.TabIndex = 0;
            this.ButtonInventoryRefresh.Text = "بازنشانی";
            this.ButtonInventoryRefresh.Click += new System.EventHandler(this.ButtonInventoryRefresh_Click);
            // 
            // ButtonInventoryDelete
            // 
            this.ButtonInventoryDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryDelete.ImageOptions.SvgImage")));
            this.ButtonInventoryDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonInventoryDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryDelete.Name = "ButtonInventoryDelete";
            this.ButtonInventoryDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryDelete.TabIndex = 0;
            this.ButtonInventoryDelete.Text = "حذف";
            this.ButtonInventoryDelete.Click += new System.EventHandler(this.ButtonInventoryDelete_Click);
            // 
            // ButtonInventoryEdit
            // 
            this.ButtonInventoryEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryEdit.ImageOptions.SvgImage")));
            this.ButtonInventoryEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonInventoryEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryEdit.Name = "ButtonInventoryEdit";
            this.ButtonInventoryEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryEdit.TabIndex = 0;
            this.ButtonInventoryEdit.Text = "ویرایش";
            this.ButtonInventoryEdit.Click += new System.EventHandler(this.ButtonInventoryEdit_Click);
            // 
            // ButtonInventoryNew
            // 
            this.ButtonInventoryNew.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryNew.ImageOptions.SvgImage")));
            this.ButtonInventoryNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonInventoryNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryNew.Name = "ButtonInventoryNew";
            this.ButtonInventoryNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryNew.TabIndex = 0;
            this.ButtonInventoryNew.Text = "جدید";
            this.ButtonInventoryNew.Click += new System.EventHandler(this.ButtonInventoryNew_Click);
            // 
            // InventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "InventoryList";
            this.Size = new System.Drawing.Size(792, 380);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource inventoryModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryNew;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl GridControlInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colKeeper;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryType;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}