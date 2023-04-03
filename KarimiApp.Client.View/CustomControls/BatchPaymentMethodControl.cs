using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KarimiApp.Model;

namespace WindowsClient.CustomControls
{
    public partial class BatchPaymentMethodControl : DevExpress.XtraEditors.XtraUserControl
    {
        public BatchPaymentMethodControl(PaymentMethodModel paymentMethod)
        {
            InitializeComponent();
            this.groupBox1.Text = paymentMethod.Title;
        }
        public BankValueModel GetBankValue()
        {
            return new BankValueModel(paymentMethod: this.groupBox1.Text, openValue: long.Parse(this.TextBoxOpenValue.Text), closeValue: long.Parse(this.TextBoxCloseValue.Text));
        }
    }
}
