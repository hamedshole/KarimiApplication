namespace KarimiApp.Client.View.List
{
    partial class PosInfoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosInfoList));
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlPosInfo = new DevExpress.XtraGrid.GridControl();
            this.posInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewPosInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPosInfoRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPosInfoDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPosInfoEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPosInfoNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPosInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posInfoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPosInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlPosInfo);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(822, 382);
            this.PanelControlGridControl.TabIndex = 12;
            // 
            // GridControlPosInfo
            // 
            this.GridControlPosInfo.DataSource = this.posInfoModelBindingSource;
            this.GridControlPosInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlPosInfo.Location = new System.Drawing.Point(2, 36);
            this.GridControlPosInfo.MainView = this.GridViewPosInfo;
            this.GridControlPosInfo.Name = "GridControlPosInfo";
            this.GridControlPosInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlPosInfo.Size = new System.Drawing.Size(658, 344);
            this.GridControlPosInfo.TabIndex = 31;
            this.GridControlPosInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPosInfo});
            // 
            // posInfoModelBindingSource
            // 
            this.posInfoModelBindingSource.DataSource = typeof(KarimiApp.Model.PosInfoModel);
            // 
            // GridViewPosInfo
            // 
            this.GridViewPosInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colCom});
            this.GridViewPosInfo.GridControl = this.GridControlPosInfo;
            this.GridViewPosInfo.Name = "GridViewPosInfo";
            this.GridViewPosInfo.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ردیف";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "عنوان";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colCom
            // 
            this.colCom.Caption = "شماره کام";
            this.colCom.FieldName = "Com";
            this.colCom.Name = "colCom";
            this.colCom.Visible = true;
            this.colCom.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 34);
            this.panel2.TabIndex = 30;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(349, 6);
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
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonPosInfoRefresh);
            this.panel1.Controls.Add(this.ButtonPosInfoDelete);
            this.panel1.Controls.Add(this.ButtonPosInfoEdit);
            this.panel1.Controls.Add(this.ButtonPosInfoNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(660, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 378);
            this.panel1.TabIndex = 13;
            // 
            // ButtonPosInfoRefresh
            // 
            this.ButtonPosInfoRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonPosInfoRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPosInfoRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPosInfoRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosInfoRefresh.ImageOptions.SvgImage")));
            this.ButtonPosInfoRefresh.Location = new System.Drawing.Point(10, 160);
            this.ButtonPosInfoRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPosInfoRefresh.Name = "ButtonPosInfoRefresh";
            this.ButtonPosInfoRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPosInfoRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonPosInfoRefresh.TabIndex = 0;
            this.ButtonPosInfoRefresh.Text = "بازنشانی";
            this.ButtonPosInfoRefresh.Click += new System.EventHandler(this.ButtonPosInfoRefresh_Click);
            // 
            // ButtonPosInfoDelete
            // 
            this.ButtonPosInfoDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonPosInfoDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPosInfoDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPosInfoDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosInfoDelete.ImageOptions.SvgImage")));
            this.ButtonPosInfoDelete.Location = new System.Drawing.Point(10, 110);
            this.ButtonPosInfoDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPosInfoDelete.Name = "ButtonPosInfoDelete";
            this.ButtonPosInfoDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPosInfoDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonPosInfoDelete.TabIndex = 0;
            this.ButtonPosInfoDelete.Text = "حذف";
            this.ButtonPosInfoDelete.Click += new System.EventHandler(this.ButtonPosInfoDelete_Click);
            // 
            // ButtonPosInfoEdit
            // 
            this.ButtonPosInfoEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonPosInfoEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPosInfoEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPosInfoEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosInfoEdit.ImageOptions.SvgImage")));
            this.ButtonPosInfoEdit.Location = new System.Drawing.Point(10, 60);
            this.ButtonPosInfoEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPosInfoEdit.Name = "ButtonPosInfoEdit";
            this.ButtonPosInfoEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPosInfoEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonPosInfoEdit.TabIndex = 0;
            this.ButtonPosInfoEdit.Text = "ویرایش";
            this.ButtonPosInfoEdit.Click += new System.EventHandler(this.ButtonPosInfoEdit_Click);
            // 
            // ButtonPosInfoNew
            // 
            this.ButtonPosInfoNew.Appearance.Options.UseTextOptions = true;
            this.ButtonPosInfoNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonPosInfoNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonPosInfoNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonPosInfoNew.ImageOptions.SvgImage")));
            this.ButtonPosInfoNew.Location = new System.Drawing.Point(10, 10);
            this.ButtonPosInfoNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPosInfoNew.Name = "ButtonPosInfoNew";
            this.ButtonPosInfoNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPosInfoNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonPosInfoNew.TabIndex = 0;
            this.ButtonPosInfoNew.Text = "جدید";
            this.ButtonPosInfoNew.Click += new System.EventHandler(this.ButtonPosInfoNew_Click);
            // 
            // PosInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PosInfoList";
            this.Size = new System.Drawing.Size(822, 382);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPosInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posInfoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPosInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.BindingSource posInfoModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonPosInfoRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonPosInfoDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonPosInfoEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonPosInfoNew;
        private DevExpress.XtraGrid.GridControl GridControlPosInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewPosInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCom;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}