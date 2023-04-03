using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsClient.CustomControls;

namespace KarimiApp.Client.View.Settings
{
    public partial class Batch : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        public Batch()
        {
           
            unitOfWork = new UnitOfWork();
            InitializeComponent();
            List<PaymentMethodModel> paymentMethods = unitOfWork.PaymentMethod.List();
            paymentMethods.ForEach(x => this.AddBatchPaymentControl(x));
        }

        private void AddBatchPaymentControl(PaymentMethodModel paymentMethod)
        {
            BatchPaymentMethodControl batchPaymentMethod = new BatchPaymentMethodControl(paymentMethod);
            batchPaymentMethod.Dock = DockStyle.Top;
            this.panel1.Controls.Add(batchPaymentMethod);
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            BatchModel tmp = this.GetValues();
            this.unitOfWork.Batch.Delete(tmp);
        }

        private BatchModel GetValues()
        {
            string system = Environment.MachineName;
            UserModel loggerUser = ((CashierMain)Application.OpenForms["CashierMain"]).logged;
            BatchModel batch = new BatchModel(batchUser: loggerUser.UserName, batchRegister: system, closeTime: DateTime.Now);
            List<BankValueModel> bankValues = new List<BankValueModel>();
            foreach (BatchPaymentMethodControl item in panel1.Controls)
            {
                bankValues.Add(item.GetBankValue());
            }
            batch.BankValues=bankValues;
            return batch;
        }
    }
}