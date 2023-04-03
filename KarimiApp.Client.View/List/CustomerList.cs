using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class CustomerList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private PersonModel selectedCustomer;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewCustomer;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditCustomer;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteCustomer;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerList"/> class.
        /// </summary>
        public CustomerList()
        {
            Permission permission = new Permission
            {
                Create = true,
                List = true,
                Modify = true,
                Remove = true
            };
            //Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "customer");
            contextMenuNewCustomer = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonCustomerNew_Click));
            contextMenuEditCustomer = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonCustomerEdit_Click));
            contextMenuDeleteCustomer = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonCustomerEdit_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.SetPermissions(permission);
            this.LoadGridControl();
            this.SetContextMenu(this.GridViewCustomer);
            this.GridViewCustomer.RowClick += this.GridViewCustomer_RowClick;
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonCustomerNew.Visible = permission.Create;
            this.contextMenuNewCustomer.Visible = permission.Create;
            this.ButtonCustomerEdit.Visible = permission.Modify;
            this.contextMenuEditCustomer.Visible = permission.Modify;
            this.ButtonCustomerDelete.Visible = permission.Remove;
            this.contextMenuDeleteCustomer.Visible = permission.Remove;
        }

        private void GridViewCustomer_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedCustomer = new PersonModel();
            this.selectedCustomer = this.GridViewCustomer.GetRow(e.RowHandle) as PersonModel;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.Person.List(this.GridControlCustomer);
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
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(this.GridViewCustomer);
            pmenu.Items.Add(contextMenuNewCustomer);
            pmenu.Items.Add(contextMenuEditCustomer);
            pmenu.Items.Add(contextMenuDeleteCustomer);
            e.Menu = pmenu;
        }

        private void ButtonCustomerNew_Click(object sender, EventArgs e)
        {
            PersonEdit customerEdit = new PersonEdit();
            customerEdit.ShowDialog();
            if (customerEdit.DialogResult == DialogResult.OK)
            {
                customerEdit.Dispose();
            }
        }

        private void ButtonCustomerEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedCustomer == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                PersonEdit customerEdit = new PersonEdit(this.selectedCustomer);
                customerEdit.Show();
            }
        }

        private void ButtonCustomerDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedCustomer == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.Person.Delete(this.selectedCustomer);
                this.LoadGridControl();
            }
           
        }

        private void ButtonCustomerRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Person.Search(gridControl: this.GridControlCustomer,text: this.TextBoxSearch.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.unitOfWork.Person.Settle(this.selectedCustomer);
        }
    }
}