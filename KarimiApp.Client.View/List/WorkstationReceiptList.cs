using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using System.Drawing;

namespace KarimiApp.Client.View.List
{
    public partial class WorkstationReceiptList : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private WorkstationModel workstation;
        public WorkstationReceiptList()
        {
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            this.panel1.Visible = false;
            this.StartTimeDatePicker.ValueChanged += DatePicker_ValueChanged;
            this.EndTimeDatePicker.ValueChanged += DatePicker_ValueChanged;
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;
            this.unitOfWork.Receipt.List(gridControl1);
           // this.unitOfWork.Receipt.List(workstationReceiptFilter: new WorkstationReceiptFilterModel(workstation: workstation.Title, startTime: StartTimeDatePicker.Value, endTime: EndTimeDatePicker.Value), grid: this.gridControl1);
        }
        public WorkstationReceiptList(WorkstationModel workstation)
        {
            this.workstation = workstation;
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            colWorkstation.Visible = false;
            this.StartTimeDatePicker.ValueChanged += DatePicker_ValueChanged;
            this.EndTimeDatePicker.ValueChanged += DatePicker_ValueChanged;
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;
            this.unitOfWork.Receipt.List(workstationReceiptFilter: new WorkstationReceiptFilterModel(workstation: workstation.Title, startTime: StartTimeDatePicker.Value, endTime: EndTimeDatePicker.Value), grid: this.gridControl1);
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if ((this.gridView1.GetRow(e.RowHandle) as ReceiptModel).Scanned == true)
            {
                e.Appearance.BackColor = Color.FromArgb(77, 255, 77);
            }
            else
            {
                e.Appearance.BackColor = Color.FromArgb(255, 77, 77);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Receipt.List(workstationReceiptFilter: new WorkstationReceiptFilterModel(workstation: workstation.Title, startTime: StartTimeDatePicker.Value, endTime: EndTimeDatePicker.Value), grid: this.gridControl1);
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ReceiptModel receipt = this.gridView1.GetFocusedRow() as ReceiptModel;
            TransactionModel transaction = this.unitOfWork.Receipt.GetTransaction(receipt.Transaction);
            ReportPrintRepository.PrintUnit printUnit = new ReportPrintRepository.PrintUnit();
            printUnit.Transaction.Print(transaction,0);
           // System.Windows.Forms.MessageBox.Show(receipt.Transaction.ToString());
        }

     
    }
}