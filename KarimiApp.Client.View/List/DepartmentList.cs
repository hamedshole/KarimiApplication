using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class DepartmentList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork unitOfWork;
        private DepartmentModel selectedDepartment;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewDepartment;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditDepartment;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteDepartment;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerList"/> class.
        /// </summary>
        public DepartmentList( )
        {
            contextMenuNewDepartment = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonDepartmentNew_Click));
            contextMenuEditDepartment = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonDepartmentEdit_Click));
            contextMenuDeleteDepartment = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonDepartmentDelete_Click));
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.LoadGridControl();
            this.SetContextMenu(this.GridViewDepartment);
            this.GridViewDepartment.RowClick += GridViewDepartment_RowClick;
        }

        private void GridViewDepartment_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedDepartment = new DepartmentModel();
            this.selectedDepartment = this.GridViewDepartment.GetRow(e.RowHandle) as DepartmentModel;
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonDepartmentNew.Visible = permission.Create;
            this.contextMenuNewDepartment.Visible = permission.Create;
            this.ButtonDepartmentEdit.Visible = permission.Modify;
            this.contextMenuEditDepartment.Visible = permission.Modify;
            this.ButtonDepartmentDelete.Visible = permission.Remove;
            this.contextMenuDeleteDepartment.Visible = permission.Remove;
        }
        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.unitOfWork.Department.List(this.GridControlDepartment);
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
            DevExpress.XtraGrid.Menu.GridViewMenu pmenu = new DevExpress.XtraGrid.Menu.GridViewMenu(this.GridViewDepartment);
            pmenu.Items.Add(contextMenuNewDepartment);
            pmenu.Items.Add(contextMenuEditDepartment);
            pmenu.Items.Add(contextMenuDeleteDepartment);
            e.Menu = pmenu;
        }

        private void ButtonDepartmentNew_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission();
            DepartmentEdit departmentEdit = new DepartmentEdit();
            departmentEdit.Show();
            if (departmentEdit.DialogResult == DialogResult.OK)
            {
                departmentEdit.Dispose();
            }
            this.LoadGridControl();
        }

        private void ButtonDepartmentEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedDepartment == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                DepartmentEdit departmentEdit = new DepartmentEdit(this.selectedDepartment);
                departmentEdit.Show();
                if (departmentEdit.DialogResult == DialogResult.OK)
                {
                    departmentEdit.Dispose();
                }
                this.LoadGridControl();
            }
            
        }

        private void ButtonDepartmentDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedDepartment == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.unitOfWork.Department.Delete(this.selectedDepartment);
                this.LoadGridControl();
            }
           
        }

        private void ButtonDepartmentRefresh_Click(object sender, EventArgs e)
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
                this.unitOfWork.Department.Search(this.TextBoxSearch.Text, GridControlDepartment);
            }
        }
    }
}