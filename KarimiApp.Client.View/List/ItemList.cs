using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class ItemList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork  unitOfWork;
        private ItemModel selectedItem;
        DevExpress.Utils.Menu.DXMenuItem contextMenuNewItem;
        DevExpress.Utils.Menu.DXMenuItem contextMenuEditItem;
        DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemList"/> class.
        /// </summary>
        public ItemList()
        {
            Permission permission = new Permission
            {
                Create = true,
                List = true,
                Modify = true,
                Remove = true
            };
           // Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "item");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            contextMenuNewItem = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonItemNew_Click));
            contextMenuEditItem = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonItemEdit_Click));
            contextMenuDeleteItem = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonItemDelete_Click));
            this.SetPermissions(permission);
            // this.Text = Resources.ItemPageList;
            this.GridViewItem.RowClick += this.GridViewItem_RowClick; ;
            this.SetContextMenu(this.GridViewItem);
            this.LoadGridControl();
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonItemNew.Visible = permission.Create;
            this.contextMenuNewItem.Visible = permission.Create;
            this.ButtonItemEdit.Visible = permission.Modify;
            this.contextMenuEditItem.Visible = permission.Modify;
            this.ButtonItemDelete.Visible = permission.Remove;
            this.contextMenuDeleteItem.Visible = permission.Remove;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.Item.List(this.GridControlItem);
        }

        private void GridViewItem_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.selectedItem = new ItemModel();
            this.selectedItem = this.GridViewItem.GetRow(e.RowHandle) as ItemModel;
        }

        /// <summary>
        /// Sets the context menu.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetContextMenu(GridView view)
        {
            view.PopupMenuShowing += View_PopupMenuShowing;
            //   view.PopupMenuShowing += this.GridView_PopupMenuShowing;
        }

        private void View_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(sender as GridView);
            pmenu.Items.Add(contextMenuNewItem);
            pmenu.Items.Add(contextMenuEditItem);
            pmenu.Items.Add(contextMenuDeleteItem);
            e.Menu = pmenu;
        }


        private void ButtonItemNew_Click(object sender, EventArgs e)
        {
            ItemEdit itemEdit = new ItemEdit();
            itemEdit.ShowDialog();
            if (itemEdit.DialogResult == DialogResult.OK)
            {
                itemEdit.Dispose();
            }
        }

        private void ButtonItemEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedItem == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                ItemEdit itemEdit = new ItemEdit(selectedItem);
                itemEdit.ShowDialog();
                if (itemEdit.DialogResult == DialogResult.OK)
                {
                    itemEdit.Dispose();
                }
                this.LoadGridControl();
            }
            
        }

        private void ButtonItemDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedItem == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.Item.Delete(this.selectedItem);
                this.LoadGridControl();
            }
           
        }

        private void ButtonItemRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Item.Search(TextBoxSearch.Text,this.GridControlItem);
        }
    }
}