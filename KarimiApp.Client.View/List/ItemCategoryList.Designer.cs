namespace KarimiApp.Client.View.List
{
    partial class ItemCategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCategoryList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.inventoryItemCategoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonItemRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemCategoryDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemCategoryEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonItemCategoryNew = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridControlItemCategory = new DevExpress.XtraGrid.GridControl();
            this.GridVIewItemCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemCategoryModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlItemCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVIewItemCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlItemCategory);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(827, 384);
            this.PanelControlGridControl.TabIndex = 10;
            // 
            // inventoryItemCategoryModelBindingSource
            // 
            this.inventoryItemCategoryModelBindingSource.DataSource = typeof(Model.ItemCategoryModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonItemRefresh);
            this.panel1.Controls.Add(this.ButtonItemCategoryDelete);
            this.panel1.Controls.Add(this.ButtonItemCategoryEdit);
            this.panel1.Controls.Add(this.ButtonItemCategoryNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(665, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 380);
            this.panel1.TabIndex = 8;
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
            this.ButtonItemRefresh.Click += new System.EventHandler(this.ButtonItemCategoryRefresh_Click);
            // 
            // ButtonItemCategoryDelete
            // 
            this.ButtonItemCategoryDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonItemCategoryDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemCategoryDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemCategoryDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemCategoryDelete.ImageOptions.SvgImage")));
            this.ButtonItemCategoryDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonItemCategoryDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemCategoryDelete.Name = "ButtonItemCategoryDelete";
            this.ButtonItemCategoryDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemCategoryDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemCategoryDelete.TabIndex = 0;
            this.ButtonItemCategoryDelete.Text = "حذف";
            this.ButtonItemCategoryDelete.Click += new System.EventHandler(this.ButtonItemCategoryDelete_Click);
            // 
            // ButtonItemCategoryEdit
            // 
            this.ButtonItemCategoryEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonItemCategoryEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemCategoryEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemCategoryEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemCategoryEdit.ImageOptions.SvgImage")));
            this.ButtonItemCategoryEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonItemCategoryEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemCategoryEdit.Name = "ButtonItemCategoryEdit";
            this.ButtonItemCategoryEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemCategoryEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemCategoryEdit.TabIndex = 0;
            this.ButtonItemCategoryEdit.Text = "ویرایش";
            this.ButtonItemCategoryEdit.Click += new System.EventHandler(this.ButtonItemCategoryEdit_Click);
            // 
            // ButtonItemCategoryNew
            // 
            this.ButtonItemCategoryNew.Appearance.Options.UseTextOptions = true;
            this.ButtonItemCategoryNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonItemCategoryNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonItemCategoryNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonItemCategoryNew.ImageOptions.SvgImage")));
            this.ButtonItemCategoryNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonItemCategoryNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonItemCategoryNew.Name = "ButtonItemCategoryNew";
            this.ButtonItemCategoryNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonItemCategoryNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonItemCategoryNew.TabIndex = 0;
            this.ButtonItemCategoryNew.Text = "جدید";
            this.ButtonItemCategoryNew.Click += new System.EventHandler(this.ButtonItemCategoryNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 34);
            this.panel2.TabIndex = 25;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(354, 6);
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
            this.label1.Location = new System.Drawing.Point(605, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // GridControlItemCategory
            // 
            this.GridControlItemCategory.DataSource = this.inventoryItemCategoryModelBindingSource;
            this.GridControlItemCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlItemCategory.Location = new System.Drawing.Point(2, 36);
            this.GridControlItemCategory.MainView = this.GridVIewItemCategory;
            this.GridControlItemCategory.Name = "GridControlItemCategory";
            this.GridControlItemCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlItemCategory.Size = new System.Drawing.Size(663, 346);
            this.GridControlItemCategory.TabIndex = 26;
            this.GridControlItemCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridVIewItemCategory});
            // 
            // GridVIewItemCategory
            // 
            this.GridVIewItemCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colDescription,
            this.colActive});
            this.GridVIewItemCategory.GridControl = this.GridControlItemCategory;
            this.GridVIewItemCategory.Name = "GridVIewItemCategory";
            this.GridVIewItemCategory.OptionsView.ShowGroupPanel = false;
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
            // colDescription
            // 
            this.colDescription.Caption = "توضیحات";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colActive
            // 
            this.colActive.Caption = "فعال";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            // 
            // ItemCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "ItemCategoryList";
            this.Size = new System.Drawing.Size(827, 384);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemCategoryModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlItemCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVIewItemCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource inventoryItemCategoryModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonItemRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonItemCategoryDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonItemCategoryEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonItemCategoryNew;
        private DevExpress.XtraGrid.GridControl GridControlItemCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView GridVIewItemCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}