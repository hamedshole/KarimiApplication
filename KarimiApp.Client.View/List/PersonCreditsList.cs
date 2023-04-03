using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System.Runtime.CompilerServices;

namespace KarimiApp.Client.View.List
{
    public partial class PersonCreditsList : XtraUserControl
    {
        UnitOfWork unitOfWork;
        public PersonCreditsList()
        {
            unitOfWork = new UnitOfWork();
          
            InitializeComponent();
            
            unitOfWork.Acounting.PersonCreditList(this.gridControl1);
            this.gridView1.RowClick += GridView1_RowClick;
          // gridControl1.
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            PersonCreditHeaderModel personCreditHeader = this.gridView1.GetFocusedRow() as PersonCreditHeaderModel;
            View.List.CreditLogList creditLogList = new CreditLogList(personCreditHeader);
            creditLogList.Show();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BaseView d = this.gridView1.GetVisibleDetailView(gridView1.FocusedRowHandle);
            d.Print();
        }

       

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ReportPrintRepository.PrintUnit printUnit = new ReportPrintRepository.PrintUnit();
            var customers = this.unitOfWork.Person.List();
            printUnit.Acounting.CustomersReport(customers);
        }
    }
}