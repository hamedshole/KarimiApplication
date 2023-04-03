using System;
using System.Windows.Forms;
using KarimiApp.Model;
using KarimiApp.Client.Repository;
using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.View.Edit;

namespace KarimiApp.Client.View.List
{
    public partial class UserList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private UserModel selectedUser;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewUser;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditUser;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteUser;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserList"/> class.
        /// </summary>
        public UserList()
        {
            Permission permission = new Permission()
            {
                List = true,
                Create = true,
                Modify = true,
                Remove = true
            };
            //Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "userlist");
            contextMenuNewUser = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonUserNew_Click));
            contextMenuEditUser = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonUserEdit_Click));
            contextMenuDeleteUser = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonUserDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.SetPermissions(permission);
            this.LoadGridControl();
            this.SetContextMenu(this.GridViewUser);
            this.GridViewUser.RowClick += this.GridViewCustomer_RowClick;
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonUserNew.Visible = permission.Create;
            this.contextMenuNewUser.Visible = permission.Create;
            this.ButtonUserEdit.Visible = permission.Modify;
            this.contextMenuEditUser.Visible = permission.Modify;
            this.ButtonUserDelete.Visible = permission.Remove;
            this.contextMenuDeleteUser.Visible = permission.Remove;
        }

        private void GridViewCustomer_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedUser = new UserModel();
            this.selectedUser = this.GridViewUser.GetRow(e.RowHandle) as UserModel;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        public void LoadGridControl()
        {
            this.unitOfWork.User.List(this.GridControlUser);
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
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(this.GridViewUser);
            pmenu.Items.Add(contextMenuNewUser);
            pmenu.Items.Add(contextMenuEditUser);
            pmenu.Items.Add(contextMenuDeleteUser);
            e.Menu = pmenu;
        }

        private void ButtonUserNew_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.Show();
        }

        private void ButtonUserEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedUser == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                UserEdit userEdit = new UserEdit(this.selectedUser);
                userEdit.Show();
                if (userEdit.DialogResult == DialogResult.OK)
                {
                    userEdit.Dispose();
                    this.LoadGridControl();
                }
            }
           
        }

        private void ButtonUserDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedUser == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.User.Delete(this.selectedUser);
                this.LoadGridControl();
            }
           
        }


        private void ButtonUserRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.User.Search(this.TextBoxSearch.Text,this.GridControlUser);
        }
    }
}