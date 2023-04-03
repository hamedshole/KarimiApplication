using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class InventoryList : DevExpress.XtraEditors.XtraUserControl
    {
        private InventoryModel selectedInventory;
        private UnitOfWork unitOfWork;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewInventory;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditInventory;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteInventory;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryList"/> class.
        /// </summary>
        public InventoryList()
        {
            //  Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "inventory");
            Permission permission = new Permission()
            {
                Create = true,
                List = true,
                Modify = true,
                Remove = true
            };
            contextMenuNewInventory = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonInventoryNew_Click));
            contextMenuEditInventory = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonInventoryEdit_Click));
            contextMenuDeleteInventory = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonInventoryDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.SetPermissions(permission);
            this.LoadGridControl();
            this.GridViewInventory.RowClick += this.GridViewInventory_RowClick;
            this.SetContextMenu(this.GridViewInventory);
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonInventoryNew.Visible = permission.Create;
            this.contextMenuNewInventory.Visible = permission.Create;
            this.ButtonInventoryEdit.Visible = permission.Modify;
            this.contextMenuEditInventory.Visible = permission.Modify;
            this.ButtonInventoryDelete.Visible = permission.Remove;
            this.contextMenuDeleteInventory.Visible = permission.Remove;
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
            pmenu.Items.Add(contextMenuNewInventory);
            pmenu.Items.Add(contextMenuEditInventory);
            pmenu.Items.Add(contextMenuDeleteInventory);
            e.Menu = pmenu;
        }

        private void GridViewInventory_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedInventory = new InventoryModel();
            this.selectedInventory = this.GridViewInventory.GetRow(e.RowHandle) as InventoryModel;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.Inventory.List(this.GridControlInventory);
        }

        private void ButtonInventoryNew_Click(object sender, EventArgs e)
        {
            InventoryEdit inventoryEdit = new InventoryEdit();
            inventoryEdit.ShowDialog();
            if (inventoryEdit.DialogResult == DialogResult.OK)
            {
                inventoryEdit.Dispose();
            }
        }

        private void ButtonInventoryEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedInventory == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                InventoryEdit inventoryEdit = new InventoryEdit(this.selectedInventory);
                inventoryEdit.ShowDialog();
                if (inventoryEdit.DialogResult == DialogResult.OK)
                {
                    inventoryEdit.Dispose();
                }
                this.LoadGridControl();
            }

        }

        private void ButtonInventoryDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedInventory == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.Inventory.Delete(this.selectedInventory);
                this.LoadGridControl();
            }

        }

        private void ButtonInventoryRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxSearch.Text))
            {
                this.LoadGridControl();
            }
            else
            {
                this.unitOfWork.Inventory.Search(this.TextBoxSearch.Text, this.GridControlInventory);
            }
                
        }
    }
}