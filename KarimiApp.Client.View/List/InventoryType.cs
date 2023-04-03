using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class InventoryTypeList : DevExpress.XtraEditors.XtraUserControl
    {

        private UnitOfWork unitOfWork;
        private InventoryGroupModel selectedInventoryType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewInventoryType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditInventoryType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteInventoryType;
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeList"/> class.
        /// </summary>
        public InventoryTypeList()
        {
            contextMenuNewInventoryType = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonInventoryTypeNew_Click));
            contextMenuEditInventoryType = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonInventoryTypeEdit_Click));
            contextMenuDeleteInventoryType = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonInventoryTypeDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.GridViewInventoryType.RowClick += this.GridViewInventoryType_RowClick;
            this.SetContextMenu(this.GridViewInventoryType);
            this.LoadGridControl();
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonInventoryTypeNew.Visible = permission.Create;
            this.contextMenuNewInventoryType.Visible = permission.Create;
            this.ButtonInventoryTypeEdit.Visible = permission.Modify;
            this.contextMenuEditInventoryType.Visible = permission.Modify;
            this.ButtonInventoryTypeDelete.Visible = permission.Remove;
            this.contextMenuDeleteInventoryType.Visible = permission.Remove;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.InventoryGroup.List(this.GridControlInventoryType);
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
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(sender as GridView);
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonInventoryTypeNew_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonInventoryTypeNew_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonInventoryTypeEdit_Click)));
            e.Menu = pmenu;
        }

        private void GridViewInventoryType_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.selectedInventoryType = new InventoryGroupModel();
            this.selectedInventoryType = this.GridViewInventoryType.GetRow(e.RowHandle) as InventoryGroupModel;
        }

        private void ButtonInventoryTypeNew_Click(object sender, EventArgs e)
        {
            InventoryTypeEdit inventoryTypeEdit = new InventoryTypeEdit();
            inventoryTypeEdit.ShowDialog();
            if (inventoryTypeEdit.DialogResult == DialogResult.OK)
            {
                inventoryTypeEdit.Dispose();
            }
        }

        private void ButtonInventoryTypeEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedInventoryType == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                InventoryTypeEdit inventoryTypeEdit = new InventoryTypeEdit(this.selectedInventoryType);
                inventoryTypeEdit.ShowDialog();
                if (inventoryTypeEdit.DialogResult == DialogResult.OK)
                {
                    inventoryTypeEdit.Dispose();
                }
                this.LoadGridControl();
            }

        }

        private void ButtonInventoryTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedInventoryType == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.InventoryGroup.Delete(this.selectedInventoryType);
                this.LoadGridControl();
            }

        }

        private void ButtonInventoryTypeRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void GridControlInventoryType_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.InventoryGroup.Search(this.TextBoxSearch.Text, this.GridControlInventoryType);
        }
    }
}