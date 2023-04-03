using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class WorkStationList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private WorkstationModel selectedWorkstation;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewWorkStation;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditWorkStation;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteWorkStation;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkStationList"/> class.
        /// </summary>
        public WorkStationList()
        {
            contextMenuNewWorkStation = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonWorkStationNew_Click));
            contextMenuEditWorkStation = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonWorkStationEdit_Click));
            contextMenuDeleteWorkStation = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonWorkStationDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            // this.SetPermissions(permission.Find(x=>x.Name=="workstation"));
            this.LoadGridControl();
            this.Text = "ایستگاه ها";
            this.SetContextMenu(this.GridViewWorkstation);
            this.GridViewWorkstation.RowClick += this.GridViewDepartment_RowClick;
        }



        private void SetPermissions(Permission permission)
        {
            this.ButtonWorkstationNew.Visible = permission.Create;
            this.contextMenuNewWorkStation.Visible = permission.Create;
            this.ButtonWorkstationEdit.Visible = permission.Modify;
            this.contextMenuEditWorkStation.Visible = permission.Modify;
            this.ButtonWorkstationDelete.Visible = permission.Remove;
            this.contextMenuDeleteWorkStation.Visible = permission.Remove;
        }
        private void GridViewDepartment_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedWorkstation = new WorkstationModel();
            this.selectedWorkstation = this.GridViewWorkstation.GetRow(e.RowHandle) as WorkstationModel;
            if (e.Clicks == 2)
            {
                View.Settings.WorkStationPanel workStationPanel = new Settings.WorkStationPanel(this.selectedWorkstation);
                workStationPanel.Show();
            }

        }

        private void SetContextMenu(GridView view)
        {
            view.PopupMenuShowing += this.GridView_PopupMenuShowing;
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(sender as GridView);
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonWorkStationNew_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonWorkStationEdit_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonWorkStationDelete_Click)));
            e.Menu = pmenu;
        }

        private void LoadGridControl()
        {
            this.unitOfWork.Workstation.List(this.GridControlWorkstation);
        }

        private void ButtonWorkStationNew_Click(object sender, EventArgs e)
        {
            WorkStationEdit workStationEdit = new WorkStationEdit();
            workStationEdit.ShowDialog();
            if (workStationEdit.DialogResult == DialogResult.OK)
            {
                workStationEdit.Dispose();
            }
            this.LoadGridControl();
        }

        private void ButtonWorkStationEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedWorkstation == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                WorkStationEdit workStationEdit = new WorkStationEdit(this.selectedWorkstation);
                workStationEdit.ShowDialog();
                if (workStationEdit.DialogResult == DialogResult.OK)
                {
                    workStationEdit.Dispose();
                }
                this.LoadGridControl();
            }

        }

        private void ButtonWorkStationDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedWorkstation == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.Workstation.Delete(this.selectedWorkstation);
                this.LoadGridControl();
            }

        }

        private void ButtonWorkStationRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Workstation.Search(gridControl: this.GridControlWorkstation, text: this.TextBoxSearch.Text);
        }

        private void AdminButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.selectedWorkstation = new WorkstationModel();
                this.selectedWorkstation = this.GridViewWorkstation.GetFocusedRow() as WorkstationModel;
                View.Settings.WorkStationPanel workStationPanel = new Settings.WorkStationPanel(this.selectedWorkstation);
                workStationPanel.Show();
            }
            catch (Exception eee)
            {

                MessageBox.Show(eee.Message+eee.StackTrace);
            }
            
        }

        private void ReceiptsButtonEdit_Click(object sender, EventArgs e)
        {
            this.selectedWorkstation = new WorkstationModel();
            this.selectedWorkstation = this.GridViewWorkstation.GetFocusedRow() as WorkstationModel;
            View.List.WorkstationReceiptList workstationReceipt = new WorkstationReceiptList(selectedWorkstation);
            workstationReceipt.Show();
        }
    }
}