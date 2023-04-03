using DevExpress.LookAndFeel;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class PayoutTransactionList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private PayoutTransactionModel selectedPayout;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewPayout;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditPayout;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeletePayout;
        private PrintUnit printUnit;
        PrintableComponentLink link;
        public PayoutTransactionList()
        {
            printUnit = new PrintUnit();
            
            // Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "department");
            contextMenuNewPayout = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonPaymentNew_Click));
            contextMenuEditPayout = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonPaymentEdit_Click));
            contextMenuDeletePayout = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonPaymentDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            //foreach (GridColumn item in GridViewPayout.Columns)
            //{
            //    item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //}
            this.DateTimePickerStart.Value = DateTime.Now;
            this.DateTimePickerEnd.Value = DateTime.Now.AddDays(1);
            this.DateTimePickerStart.ValueChanged += DateTimePicker1_ValueChanged;
            this.DateTimePickerEnd.ValueChanged += DateTimePicker1_ValueChanged;
            //this.SetPermissions(permission);
            this.LoadGridControl();
            // this.GridControlPayout.Load += GridControlPayout_Load;
            this.SetContextMenu(this.GridViewPayout);           
        }

       

        private void SetgridFontSize(int size)
        {
            this.GridViewPayout.Appearance.Row.Font = new System.Drawing.Font("Tahoma",size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void GridControlPayout_Load(object sender, EventArgs e)
        {
            PreviewPrintableComponent(GridControlPayout, GridControlPayout.LookAndFeel);
        }
        void PreviewPrintableComponent(IPrintable component, UserLookAndFeel lookAndFeel)
        {
            // Create a link that will print a control.
            link = new PrintableComponentLink()
            {
                PrintingSystemBase = new PrintingSystemBase(),
                Component = component,
                Landscape = true,
                PaperKind = PaperKind.A4,
                Margins = new Margins(20, 20, 20, 20)
            };
            link.CreateReportHeaderArea += link_CreateReportHeaderArea;
            // Show the report.
            link.ShowRibbonPreview(lookAndFeel);
            // Show the report.
            link.ShowRibbonPreview(lookAndFeel);
        }

        private void link_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "Categories Report";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 14, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.PayoutTransaction.List(payoutTransaction:new PayoutTransactionModel { StartDate=this.DateTimePickerStart.Value.Value,EndDate=this.DateTimePickerEnd.Value.Value},gridControl: this.GridControlPayout);
        }

        private void GridViewPayout_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedPayout = new PayoutTransactionModel();
            this.selectedPayout = this.GridViewPayout.GetRow(e.RowHandle) as PayoutTransactionModel;
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonTransactionPayoutNew.Visible = permission.Create;
            this.contextMenuNewPayout.Visible = permission.Create;
            this.ButtonTransactionPayoutEdit.Visible = permission.Modify;
            this.contextMenuEditPayout.Visible = permission.Modify;
            this.ButtonTransactionPayoutDelete.Visible = permission.Remove;
            this.contextMenuDeletePayout.Visible = permission.Remove;
        }
        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.PayoutTransaction.List(payoutTransaction: new PayoutTransactionModel { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) }, gridControl: this.GridControlPayout);
            // this.unitOfWork.PayoutTransaction.List(this.GridControlPayout);
        }

        /// <summary>
        /// Sets the context menu.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetContextMenu(GridView view)
        {
            view.PopupMenuShowing += this.GridView_PopupMenuShowing;
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(this.GridViewPayout);
            pmenu.Items.Add(contextMenuNewPayout);
            pmenu.Items.Add(contextMenuEditPayout);
            pmenu.Items.Add(contextMenuDeletePayout);
            e.Menu = pmenu;
        }

        private void ButtonPaymentNew_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission();
            PayoutTransaction payOut = new PayoutTransaction();
            payOut.Show();
        }

        private void ButtonPaymentEdit_Click(object sender, EventArgs e)
        {
            //if (this.selectedPayout == null)
            //{
            //    MessageBox.Show("آیتمی انتخاب نشده است");
            //}
            //else
            //{
            //    PayoutTransaction payOut = new PayoutTransaction(this.selectedPayout);
            //    payOut.Show();
            //    if (payOut.DialogResult == DialogResult.OK)
            //    {
            //        payOut.Dispose();
            //        this.LoadGridControl();
            //    }
            //}

        }

        private void ButtonPaymentDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPayout == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.PayoutTransaction.Delete(this.selectedPayout);
                this.LoadGridControl();
            }

        }

        private void ButtonPaymentRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.PayoutTransaction.Search(this.GridControlPayout, this.TextBoxSearch.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.printUnit.Acounting.Payouts(this.GridControlPayout.DataSource as List<PayoutTransactionModel>, this.DateTimePickerStart.Value.Value, DateTime.Now,false);
            // PreviewPrintableComponent(GridControlPayout, GridControlPayout.LookAndFeel);
            //this.GridViewPayout.OptionsPrint.RtfReportHeader = string.Format("{0} : هزینه های تاریخ", this.dateTimePicker1.Value.ToShortDateString());
           // this.GridViewPayout.Print();

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetgridFontSize((sender as System.Windows.Forms.ComboBox).SelectedText.ToInt());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.printUnit.Acounting.Payouts(this.GridControlPayout.DataSource as List<PayoutTransactionModel>, this.DateTimePickerStart.Value.Value, DateTime.Now, true);
        }
    }
}

