namespace KarimiApp.Client.View.Settings
{
    partial class WorkStationMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTitle = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMessage = new DevExpress.XtraEditors.MemoEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDuration = new DevExpress.XtraEditors.TextEdit();
            this.CheckboxBeep = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxCloseByKey = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonSendMessage = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckboxBeep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxCloseByKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان :";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(23, 23);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(283, 20);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 52);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "متن پیام :";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(23, 51);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(283, 96);
            this.TextBoxMessage.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "مدت زمان :";
            // 
            // TextBoxDuration
            // 
            this.TextBoxDuration.Location = new System.Drawing.Point(252, 154);
            this.TextBoxDuration.Name = "TextBoxDuration";
            this.TextBoxDuration.Size = new System.Drawing.Size(54, 20);
            this.TextBoxDuration.TabIndex = 1;
            // 
            // CheckboxBeep
            // 
            this.CheckboxBeep.Location = new System.Drawing.Point(137, 154);
            this.CheckboxBeep.Name = "CheckboxBeep";
            this.CheckboxBeep.Properties.Caption = "         بوق";
            this.CheckboxBeep.Size = new System.Drawing.Size(75, 20);
            this.CheckboxBeep.TabIndex = 3;
            // 
            // CheckBoxCloseByKey
            // 
            this.CheckBoxCloseByKey.Location = new System.Drawing.Point(23, 154);
            this.CheckBoxCloseByKey.Name = "CheckBoxCloseByKey";
            this.CheckBoxCloseByKey.Properties.Caption = "خروج با کلید";
            this.CheckBoxCloseByKey.Size = new System.Drawing.Size(75, 20);
            this.CheckBoxCloseByKey.TabIndex = 3;
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Location = new System.Drawing.Point(231, 196);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendMessage.TabIndex = 4;
            this.ButtonSendMessage.Text = "ارسال";
            this.ButtonSendMessage.Click += new System.EventHandler(this.ButtonSendMessage_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(137, 196);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "لغو";
            // 
            // WorkStationMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 247);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSendMessage);
            this.Controls.Add(this.CheckBoxCloseByKey);
            this.Controls.Add(this.CheckboxBeep);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.TextBoxDuration);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "WorkStationMessage";
            this.Text = "WorkStationMessage";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckboxBeep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxCloseByKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TextBoxTitle;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit TextBoxMessage;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TextBoxDuration;
        private DevExpress.XtraEditors.CheckEdit CheckboxBeep;
        private DevExpress.XtraEditors.CheckEdit CheckBoxCloseByKey;
        private DevExpress.XtraEditors.SimpleButton ButtonSendMessage;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
    }
}