namespace KarimiApp.Client.View.Edit
{
    partial class InventoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryEdit));
            this.ComboBoxKeeper = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxInventoryType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.CheckBoxActive = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmitClear = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonKeeper = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInventoryType = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInventoryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxKeeper
            // 
            this.ComboBoxKeeper.Location = new System.Drawing.Point(93, 102);
            this.ComboBoxKeeper.Name = "ComboBoxKeeper";
            this.ComboBoxKeeper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxKeeper.Size = new System.Drawing.Size(227, 20);
            this.ComboBoxKeeper.TabIndex = 63;
            // 
            // ComboBoxInventoryType
            // 
            this.ComboBoxInventoryType.Location = new System.Drawing.Point(93, 60);
            this.ComboBoxInventoryType.Name = "ComboBoxInventoryType";
            this.ComboBoxInventoryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInventoryType.Size = new System.Drawing.Size(227, 20);
            this.ComboBoxInventoryType.TabIndex = 64;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(10, 155);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(140, 20);
            this.TextBoxId.TabIndex = 61;
            this.TextBoxId.Visible = false;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(93, 156);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(227, 96);
            this.TextBoxDescription.TabIndex = 59;
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Location = new System.Drawing.Point(288, 258);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Properties.Caption = "      : فعال      ";
            this.CheckBoxActive.Size = new System.Drawing.Size(96, 20);
            this.CheckBoxActive.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(344, 113);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "مسئول انبار :";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelDescription.Location = new System.Drawing.Point(344, 157);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDescription.Size = new System.Drawing.Size(54, 13);
            this.LabelDescription.TabIndex = 55;
            this.LabelDescription.Text = "توضیحات :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(344, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "گروه انبار :";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(95, 12);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(225, 20);
            this.TextBoxTitle.TabIndex = 54;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LabelName.Location = new System.Drawing.Point(347, 23);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelName.Size = new System.Drawing.Size(40, 13);
            this.LabelName.TabIndex = 53;
            this.LabelName.Text = "عنوان :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.ButtonSubmitClear);
            this.panel1.Controls.Add(this.ButtonSubmit);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(423, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 302);
            this.panel1.TabIndex = 68;
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
            this.ButtonCancel.TabIndex = 1;
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
            this.ButtonSubmitClear.TabIndex = 2;
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
            this.ButtonSubmit.TabIndex = 3;
            this.ButtonSubmit.Text = "ثبت";
            // 
            // ButtonKeeper
            // 
            this.ButtonKeeper.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonKeeper.Appearance.Options.UseBorderColor = true;
            this.ButtonKeeper.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonKeeper.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonKeeper.ImageOptions.SvgImage")));
            this.ButtonKeeper.Location = new System.Drawing.Point(46, 96);
            this.ButtonKeeper.Name = "ButtonKeeper";
            this.ButtonKeeper.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonKeeper.Size = new System.Drawing.Size(37, 32);
            this.ButtonKeeper.TabIndex = 70;
            this.ButtonKeeper.Click += new System.EventHandler(this.ButtonKeeper_Click);
            // 
            // ButtonInventoryType
            // 
            this.ButtonInventoryType.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonInventoryType.Appearance.Options.UseBorderColor = true;
            this.ButtonInventoryType.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInventoryType.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonInventoryType.ImageOptions.SvgImage")));
            this.ButtonInventoryType.Location = new System.Drawing.Point(46, 54);
            this.ButtonInventoryType.Name = "ButtonInventoryType";
            this.ButtonInventoryType.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonInventoryType.Size = new System.Drawing.Size(37, 32);
            this.ButtonInventoryType.TabIndex = 70;
            this.ButtonInventoryType.Click += new System.EventHandler(this.ButtonInventoryType_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(37, 32);
            this.simpleButton1.TabIndex = 70;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 54);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(37, 32);
            this.simpleButton2.TabIndex = 70;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // InventoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 302);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.ButtonInventoryType);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ButtonKeeper);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComboBoxKeeper);
            this.Controls.Add(this.ComboBoxInventoryType);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.CheckBoxActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelName);
            this.IconOptions.Image = global::KarimiApp.Client.View.Properties.Resources.inventoryicon;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "InventoryEdit";
            this.Text = "InventoryEdit";
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInventoryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxKeeper;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxInventoryType;
        private DevExpress.XtraEditors.TextEdit TextBoxId;
        private DevExpress.XtraEditors.MemoEdit TextBoxDescription;
        private DevExpress.XtraEditors.CheckEdit CheckBoxActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitClear;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmit;
        private DevExpress.XtraEditors.SimpleButton ButtonKeeper;
        private DevExpress.XtraEditors.SimpleButton ButtonInventoryType;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}