using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PrintUnit = KarimiApp.ReportPrintRepository.PrintUnit;

namespace KarimiApp.Client.View.Edit
{
    public partial class PaymentEdit : DevExpress.XtraEditors.XtraForm
    {
        private PrintUnit printUnit;
        private UnitOfWork unitOfWork;
        private BatchModel batch;
        private string person;
        private bool Io;
        public PaymentEdit()
        {
            printUnit = new PrintUnit();
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void ButtonCash_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentTransactionModel paymentTransaction = this.ExtractTransaction("نقد");
                unitOfWork.PaymentTransaction.Insert(paymentTransaction);
                TransactionModel transactionModel = new TransactionModel
                {
                    Batch = paymentTransaction.Batch,
                    BatchUser = paymentTransaction.BatchUser,
                    BatchRegister = paymentTransaction.BatchRegister,
                    Description = paymentTransaction.Description,
                    PaymentMethod = paymentTransaction.PaymentMethod,
                    RecordTime = paymentTransaction.RecordTime,
                    Person = paymentTransaction.Person,
                    Serial = paymentTransaction.Serial,
                    TotalValue = paymentTransaction.Value,
                    PaidValue = paymentTransaction.Value,
                    Entries = new System.Collections.Generic.List<TransactionEntryModel>
                {
                    new TransactionEntryModel()
                    {
                        Item = "پرداخت حساب",
                        SellPrice = paymentTransaction.Value,
                        Amount = 1
                    }

                }

                };
                this.printUnit.Transaction.Print(transactionModel, 0);
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(ve.Message);
            }


        }

        private void ButtonSaman_Click(object sender, EventArgs e)
        {
            unitOfWork.PaymentTransaction.Insert(this.ExtractTransaction("درگاه بانک سامان"));
            this.Close();
        }

        private void ButtonMellat_Click(object sender, EventArgs e)
        {

            unitOfWork.PaymentTransaction.Insert(this.ExtractTransaction("درگاه بانک ملت"));
            this.Close();
        }

        private PaymentTransactionModel ExtractTransaction(string paymentmethod)
        {
            List<string> inputparameters = new List<string>();
            if (this.ComboBoxTransactionType.Text == null)
            {
                inputparameters.Add("نوع تراکنش");
            }
            if (string.IsNullOrEmpty(this.person))
            {
                inputparameters.Add("مشتری");
            }
            if (this.TextBoxValue.EditValue == null)
            {
                inputparameters.Add("مقدار");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new PaymentTransactionModel(io: this.Io, batchRegister: System.Environment.MachineName, batchUser: ((CashierMain)Application.OpenForms["CashierMain"]).logged.Name, value: long.Parse(TextBoxValue.Text), description: this.TextBoxDescription.Text, paymentMethod: paymentmethod, person: this.person);
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTransactionType.SelectedIndex == 0)
            {
                this.Io = true;
                this.ButtonSaman.Enabled = true;
                this.ButtonMellat.Enabled = true;
            }
            else if (ComboBoxTransactionType.SelectedIndex == 1)
            {
                this.Io = false;
                this.ButtonSaman.Enabled = false;
                this.ButtonMellat.Enabled = false;
            }
        }

        private void ButtonCustomerSelect_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "دریافت/پرداخت";
            View.List.CustomerList customerList = new View.List.CustomerList();
            form.Size = new Size(800, 300);
            customerList.Dock = DockStyle.Fill;
            form.Controls.Add(customerList);
            form.Show();
            customerList.GridViewCustomer.RowClick += GridViewCustomer_RowClick;

        }

        private void GridViewCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                PersonModel customer = (sender as GridView).GetRow(e.RowHandle) as PersonModel;
                this.person = customer.Name;
                this.TextBoxCustomerName.Text = customer.Name;
                TextBoxCustomerCode.Text = customer.Code.ToString();
                TextBoxCustomerBalance.Text = customer.Balance.ToString();
                ((Form)Application.OpenForms[""]).Close();
            }

        }
    }
}