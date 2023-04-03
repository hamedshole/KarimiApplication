using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class ItemCategoryList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private ItemCategoryModel selectedItemCategory;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewItemCategory;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditItemCategory;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteItemCategory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoryList"/> class.
        /// </summary>
        public ItemCategoryList( )
        {
            contextMenuNewItemCategory = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonItemCategoryNew_Click));
            contextMenuEditItemCategory = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonItemCategoryEdit_Click));
            contextMenuDeleteItemCategory = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonItemCategoryDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.GridVIewItemCategory.RowClick += this.GridViewInventoryType_RowClick;
            this.SetContextMenu(this.GridVIewItemCategory);
            this.LoadGridControl();
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonItemCategoryNew.Visible = permission.Create;
            this.contextMenuNewItemCategory.Visible = permission.Create;
            this.ButtonItemCategoryEdit.Visible = permission.Modify;
            this.contextMenuEditItemCategory.Visible = permission.Modify;
            this.ButtonItemCategoryDelete.Visible = permission.Remove;
            this.contextMenuDeleteItemCategory.Visible = permission.Remove;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.ItemCategory.List(this.GridControlItemCategory);
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
            pmenu.Items.Add(contextMenuNewItemCategory);
            pmenu.Items.Add(contextMenuEditItemCategory);
            pmenu.Items.Add(contextMenuDeleteItemCategory);
            e.Menu = pmenu;
        }

        private void GridViewInventoryType_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedItemCategory = new ItemCategoryModel();
            this.selectedItemCategory = this.GridVIewItemCategory.GetRow(e.RowHandle) as ItemCategoryModel;
        }

        private void ButtonItemCategoryNew_Click(object sender, EventArgs e)
        {
            ItemCategoryEdit categoryEdit = new ItemCategoryEdit();
            categoryEdit.ShowDialog();
            if (categoryEdit.DialogResult == DialogResult.OK)
            {
                categoryEdit.Dispose();
            }
        }

        private void ButtonItemCategoryEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedItemCategory == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                ItemCategoryEdit categoryEdit = new ItemCategoryEdit(this.selectedItemCategory);
                categoryEdit.ShowDialog();
                if (categoryEdit.DialogResult == DialogResult.OK)
                {
                    categoryEdit.Dispose();
                }
                this.LoadGridControl();
            }
            
        }

        private void ButtonItemCategoryDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedItemCategory == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.ItemCategory.Delete(this.selectedItemCategory);
                this.LoadGridControl();
            }
           
        }

        private void ButtonItemCategoryRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.ItemCategory.Search(this.TextBoxSearch.Text,this.GridControlItemCategory);
        }
    }
}