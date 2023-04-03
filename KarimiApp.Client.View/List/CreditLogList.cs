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
using DevExpress.XtraReports.UI;

namespace KarimiApp.Client.View.List
{
    public partial class CreditLogList : DevExpress.XtraEditors.XtraForm
    {
        PersonCreditHeaderModel person;
        ReportPrintRepository.PrintUnit printUnit;
        public CreditLogList(PersonCreditHeaderModel personCreditHeader)
        {
            this.printUnit = new ReportPrintRepository.PrintUnit();
            InitializeComponent();
            this.person = personCreditHeader;
            this.TextBoxCustomerName.Text = personCreditHeader.Name;
            this.TextBoxRemain.Text = personCreditHeader.Balance.ToString("#,#");
            this.gridControl1.DataSource = personCreditHeader.Log;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printUnit.Acounting.PersonLog(person);
           // this.gridView1.OptionsPrint.RtfReportHeader=string.Format("نام مشتری : {0}\n مانده حساب :{1}", person.Name,person.Balance);
           // this.gridView1.PrintDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
