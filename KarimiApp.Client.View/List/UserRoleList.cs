using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class UserRoleList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private UserRoleModel selectedUserRole;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewUserRole;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditUserRole;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteUserRole;
        public UserRoleList()
        {
            Permission permission = new Permission()
            {
                Remove = true,
                Modify = true,
                Create = true,
                List = true
            };
         //   Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Permissions.Find(x => x.Name.ToLower() == "userrole");
            contextMenuNewUserRole = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonUserRoleNew_Click));
            contextMenuEditUserRole = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonUserRoleEdit_Click));
            contextMenuDeleteUserRole = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonUserRoleDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.SetPermissions(permission);
            //this.Text = Resources.UserRolePageList;
            this.GridViewUserRole.RowClick += this.GridViewUserRole_RowClick;
            this.SetContextMenu(this.GridViewUserRole);
            this.LoadGridControl();

        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonUserRoleNew.Visible = permission.Create;
            this.contextMenuNewUserRole.Visible = permission.Create;
            this.ButtonUserRoleEdit.Visible = permission.Modify;
            this.contextMenuEditUserRole.Visible = permission.Modify;
            this.ButtonUserRoleDelete.Visible = permission.Remove;
            this.contextMenuDeleteUserRole.Visible = permission.Remove;
        }


        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.UserRole.List(this.GridControlUserRole);
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
            pmenu.Items.Add(contextMenuNewUserRole);
            pmenu.Items.Add(contextMenuEditUserRole);
            pmenu.Items.Add(contextMenuDeleteUserRole);
            e.Menu = pmenu;
        }

        private void GridViewUserRole_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedUserRole = new UserRoleModel();
            this.selectedUserRole = this.GridViewUserRole.GetRow(e.RowHandle) as UserRoleModel;
        }

        private void ButtonUserRoleNew_Click(object sender, EventArgs e)
        {
            UserRoleEdit userRoleEdit = new UserRoleEdit();
            userRoleEdit.ShowDialog();
            if (userRoleEdit.DialogResult == DialogResult.OK)
            {
                userRoleEdit.Dispose();
            }
        }

        private void ButtonUserRoleEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedUserRole == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                UserRoleEdit userRoleEdit = new UserRoleEdit(this.selectedUserRole);
                userRoleEdit.ShowDialog();
                if (userRoleEdit.DialogResult == DialogResult.OK)
                {
                    userRoleEdit.Dispose();
                }
                this.LoadGridControl();
            }
           
        }

        private void ButtonUserRoleDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedUserRole == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.UserRole.Delete(this.selectedUserRole);
                this.LoadGridControl();
            }
           
        }

        private void ButtonUserRoleRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.UserRole.Search(this.TextBoxSearch.Text,this.GridControlUserRole );
        }
    }
}