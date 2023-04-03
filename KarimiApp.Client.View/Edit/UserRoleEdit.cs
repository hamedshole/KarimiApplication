using KarimiApp.Model;
using System;
using KarimiApp.Client.Repository;
using DevExpress.XtraEditors;
using KarimiApp.Client.View.Settings;
using System.Security.Cryptography;

namespace KarimiApp.Client.View.Edit
{
    public partial class UserRoleEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private UserRoleModel userRoleCurrent;
  
        public UserRoleEdit()
        {
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            this.Text = "نقش جدید";
            this.ButtonSave.Click += ButtonSave_Click_New;
        }

        private void ButtonSave_Click_New(object sender, EventArgs e)
        {
            UserRoleModel tmp = this.GetValues();
            this.unitOfWork.UserRole.Create(tmp);
            this.Close();
        }

        public UserRoleEdit(UserRoleModel userRole)
        {
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            this.Text = "ویرایش نقش";
            this.userRoleCurrent = userRole;
            this.SetValues(userRole);
            this.ButtonSave.Click += ButtonSave_Click_Update;
        }

        private void ButtonSave_Click_Update(object sender, EventArgs e)
        {
            UserRoleModel tmp = this.GetValuesUpdate();
            this.unitOfWork.UserRole.Update(tmp);
            this.Close();
        }

        private UserRoleModel GetValues()
        {
           return new UserRoleModel(
                title: TextBoxTitle.Text,
                active:this.CheckBoxActive.Checked,
                cashierRibbon:this.userRoleCurrent.CashierRibbon,
                info:this.TreeViewUserRole.GetPermissions(),
                description:this.TextBoxDescription.Text);
          
        }
        private UserRoleModel GetValuesUpdate()
        {
          return new UserRoleModel(
            id: Convert.ToInt32(TextBoxId.Text),
            title: TextBoxTitle.Text,
            active:this.CheckBoxActive.Checked,
            cashierRibbon: this.userRoleCurrent.CashierRibbon,
            info: this.TreeViewUserRole.GetPermissions(),// get string type of userroles from treeview user control.
            description:this.TextBoxDescription.Text
            );
        }

        private void SetValues(UserRoleModel userRole)
        {
            TextBoxTitle.Text = userRole.Title;
            TextBoxId.Text = userRole.Id.ToString();
         //   TreeViewUserRole.SetPermission(userRole.Info);
            this.CheckBoxActive.Checked = userRole.Active;
            TextBoxDescription.Text = userRole.Description;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEditToolbar_Click(object sender, EventArgs e)
        {
            CustomizeToolbar customizeToolbar = new CustomizeToolbar(this);
           
            if (this.userRoleCurrent!=null)
            {
                customizeToolbar.FillRibbon(this.userRoleCurrent.CashierRibbon);
            }
            customizeToolbar.Show();

        }

        internal void SetToolbar(string cashierRibbon)
        {
            if (this.userRoleCurrent == null)
            {
                this.userRoleCurrent = new UserRoleModel();
            }
            this.userRoleCurrent.CashierRibbon = cashierRibbon;
        }
    }
}