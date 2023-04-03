namespace KarimiApp.Client.View.List
{
    partial class PayoutTransactionList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayoutTransactionList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelControlGridControl = new DevExpress.XtraEditors.PanelControl();
            this.GridControlPayout = new DevExpress.XtraGrid.GridControl();
            this.payoutTransactionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewPayout = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBatchUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBatchRegister = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRecordTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateTimePickerStart = new Atf.UI.DateTimeSelector();
            this.DateTimePickerEnd = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonTransactionPayoutRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonTransactionPayoutDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonTransactionPayoutEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonTransactionPayoutNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).BeginInit();
            this.PanelControlGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payoutTransactionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPayout)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // PanelControlGridControl
            // 
            this.PanelControlGridControl.Controls.Add(this.GridControlPayout);
            this.PanelControlGridControl.Controls.Add(this.panel2);
            this.PanelControlGridControl.Controls.Add(this.panel1);
            this.PanelControlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlGridControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControlGridControl.Name = "PanelControlGridControl";
            this.PanelControlGridControl.Size = new System.Drawing.Size(831, 390);
            this.PanelControlGridControl.TabIndex = 8;
            // 
            // GridControlPayout
            // 
            this.GridControlPayout.DataSource = this.payoutTransactionModelBindingSource;
            this.GridControlPayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlPayout.Location = new System.Drawing.Point(2, 84);
            this.GridControlPayout.MainView = this.GridViewPayout;
            this.GridControlPayout.Name = "GridControlPayout";
            this.GridControlPayout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridControlPayout.Size = new System.Drawing.Size(667, 304);
            this.GridControlPayout.TabIndex = 30;
            this.GridControlPayout.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPayout});
            // 
            // payoutTransactionModelBindingSource
            // 
            this.payoutTransactionModelBindingSource.DataSource = typeof(KarimiApp.Model.PayoutTransactionModel);
            // 
            // GridViewPayout
            // 
            this.GridViewPayout.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridViewPayout.Appearance.EvenRow.Options.UseBackColor = true;
            this.GridViewPayout.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewPayout.Appearance.GroupPanel.Options.UseFont = true;
            this.GridViewPayout.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GridViewPayout.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewPayout.Appearance.GroupRow.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.GridViewPayout.Appearance.GroupRow.Options.UseBackColor = true;
            this.GridViewPayout.Appearance.GroupRow.Options.UseFont = true;
            this.GridViewPayout.Appearance.GroupRow.Options.UseForeColor = true;
            this.GridViewPayout.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridViewPayout.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.Silver;
            this.GridViewPayout.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Maroon;
            this.GridViewPayout.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewPayout.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.GridViewPayout.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GridViewPayout.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GridViewPayout.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewPayout.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridViewPayout.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GridViewPayout.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewPayout.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewPayout.Appearance.Row.Options.UseFont = true;
            this.GridViewPayout.Appearance.Row.Options.UseTextOptions = true;
            this.GridViewPayout.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewPayout.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnBatch,
            this.gridColumnBatchUser,
            this.gridColumnBatchRegister,
            this.gridColumnValue,
            this.gridColumnDescription,
            this.gridColumnPerson,
            this.gridColumnRecordTime,
            this.gridColumnSerial,
            this.gridColumnDate});
            this.GridViewPayout.GridControl = this.GridControlPayout;
            this.GridViewPayout.GroupCount = 1;
            this.GridViewPayout.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Value", null, "مجموع: {0:c0}", "مجموع"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Value", null, "تعداد: {0:0}", "تعداد")});
            this.GridViewPayout.Name = "GridViewPayout";
            this.GridViewPayout.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewPayout.OptionsView.ShowFooter = true;
            this.GridViewPayout.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "ردیف";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            this.gridColumnId.Width = 74;
            // 
            // gridColumnBatch
            // 
            this.gridColumnBatch.Caption = "شیفت";
            this.gridColumnBatch.FieldName = "Batch";
            this.gridColumnBatch.Name = "gridColumnBatch";
            this.gridColumnBatch.Visible = true;
            this.gridColumnBatch.VisibleIndex = 1;
            this.gridColumnBatch.Width = 74;
            // 
            // gridColumnBatchUser
            // 
            this.gridColumnBatchUser.Caption = "کاربر";
            this.gridColumnBatchUser.FieldName = "BatchUser";
            this.gridColumnBatchUser.Name = "gridColumnBatchUser";
            this.gridColumnBatchUser.Visible = true;
            this.gridColumnBatchUser.VisibleIndex = 2;
            this.gridColumnBatchUser.Width = 65;
            // 
            // gridColumnBatchRegister
            // 
            this.gridColumnBatchRegister.Caption = "سیستم";
            this.gridColumnBatchRegister.FieldName = "BatchRegister";
            this.gridColumnBatchRegister.Name = "gridColumnBatchRegister";
            this.gridColumnBatchRegister.Width = 87;
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "مبلغ";
            this.gridColumnValue.DisplayFormat.FormatString = "#,# ریال";
            this.gridColumnValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnValue.FieldName = "Value";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 5;
            this.gridColumnValue.Width = 87;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "توضیحات";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 4;
            this.gridColumnDescription.Width = 234;
            // 
            // gridColumnPerson
            // 
            this.gridColumnPerson.Caption = "شخص";
            this.gridColumnPerson.FieldName = "Person";
            this.gridColumnPerson.Name = "gridColumnPerson";
            this.gridColumnPerson.Width = 87;
            // 
            // gridColumnRecordTime
            // 
            this.gridColumnRecordTime.Caption = "زمان";
            this.gridColumnRecordTime.DisplayFormat.FormatString = "HH:mm";
            this.gridColumnRecordTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnRecordTime.FieldName = "RecordTime";
            this.gridColumnRecordTime.Name = "gridColumnRecordTime";
            this.gridColumnRecordTime.Visible = true;
            this.gridColumnRecordTime.VisibleIndex = 3;
            this.gridColumnRecordTime.Width = 108;
            // 
            // gridColumnSerial
            // 
            this.gridColumnSerial.Caption = "سریال";
            this.gridColumnSerial.FieldName = "Serial";
            this.gridColumnSerial.Name = "gridColumnSerial";
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.Caption = "تاریخ";
            this.gridColumnDate.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.gridColumnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDate.FieldName = "RecordTime";
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 82);
            this.panel2.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.TextBoxSearch);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(241, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 65);
            this.panel5.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.comboBox1.Location = new System.Drawing.Point(231, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBoxSearch.Location = new System.Drawing.Point(225, 0);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(152, 21);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(358, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "سایز جدول :";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            this.label1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DateTimePickerStart);
            this.panel3.Controls.Add(this.DateTimePickerEnd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 82);
            this.panel3.TabIndex = 3;
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.DateTimePickerStart.Location = new System.Drawing.Point(0, 7);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(198, 22);
            this.DateTimePickerStart.TabIndex = 5;
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.DateTimePickerEnd.Location = new System.Drawing.Point(0, 31);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(198, 22);
            this.DateTimePickerEnd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(204, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "تا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(204, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "از ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonTransactionPayoutRefresh);
            this.panel1.Controls.Add(this.ButtonTransactionPayoutDelete);
            this.panel1.Controls.Add(this.ButtonTransactionPayoutEdit);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.ButtonTransactionPayoutNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(669, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 386);
            this.panel1.TabIndex = 12;
            // 
            // ButtonTransactionPayoutRefresh
            // 
            this.ButtonTransactionPayoutRefresh.Appearance.Options.UseTextOptions = true;
            this.ButtonTransactionPayoutRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonTransactionPayoutRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonTransactionPayoutRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonTransactionPayoutRefresh.ImageOptions.SvgImage")));
            this.ButtonTransactionPayoutRefresh.Location = new System.Drawing.Point(11, 257);
            this.ButtonTransactionPayoutRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransactionPayoutRefresh.Name = "ButtonTransactionPayoutRefresh";
            this.ButtonTransactionPayoutRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonTransactionPayoutRefresh.Size = new System.Drawing.Size(140, 40);
            this.ButtonTransactionPayoutRefresh.TabIndex = 1;
            this.ButtonTransactionPayoutRefresh.Text = "بازنشانی";
            this.ButtonTransactionPayoutRefresh.Click += new System.EventHandler(this.ButtonPaymentRefresh_Click);
            // 
            // ButtonTransactionPayoutDelete
            // 
            this.ButtonTransactionPayoutDelete.Appearance.Options.UseTextOptions = true;
            this.ButtonTransactionPayoutDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonTransactionPayoutDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonTransactionPayoutDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonTransactionPayoutDelete.ImageOptions.SvgImage")));
            this.ButtonTransactionPayoutDelete.Location = new System.Drawing.Point(11, 207);
            this.ButtonTransactionPayoutDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransactionPayoutDelete.Name = "ButtonTransactionPayoutDelete";
            this.ButtonTransactionPayoutDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonTransactionPayoutDelete.Size = new System.Drawing.Size(140, 40);
            this.ButtonTransactionPayoutDelete.TabIndex = 2;
            this.ButtonTransactionPayoutDelete.Text = "حذف";
            this.ButtonTransactionPayoutDelete.Click += new System.EventHandler(this.ButtonPaymentDelete_Click);
            // 
            // ButtonTransactionPayoutEdit
            // 
            this.ButtonTransactionPayoutEdit.Appearance.Options.UseTextOptions = true;
            this.ButtonTransactionPayoutEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonTransactionPayoutEdit.Enabled = false;
            this.ButtonTransactionPayoutEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonTransactionPayoutEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonTransactionPayoutEdit.ImageOptions.SvgImage")));
            this.ButtonTransactionPayoutEdit.Location = new System.Drawing.Point(11, 157);
            this.ButtonTransactionPayoutEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransactionPayoutEdit.Name = "ButtonTransactionPayoutEdit";
            this.ButtonTransactionPayoutEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonTransactionPayoutEdit.Size = new System.Drawing.Size(140, 40);
            this.ButtonTransactionPayoutEdit.TabIndex = 3;
            this.ButtonTransactionPayoutEdit.Text = "ویرایش";
            this.ButtonTransactionPayoutEdit.Click += new System.EventHandler(this.ButtonPaymentEdit_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(11, 7);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButton2.Size = new System.Drawing.Size(140, 40);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "ذخیره فایل";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(11, 57);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButton1.Size = new System.Drawing.Size(140, 40);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "چاپ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ButtonTransactionPayoutNew
            // 
            this.ButtonTransactionPayoutNew.Appearance.Options.UseTextOptions = true;
            this.ButtonTransactionPayoutNew.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonTransactionPayoutNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonTransactionPayoutNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonTransactionPayoutNew.ImageOptions.SvgImage")));
            this.ButtonTransactionPayoutNew.Location = new System.Drawing.Point(11, 107);
            this.ButtonTransactionPayoutNew.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransactionPayoutNew.Name = "ButtonTransactionPayoutNew";
            this.ButtonTransactionPayoutNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonTransactionPayoutNew.Size = new System.Drawing.Size(140, 40);
            this.ButtonTransactionPayoutNew.TabIndex = 4;
            this.ButtonTransactionPayoutNew.Text = "جدید";
            this.ButtonTransactionPayoutNew.Click += new System.EventHandler(this.ButtonPaymentNew_Click);
            // 
            // PayoutTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControlGridControl);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "PayoutTransactionList";
            this.Size = new System.Drawing.Size(831, 390);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlGridControl)).EndInit();
            this.PanelControlGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payoutTransactionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPayout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl PanelControlGridControl;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl GridControlPayout;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewPayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton ButtonTransactionPayoutRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonTransactionPayoutDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonTransactionPayoutEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonTransactionPayoutNew;
        private System.Windows.Forms.BindingSource payoutTransactionModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBatch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBatchUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBatchRegister;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPerson;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRecordTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSerial;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private Atf.UI.DateTimeSelector DateTimePickerStart;
        private Atf.UI.DateTimeSelector DateTimePickerEnd;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
