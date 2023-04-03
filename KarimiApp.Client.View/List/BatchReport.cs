using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using System;

namespace KarimiApp.Client.View.List
{
    public partial class BatchReport : DevExpress.XtraEditors.XtraForm
    {
        private BatchModel batch;
        private PrintUnit printUnit;
        public BatchReport(BatchModel batch)
        {
            this.printUnit = new PrintUnit();
            InitializeComponent();
            this.batch = batch;
            this.SetValues(batch);
        }

        private void SetValues(BatchModel batch)
        {
            this.gridControl1.DataSource = batch.BankValues;
            this.TextBoxTotalSell.Text = batch.TotalSell.ToString();
            this.TextBoxTotalDifference.Text = batch.SystemCashierVariant.ToString();
            this.TextBoxUser.Text = batch.BatchUser;
            this.TextBoxRegister.Text = batch.BatchRegister;
            this.TextBoxOpenTimeDate.Text = batch.OpenTime.ToString("yyyy/MM/dd");
            this.TextBoxOpenTimeHour.Text = batch.OpenTime.ToShortTimeString();
            this.TextBoxCloseTimeHour.Text = batch.CloseTime.ToShortTimeString();
            this.TextBOxPayoutSum.Text = batch.StorePayouts.ToString();
            this.TextBoxAccountingIn.Text = batch.Income.ToString();
            this.TextBOxAccountingOut.Text = batch.Credit.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.printUnit.Batch.Print(this.batch);
        }
    }
}