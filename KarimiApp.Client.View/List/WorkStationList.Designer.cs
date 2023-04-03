namespace KarimiApp.Client.View.List
{
    partial class WorkStationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkStationList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlWorkstation = new DevExpress.XtraGrid.GridControl();
            this.workStationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewWorkstation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIpAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdminButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiptsButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonWorkstationRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonWorkstationDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonWorkstationEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonWorkstationNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlWorkstation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkstation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsButtonEdit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlWorkstation);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(703, 310);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlWorkstation
            // 
            this.GridControlWorkstation.DataSource = this.workStationModelBindingSource;
            this.GridControlWorkstation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlWorkstation.Location = new System.Drawing.Point(2, 36);
            this.GridControlWorkstation.MainView = this.GridViewWorkstation;
            this.GridControlWorkstation.Name = "GridControlWorkstation";
            this.GridControlWorkstation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AdminButtonEdit,
            this.ReceiptsButtonEdit});
            this.GridControlWorkstation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlWorkstation.Size = new System.Drawing.Size(539, 272);
            this.GridControlWorkstation.TabIndex = 36;
            this.GridControlWorkstation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewWorkstation});
            // 
            // workStationModelBindingSource
            // 
            this.workStationModelBindingSource.DataSource = typeof(KarimiApp.Model.WorkstationModel);
            // 
            // GridViewWorkstation
            // 
            this.GridViewWorkstation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colIpAddress,
            this.colPort,
            this.colLastTotalPrice,
            this.colDepartment,
            this.gridColumn1,
            this.gridColumn2});
            this.GridViewWorkstation.GridControl = this.GridControlWorkstation;
            this.GridViewWorkstation.Name = "GridViewWorkstation";
            this.GridViewWorkstation.OptionsView.ShowGroupPanel = false;
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
            // colIpAddress
            // 
            this.colIpAddress.Caption = "آدرس آی پی";
            this.colIpAddress.FieldName = "IpAddress";
            this.colIpAddress.Name = "colIpAddress";
            this.colIpAddress.Visible = true;
            this.colIpAddress.VisibleIndex = 1;
            // 
            // colPort
            // 
            this.colPort.Caption = "پورت";
            this.colPort.FieldName = "Port";
            this.colPort.Name = "colPort";
            this.colPort.Visible = true;
            this.colPort.VisibleIndex = 2;
            // 
            // colLastTotalPrice
            // 
            this.colLastTotalPrice.Caption = "مبلغ آخرین فیش";
            this.colLastTotalPrice.DisplayFormat.FormatString = "#,#";
            this.colLastTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastTotalPrice.FieldName = "LastTotalPrice";
            this.colLastTotalPrice.Name = "colLastTotalPrice";
            this.colLastTotalPrice.Visible = true;
            this.colLastTotalPrice.VisibleIndex = 3;
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "دپارتمان";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "مدیریت";
            this.gridColumn1.ColumnEdit = this.AdminButtonEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // AdminButtonEdit
            // 
            this.AdminButtonEdit.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.AdminButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "مدیریت", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.AdminButtonEdit.Name = "AdminButtonEdit";
            this.AdminButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AdminButtonEdit.Click += new System.EventHandler(this.AdminButtonEdit_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "فیش ها";
            this.gridColumn2.ColumnEdit = this.ReceiptsButtonEdit;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // ReceiptsButtonEdit
            // 
            this.ReceiptsButtonEdit.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.ReceiptsButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "فیش ها", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ReceiptsButtonEdit.Name = "ReceiptsButtonEdit";
            this.ReceiptsButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ReceiptsButtonEdit.Click += new System.EventHandler(this.ReceiptsButtonEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 34);
            this.panel2.TabIndex = 35;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(230, 6);
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
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonWorkstationRefresh);
            this.panel1.Controls.Add(this.ButtonWorkstationDelete);
            this.panel1.Controls.Add(this.ButtonWorkstationEdit);
            this.panel1.Controls.Add(this.ButtonWorkstationNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(541, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 306);
            this.panel1.TabIndex = 18;
            // 
            // ButtonWorkstationRefresh
            // 
            this.ButtonWorkstationRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonWorkstationRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonWorkstationRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonWorkstationRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonWorkstationRefresh.ImageOptions.SvgImage")));
            this.ButtonWorkstationRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonWorkstationRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWorkstationRefresh.Name = "ButtonWorkstationRefresh";
            this.ButtonWorkstationRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonWorkstationRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonWorkstationRefresh.TabIndex = 0;
            this.ButtonWorkstationRefresh.Text = "بازنشانی";
            this.ButtonWorkstationRefresh.Click += new System.EventHandler(this.ButtonWorkStationRefresh_Click);
            // 
            // ButtonWorkstationDelete
            // 
            this.ButtonWorkstationDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonWorkstationDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonWorkstationDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonWorkstationDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonWorkstationDelete.ImageOptions.SvgImage")));
            this.ButtonWorkstationDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonWorkstationDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWorkstationDelete.Name = "ButtonWorkstationDelete";
            this.ButtonWorkstationDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonWorkstationDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonWorkstationDelete.TabIndex = 0;
            this.ButtonWorkstationDelete.Text = "حذف";
            this.ButtonWorkstationDelete.Click += new System.EventHandler(this.ButtonWorkStationDelete_Click);
            // 
            // ButtonWorkstationEdit
            // 
            this.ButtonWorkstationEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonWorkstationEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonWorkstationEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonWorkstationEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonWorkstationEdit.ImageOptions.SvgImage")));
            this.ButtonWorkstationEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonWorkstationEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWorkstationEdit.Name = "ButtonWorkstationEdit";
            this.ButtonWorkstationEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonWorkstationEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonWorkstationEdit.TabIndex = 0;
            this.ButtonWorkstationEdit.Text = "ویرایش";
            this.ButtonWorkstationEdit.Click += new System.EventHandler(this.ButtonWorkStationEdit_Click);
            // 
            // ButtonWorkstationNew
            // 
            this.ButtonWorkstationNew.Appearance.Options.UseTextOptions = true;
            this.ButtonWorkstationNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonWorkstationNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonWorkstationNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonWorkstationNew.ImageOptions.SvgImage")));
            this.ButtonWorkstationNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonWorkstationNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWorkstationNew.Name = "ButtonWorkstationNew";
            this.ButtonWorkstationNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonWorkstationNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonWorkstationNew.TabIndex = 0;
            this.ButtonWorkstationNew.Text = "جدید";
            this.ButtonWorkstationNew.Click += new System.EventHandler(this.ButtonWorkStationNew_Click);
            // 
            // WorkStationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "WorkStationList";
            this.Size = new System.Drawing.Size(703, 310);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlWorkstation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkstation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsButtonEdit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource workStationModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonWorkstationRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonWorkstationDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonWorkstationEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonWorkstationNew;
        private DevExpress.XtraGrid.GridControl GridControlWorkstation;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewWorkstation;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colIpAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPort;
        private DevExpress.XtraGrid.Columns.GridColumn colLastTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AdminButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ReceiptsButtonEdit;
    }
}