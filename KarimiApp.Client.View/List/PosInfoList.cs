using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class PosInfoList : DevExpress.XtraEditors.XtraUserControl
    {
        private PosInfoModel selectedPosInfo;
        private UnitOfWork unitOfWork;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewPosInfo;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditPosInfo;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeletePosInfo;
        public PosInfoList()
        {
            contextMenuNewPosInfo = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonPosInfoNew_Click));
            contextMenuEditPosInfo = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonPosInfoEdit_Click));
            contextMenuDeletePosInfo = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonPosInfoDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.LoadGridControl();
            this.GridViewPosInfo.RowClick += GridViewPosInfo_RowClick;
            this.SetContextMenu(this.GridViewPosInfo);
        }

        private void GridViewPosInfo_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedPosInfo = new PosInfoModel();
            this.selectedPosInfo = this.GridViewPosInfo.GetRow(e.RowHandle) as PosInfoModel;
        }

        private void LoadGridControl()
        {
            this.unitOfWork.PosInfo.List(this.GridControlPosInfo);
        }

        private void SetContextMenu(GridView gridViewPosInfo)
        {
            gridViewPosInfo.PopupMenuShowing += this.GridView_PopupMenuShowing;
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(sender as GridView);
            pmenu.Items.Add(contextMenuNewPosInfo);
            pmenu.Items.Add(contextMenuEditPosInfo);
            pmenu.Items.Add(contextMenuDeletePosInfo);
            e.Menu = pmenu;
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonPosInfoNew.Visible = permission.Create;
            this.contextMenuNewPosInfo.Visible = permission.Create;
            this.ButtonPosInfoEdit.Visible = permission.Modify;
            this.contextMenuEditPosInfo.Visible = permission.Modify;
            this.ButtonPosInfoDelete.Visible = permission.Remove;
            this.contextMenuDeletePosInfo.Visible = permission.Remove;
        }

        private void ButtonPosInfoDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPosInfo == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.PosInfo.Delete(this.selectedPosInfo);
                this.LoadGridControl();
            }

        }

        private void ButtonPosInfoEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedPosInfo == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                PosInfoEdit posInfoEdit = new PosInfoEdit(this.selectedPosInfo);
                posInfoEdit.ShowDialog();
                if (posInfoEdit.DialogResult == DialogResult.OK)
                {
                    posInfoEdit.Dispose();
                    this.LoadGridControl();
                }
            }

        }

        private void ButtonPosInfoNew_Click(object sender, EventArgs e)
        {
            PosInfoEdit posInfoEdit = new PosInfoEdit();
            posInfoEdit.ShowDialog();
            if (posInfoEdit.DialogResult == DialogResult.OK)
            {
                posInfoEdit.Dispose();
            }
        }

        private void ButtonPosInfoRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.PosInfo.Search(this.TextBoxSearch.Text, this.GridControlPosInfo);
        }
    }
}