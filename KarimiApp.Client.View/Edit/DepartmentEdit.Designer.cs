namespace KarimiApp.Client.View.Edit
{
    partial class DepartmentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentEdit));
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.CheckBoxActive = new DevExpress.XtraEditors.CheckEdit();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxName = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.ComboBoxInventory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmitClear = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.ButtonInventoryRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInventory.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(89, 73);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(202, 116);
            this.TextBoxDescription.TabIndex = 3;
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Location = new System.Drawing.Point(240, 202);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Properties.Caption = "      : فعال      ";
            this.CheckBoxActive.Size = new System.Drawing.Size(99, 20);
            this.CheckBoxActive.TabIndex = 4;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelDescription.Location = new System.Drawing.Point(298, 74);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDescription.Size = new System.Drawing.Size(54, 13);
            this.LabelDescription.TabIndex = 28;
            this.LabelDescription.Text = "توضیحات :";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(89, 21);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(202, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(298, 24);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(27, 13);
            this.LabelName.TabIndex = 26;
            this.LabelName.Text = "نام :";
            // 
            // ComboBoxInventory
            // 
            this.ComboBoxInventory.Location = new System.Drawing.Point(89, 47);
            this.ComboBoxInventory.Name = "ComboBoxInventory";
            this.ComboBoxInventory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInventory.Size = new System.Drawing.Size(202, 20);
            this.ComboBoxInventory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(297, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "انبار پیش فرض :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmitClear);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(391, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 234);
            this.panel1.TabIndex = 62;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Appearance.Options.UseTextOptions = true;
            this.ButtonCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonCancel.ImageOptions.SvgImage = global::KarimiApp.Client.View.Properties.Resources.ButtonCancel;
            this.ButtonCancel.Location = new System.Drawing.Point(10, 110);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCancel.Size = new System.Drawing.Size(140, 40);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "لغو";
            // 
            // ButtonSubmitClear
            // 
            this.ButtonSubmitClear.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmitClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmitClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmitClear.ImageOptions.SvgImage = global::KarimiApp.Client.View.Properties.Resources.ButtonSubmitClear;
            this.ButtonSubmitClear.Location = new System.Drawing.Point(10, 60);
            this.ButtonSubmitClear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmitClear.Name = "ButtonSubmitClear";
            this.ButtonSubmitClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmitClear.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmitClear.TabIndex = 2;
            this.ButtonSubmitClear.Text = "ثبت و جدید";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Appearance.Options.UseTextOptions = true;
            this.ButtonSubmit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ButtonSubmit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButtonSubmit.ImageOptions.SvgImage = global::KarimiApp.Client.View.Properties.Resources.ButtonSubmit;
            this.ButtonSubmit.Location = new System.Drawing.Point(10, 10);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSubmit.Size = new System.Drawing.Size(140, 40);
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(50, 153);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 52;
            this.TextBoxId.Visible = false;
            // 
            // ButtonInventoryRefresh
            // 
            this.ButtonInventoryRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonInventoryRefresh.Appearance.Options.UseBorderColor = true;
            this.ButtonInventoryRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInventoryRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.ButtonInventoryRefresh.Location = new System.Drawing.Point(12, 41);
            this.ButtonInventoryRefresh.Name = "ButtonInventoryRefresh";
            this.ButtonInventoryRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonInventoryRefresh.Size = new System.Drawing.Size(37, 32);
            this.ButtonInventoryRefresh.TabIndex = 71;
            this.ButtonInventoryRefresh.Click += new System.EventHandler(this.ButtonInventoryRefresh_Click);
            // 
            // ButtonInventoryNew
            // 
            this.ButtonInventoryNew.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonInventoryNew.Appearance.Options.UseBorderColor = true;
            this.ButtonInventoryNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInventoryNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryType.ImageOptions.SvgImage")));
            this.ButtonInventoryNew.Location = new System.Drawing.Point(46, 41);
            this.ButtonInventoryNew.Name = "ButtonInventoryNew";
            this.ButtonInventoryNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonInventoryNew.Size = new System.Drawing.Size(37, 32);
            this.ButtonInventoryNew.TabIndex = 72;
            this.ButtonInventoryNew.Click += new System.EventHandler(this.ButtonInventoryNew_Click);
            // 
            // DepartmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 234);
            this.Controls.Add(this.ButtonInventoryRefresh);
            this.Controls.Add(this.ButtonInventoryNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComboBoxInventory);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.CheckBoxActive);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.department;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "DepartmentEdit";
            this.Text = "DepartmentEdit";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInventory.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.MemoEdit TextBoxDescription;
        private DevExpress.XtraEditors.CheckEdit CheckBoxActive;
        private System.Windows.Forms.Label LabelDescription;
        private DevExpress.XtraEditors.TextEdit TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitClear;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryRefresh;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryNew;
    }
}