namespace KarimiApp.Client.View.Edit
{
    partial class WorkStationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkStationEdit));
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelCode = new System.Windows.Forms.Label();
            this.TextBoxPort = new DevExpress.XtraEditors.TextEdit();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxIpAddress = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.ComboBoxDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmitClear = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmentNew = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmentRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIpAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDepartment.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(21, 153);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 46;
            this.TextBoxId.Visible = false;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(193, 4);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTitle.TabIndex = 47;
            // 
            // LabelCode
            // 
            this.LabelCode.AutoSize = true;
            this.LabelCode.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelCode.Location = new System.Drawing.Point(298, 7);
            this.LabelCode.Name = "LabelCode";
            this.LabelCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCode.Size = new System.Drawing.Size(40, 13);
            this.LabelCode.TabIndex = 45;
            this.LabelCode.Text = "عنوان :";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(191, 116);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPort.TabIndex = 39;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelDescription.Location = new System.Drawing.Point(298, 119);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDescription.Size = new System.Drawing.Size(35, 13);
            this.LabelDescription.TabIndex = 41;
            this.LabelDescription.Text = "پورت :";
            // 
            // TextBoxIpAddress
            // 
            this.TextBoxIpAddress.Location = new System.Drawing.Point(89, 80);
            this.TextBoxIpAddress.Name = "TextBoxIpAddress";
            this.TextBoxIpAddress.Size = new System.Drawing.Size(203, 20);
            this.TextBoxIpAddress.TabIndex = 40;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(297, 83);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(44, 13);
            this.LabelName.TabIndex = 38;
            this.LabelName.Text = "آی پی :";
            // 
            // ComboBoxDepartment
            // 
            this.ComboBoxDepartment.Location = new System.Drawing.Point(89, 40);
            this.ComboBoxDepartment.Name = "ComboBoxDepartment";
            this.ComboBoxDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDepartment.Size = new System.Drawing.Size(203, 20);
            this.ComboBoxDepartment.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(297, 43);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "دپارتمان";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmitClear);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(363, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 156);
            this.panel1.TabIndex = 50;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Options.UseTextOptions = true;
            this.ButtonCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonCancel.ImageOptions.SvgImage")));
            this.ButtonCancel.Location = new System.Drawing.Point(10, 110);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCancel.Size = new System.Drawing.Size(140, 40);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "لغو";
            // 
            // ButtonSubmitClear
            // 
            this.ButtonSubmitClear.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmitClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmitClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmitClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSubmitClear.ImageOptions.SvgImage")));
            this.ButtonSubmitClear.Location = new System.Drawing.Point(10, 60);
            this.ButtonSubmitClear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmitClear.Name = "ButtonSubmitClear";
            this.ButtonSubmitClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmitClear.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmitClear.TabIndex = 5;
            this.ButtonSubmitClear.Text = "ثبت و جدید";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSubmit.ImageOptions.SvgImage")));
            this.ButtonSubmit.Location = new System.Drawing.Point(10, 10);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmit.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // ButtonDepartmentNew
            // 
            this.ButtonDepartmentNew.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonDepartmentNew.Appearance.Options.UseBorderColor = true;
            this.ButtonDepartmentNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDepartmentNew.ImageOptions.SvgImage")));
            this.ButtonDepartmentNew.Location = new System.Drawing.Point(9, 34);
            this.ButtonDepartmentNew.Name = "ButtonDepartmentNew";
            this.ButtonDepartmentNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonDepartmentNew.Size = new System.Drawing.Size(37, 32);
            this.ButtonDepartmentNew.TabIndex = 61;
            // 
            // ButtonDepartmentRefresh
            // 
            this.ButtonDepartmentRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonDepartmentRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonDepartmentRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.ButtonDepartmentRefresh.Location = new System.Drawing.Point(50, 34);
            this.ButtonDepartmentRefresh.Name = "ButtonDepartmentRefresh";
            this.ButtonDepartmentRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonDepartmentRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonDepartmentRefresh.TabIndex = 61;
            this.ButtonDepartmentRefresh.Click += new System.EventHandler(this.ButtonDepartmentRefresh_Click);
            // 
            // WorkStationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 156);
            this.Controls.Add(this.ButtonDepartmentRefresh);
            this.Controls.Add(this.ButtonDepartmentNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComboBoxDepartment);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelCode);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxIpAddress);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.workstationicon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "WorkStationEdit";
            this.Text = "WorkStationEdit";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIpAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDepartment.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label LabelCode;
        private DevExpress.XtraEditors.TextEdit TextBoxPort;
        private System.Windows.Forms.Label LabelDescription;
        private DevExpress.XtraEditors.TextEdit TextBoxIpAddress;
        private System.Windows.Forms.Label LabelName;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitClear;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmentNew;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmentRefresh;
    }
}