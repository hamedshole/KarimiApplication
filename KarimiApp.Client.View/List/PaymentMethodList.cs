using System;
using System.Windows.Forms;
using KarimiApp.Model;
using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KarimiApp.Client.View.List
{
    public partial class PaymentMethodList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork repository;
        private PaymentMethodModel selectedPaymentMethod;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewPaymentMethod;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditPaymentMethod;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeletePaymentMethod;
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeList"/> class.
        /// </summary>
        public PaymentMethodList()
        {
            contextMenuNewPaymentMethod = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonPaymentMethodNew_Click));
            contextMenuEditPaymentMethod = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonPaymentMethodEdit_Click));
            contextMenuDeletePaymentMethod = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonPaymentMethodDelete_Click));
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.GridViewPaymentMethod.RowClick += this.GridViewPaymentMethod_RowClick;
            this.SetContextMenu(this.GridViewPaymentMethod);
            this.LoadGridControl();
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonPaymentMethodNew.Visible = permission.Create;
            this.contextMenuNewPaymentMethod.Visible = permission.Create;
            this.ButtonPaymentMethodEdit.Visible = permission.Modify;
            this.contextMenuEditPaymentMethod.Visible = permission.Modify;
            this.ButtonPaymentMethodDelete.Visible = permission.Remove;
            this.contextMenuDeletePaymentMethod.Visible = permission.Remove;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.repository.PaymentMethod.List(this.GridControlPaymentMethod);
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
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonPaymentMethodNew_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonPaymentMethodEdit_Click)));
            pmenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonPaymentMethodDelete_Click)));
            e.Menu = pmenu;
        }

        private void GridViewPaymentMethod_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.selectedPaymentMethod = new PaymentMethodModel();
            this.selectedPaymentMethod = this.GridViewPaymentMethod.GetRow(e.RowHandle) as PaymentMethodModel;
        }

        private void ButtonPaymentMethodNew_Click(object sender, EventArgs e)
        {
            PaymentMethodEdit paymentMethod = new PaymentMethodEdit();
            paymentMethod.Show();
        }

        private void ButtonPaymentMethodEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedPaymentMethod == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                PaymentMethodEdit paymentMethodEdit = new PaymentMethodEdit(this.selectedPaymentMethod);
                paymentMethodEdit.Show();
            }
           
        }

        private void ButtonPaymentMethodDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPaymentMethod == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.repository.PaymentMethod.Delete(this.selectedPaymentMethod);
                this.LoadGridControl();
            }
          
        }

        private void ButtonPaymentMethodRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.repository.PaymentMethod.Search(this.TextBoxSearch.Text,this.GridControlPaymentMethod);
        }
    }
}
