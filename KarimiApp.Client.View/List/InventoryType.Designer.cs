namespace KarimiApp.Client.View.List
{
    partial class InventoryTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTypeList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.inventoryTypeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonItemRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryTypeDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryTypeEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryTypeNew = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridControlInventoryType = new DevExpress.XtraGrid.GridControl();
            this.GridViewInventoryType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypeModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInventoryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventoryType)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlInventoryType);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(880, 385);
            this.PanelControlGridControl.TabIndex = 10;
            // 
            // inventoryTypeModelBindingSource
            // 
            this.inventoryTypeModelBindingSource.DataSource = typeof(Model.InventoryGroupModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonItemRefresh);
            this.panel1.Controls.Add(this.ButtonInventoryTypeDelete);
            this.panel1.Controls.Add(this.ButtonInventoryTypeEdit);
            this.panel1.Controls.Add(this.ButtonInventoryTypeNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(718, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 381);
            this.panel1.TabIndex = 7;
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
            this.ButtonItemRefresh.Click += new System.EventHandler(this.ButtonInventoryTypeRefresh_Click);
            // 
            // ButtonInventoryTypeDelete
            // 
            this.ButtonInventoryTypeDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryTypeDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryTypeDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryTypeDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryTypeDelete.ImageOptions.SvgImage")));
            this.ButtonInventoryTypeDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonInventoryTypeDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryTypeDelete.Name = "ButtonInventoryTypeDelete";
            this.ButtonInventoryTypeDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryTypeDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryTypeDelete.TabIndex = 0;
            this.ButtonInventoryTypeDelete.Text = "حذف";
            this.ButtonInventoryTypeDelete.Click += new System.EventHandler(this.ButtonInventoryTypeDelete_Click);
            // 
            // ButtonInventoryTypeEdit
            // 
            this.ButtonInventoryTypeEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryTypeEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryTypeEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryTypeEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryTypeEdit.ImageOptions.SvgImage")));
            this.ButtonInventoryTypeEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonInventoryTypeEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryTypeEdit.Name = "ButtonInventoryTypeEdit";
            this.ButtonInventoryTypeEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryTypeEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryTypeEdit.TabIndex = 0;
            this.ButtonInventoryTypeEdit.Text = "ویرایش";
            this.ButtonInventoryTypeEdit.Click += new System.EventHandler(this.ButtonInventoryTypeEdit_Click);
            // 
            // ButtonInventoryTypeNew
            // 
            this.ButtonInventoryTypeNew.Appearance.Options.UseTextOptions = true;
            this.ButtonInventoryTypeNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonInventoryTypeNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonInventoryTypeNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryTypeNew.ImageOptions.SvgImage")));
            this.ButtonInventoryTypeNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonInventoryTypeNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInventoryTypeNew.Name = "ButtonInventoryTypeNew";
            this.ButtonInventoryTypeNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonInventoryTypeNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonInventoryTypeNew.TabIndex = 0;
            this.ButtonInventoryTypeNew.Text = "جدید";
            this.ButtonInventoryTypeNew.Click += new System.EventHandler(this.ButtonInventoryTypeNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 34);
            this.panel2.TabIndex = 24;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(407, 6);
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
            this.label1.Location = new System.Drawing.Point(658, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // GridControlInventoryType
            // 
            this.GridControlInventoryType.DataSource = this.inventoryTypeModelBindingSource;
            this.GridControlInventoryType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlInventoryType.Location = new System.Drawing.Point(2, 36);
            this.GridControlInventoryType.MainView = this.GridViewInventoryType;
            this.GridControlInventoryType.Name = "GridControlInventoryType";
            this.GridControlInventoryType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlInventoryType.Size = new System.Drawing.Size(716, 347);
            this.GridControlInventoryType.TabIndex = 25;
            this.GridControlInventoryType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInventoryType});
            // 
            // GridViewInventoryType
            // 
            this.GridViewInventoryType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colDescription,
            this.colActive});
            this.GridViewInventoryType.GridControl = this.GridControlInventoryType;
            this.GridViewInventoryType.Name = "GridViewInventoryType";
            this.GridViewInventoryType.OptionsView.ShowGroupPanel = false;
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
            // InventoryTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "InventoryTypeList";
            this.Size = new System.Drawing.Size(880, 385);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypeModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInventoryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventoryType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource inventoryTypeModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonItemRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryTypeDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryTypeEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryTypeNew;
        private DevExpress.XtraGrid.GridControl GridControlInventoryType;
        public DevExpress.XtraGrid.Views.Grid.GridView GridViewInventoryType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}