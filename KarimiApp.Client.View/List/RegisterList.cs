using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{
    public partial class RegisterList : DevExpress.XtraEditors.XtraUserControl
    {

        private UnitOfWork repository;
        private RegisterModel selectedRegister;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewRegister;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditRegister;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeleteRegister;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterList"/> class.
        /// </summary>
        public RegisterList()
        {
            contextMenuNewRegister = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonRegisterNew_Click));
            contextMenuEditRegister = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonRegisterEdit_Click));
            contextMenuDeleteRegister = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonRegisterDelete_Click));
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.GridViewRegister.RowClick += this.GridViewRegister_RowClick; ;
            this.SetContextMenu(this.GridViewRegister);
            this.LoadGridControl();
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.repository.Register.List(this.GridControlRegister);
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
            pmenu.Items.Add(contextMenuNewRegister);
            pmenu.Items.Add(contextMenuEditRegister);
            pmenu.Items.Add(contextMenuDeleteRegister);
            e.Menu = pmenu;
        }

        private void GridViewRegister_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.selectedRegister = new RegisterModel();
            this.selectedRegister = this.GridViewRegister.GetRow(e.RowHandle) as RegisterModel;
        }

        private void ButtonRegisterNew_Click(object sender, EventArgs e)
        {
            RegisterEdit registerEdit = new RegisterEdit();
            registerEdit.ShowDialog();
            if (registerEdit.DialogResult == DialogResult.OK)
            {
                registerEdit.Dispose();
            }
        }

        private void ButtonRegisterEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedRegister == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                RegisterEdit registerEdit = new RegisterEdit(this.selectedRegister);
                registerEdit.ShowDialog();
                if (registerEdit.DialogResult == DialogResult.OK)
                {
                    registerEdit.Dispose();
                    this.LoadGridControl();
                }
            }
            
        }

        private void ButtonRegisterDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedRegister == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.repository.Register.Delete(this.selectedRegister);
                this.LoadGridControl();
            }
           
        }

        private void ButtonRegisterRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.repository.Register.Search(this.TextBoxSearch.Text,this.GridControlRegister);
        }
    }
}