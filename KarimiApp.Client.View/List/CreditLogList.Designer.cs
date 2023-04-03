namespace KarimiApp.Client.View.List
{
    partial class CreditLogList
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.personCreditLogModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBedehkari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBestankari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxRemain = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personCreditLogModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.personCreditLogModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(622, 421);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // personCreditLogModelBindingSource
            // 
            this.personCreditLogModelBindingSource.DataSource = typeof(KarimiApp.Model.PersonCreditLogModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBedehkari,
            this.colBestankari,
            this.colRemain,
            this.colRecordTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bedehkari", this.colBedehkari, "(بدهکاری: SUM={0:#,# ریال})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBedehkari
            // 
            this.colBedehkari.AppearanceCell.Options.UseTextOptions = true;
            this.colBedehkari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBedehkari.AppearanceHeader.Options.UseTextOptions = true;
            this.colBedehkari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBedehkari.Caption = "بستانکاری";
            this.colBedehkari.DisplayFormat.FormatString = "#,#";
            this.colBedehkari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBedehkari.FieldName = "Bestankari";
            this.colBedehkari.Name = "colBedehkari";
            this.colBedehkari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bestankari", "{0:#,# ریال} بستانکاری")});
            this.colBedehkari.Visible = true;
            this.colBedehkari.VisibleIndex = 1;
            // 
            // colBestankari
            // 
            this.colBestankari.AppearanceCell.Options.UseTextOptions = true;
            this.colBestankari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBestankari.AppearanceHeader.Options.UseTextOptions = true;
            this.colBestankari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBestankari.Caption = "بدهکاری";
            this.colBestankari.DisplayFormat.FormatString = "#,#";
            this.colBestankari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBestankari.FieldName = "Bedehkari";
            this.colBestankari.Name = "colBestankari";
            this.colBestankari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bedehkari", "{0:#,# ریال} بدهکاری")});
            this.colBestankari.Visible = true;
            this.colBestankari.VisibleIndex = 2;
            // 
            // colRemain
            // 
            this.colRemain.AppearanceCell.Options.UseTextOptions = true;
            this.colRemain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemain.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemain.Caption = "مانده حساب";
            this.colRemain.DisplayFormat.FormatString = "#,#";
            this.colRemain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRemain.FieldName = "Remain";
            this.colRemain.Name = "colRemain";
            this.colRemain.Visible = true;
            this.colRemain.VisibleIndex = 0;
            // 
            // colRecordTime
            // 
            this.colRecordTime.AppearanceCell.Options.UseTextOptions = true;
            this.colRecordTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRecordTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecordTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRecordTime.Caption = "زمان";
            this.colRecordTime.FieldName = "RecordTime";
            this.colRecordTime.Name = "colRecordTime";
            this.colRecordTime.Visible = true;
            this.colRecordTime.VisibleIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "چاپ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextBoxRemain);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TextBoxCustomerName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 100);
            this.panel3.TabIndex = 4;
            // 
            // TextBoxRemain
            // 
            this.TextBoxRemain.AutoSize = true;
            this.TextBoxRemain.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBoxRemain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRemain.Location = new System.Drawing.Point(334, 0);
            this.TextBoxRemain.Name = "TextBoxRemain";
            this.TextBoxRemain.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.TextBoxRemain.Size = new System.Drawing.Size(34, 39);
            this.TextBoxRemain.TabIndex = 3;
            this.TextBoxRemain.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(125, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "مانده حساب :";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.AutoSize = true;
            this.TextBoxCustomerName.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(493, 0);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.TextBoxCustomerName.Size = new System.Drawing.Size(34, 39);
            this.TextBoxCustomerName.TabIndex = 1;
            this.TextBoxCustomerName.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(95, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام مشتری :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 421);
            this.panel2.TabIndex = 4;
            // 
            // CreditLogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "CreditLogList";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personCreditLogModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource personCreditLogModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBedehkari;
        private DevExpress.XtraGrid.Columns.GridColumn colBestankari;
        private DevExpress.XtraGrid.Columns.GridColumn colRemain;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TextBoxRemain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TextBoxCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}
