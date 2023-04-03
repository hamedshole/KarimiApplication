using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using KarimiApp.Exceptions;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class PayoutTransaction : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork repository;
        public PayoutTransaction()
        {
            repository = new UnitOfWork();
            InitializeComponent();
            this.Text = "پرداخت هزینه ";
            this.ButtonSubmit.Click += ButtonSubmit_Click;
            this.TextBoxValue.EditValueChanged += TextBoxValue_EditValueChanged;
        }

        private void TextBoxValue_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TextBoxValue.EditValue.ToString()))
            {
                this.TextBoxValue.EditValue = decimal.Parse(this.TextBoxValue.EditValue.ToString()).ToString("#,#");
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var values = this.GetValuesCreate();
                this.repository.PayoutTransaction.Insert(values);
                this.Close();
            }
            catch (ValidateException ve)
            {

                MessageBox.Show(new Form { TopLevel=true},ve.Message);
            }
            
        }

        public PayoutTransaction(PayoutTransactionModel payout)
        {
            repository = new UnitOfWork();
            InitializeComponent();
            this.Text = "ویرایش هزینه";
            this.SetValues(payout);
            ButtonSubmit.Click += ButtonSubmit_Click1;
        }

        private void ButtonSubmit_Click1(object sender, EventArgs e)
        {
           // this.repository.PayoutTransaction.Update(this.GetValuesUpdate());
        }

        private PayoutTransactionModel GetValuesUpdate()
        {
            string batchuser = ((CashierMain)Application.OpenForms["CashierMain"]).logged.Name;
            return new PayoutTransactionModel(batchRegister: System.Environment.MachineName, 
                batchUser: batchuser,
                value: long.Parse(TextBoxValue.Text),
                description: TextBoxDescription.Text);
        }

        private void SetValues(PayoutTransactionModel payout)
        {
            TextBoxValue.Text = payout.Value.ToString();
            TextBoxDescription.Text = payout.Description;
            TextBoxId.Text = payout.Id.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private PayoutTransactionModel GetValuesCreate()
        {
            PayoutTransactionModel result = new PayoutTransactionModel();
            if (this.TextBoxValue.EditValue==null)
            {
                throw new ValidateException(new string[] { "مقدار هزینه" });
            }
            else
            {
                string batchuser = ((CashierMain)Application.OpenForms["CashierMain"]).logged.Name;
                result= new PayoutTransactionModel(batchRegister: System.Environment.MachineName,
                    batchUser: batchuser,
                    value: long.Parse(TextBoxValue.Text.Replace(",","").Trim()),
                    description: TextBoxDescription.Text);
            }
            return result;
        }
    }
}