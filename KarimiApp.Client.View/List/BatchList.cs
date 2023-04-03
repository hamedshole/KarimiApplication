using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;

namespace KarimiApp.Client.View.List
{
    public partial class BatchList : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private PrintUnit printUnit;
        public BatchList()
        {
            printUnit = new PrintUnit();
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            unitOfWork.Batch.List(this.gridControl1);
           // this.gridView1.RowClick += GridView1_RowClick;
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("buttonclick");
        }

        private void ButtonPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BatchModel batch = new BatchModel();
            batch = this.gridView1.GetFocusedRow() as BatchModel;
            this.printUnit.Batch.Print(batch);
        }





        //private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    BatchReport report;
        //    if (e.Clicks == 2)
        //    {
        //        report = new BatchReport((sender as GridView).GetRow(e.RowHandle) as BatchModel);
        //        report.Show();
        //    }
        //}

        //private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    BatchModel batch = new BatchModel();
        //    batch = this.gridView1.GetFocusedRow() as BatchModel;
        //    this.printUnit.Batch.Print(batch);
        //    //System.Windows.Forms.MessageBox.Show(((BatchModel)this.gridView1.GetFocusedRow()).StorePayouts.ToString()); 
        //}


    }
}