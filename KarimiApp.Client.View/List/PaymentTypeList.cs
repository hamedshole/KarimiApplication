using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Edit;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.List
{

    public partial class PaymentTypeList : DevExpress.XtraEditors.XtraUserControl
    {
        private UnitOfWork repository;
        private PaymentTypeModel selectedPayType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuNewPaymentType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuEditPaymentType;
        private DevExpress.Utils.Menu.DXMenuItem contextMenuDeletePaymentType;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTypeList"/> class.
        /// </summary>
        public PaymentTypeList()
        {
            contextMenuNewPaymentType = new DevExpress.Utils.Menu.DXMenuItem("جدید", new EventHandler(this.ButtonPaymentTypeNew_Click));
            contextMenuEditPaymentType = new DevExpress.Utils.Menu.DXMenuItem("ویرایش", new EventHandler(this.ButtonPaymentTypeEdit_Click));
            contextMenuDeletePaymentType = new DevExpress.Utils.Menu.DXMenuItem("حذف", new EventHandler(this.ButtonPaymentTypeDelete_Click));
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.GridViewPaymentType.RowClick += this.GridViewItem_RowClick;
            this.SetContextMenu(this.GridViewPaymentType);
            this.LoadGridControl();
        }

        private void SetPermissions(Permission permission)
        {
            this.ButtonPaymentTypeNew.Visible = permission.Create;
            this.contextMenuNewPaymentType.Visible = permission.Create;
            this.ButtonPaymentTypeEdit.Visible = permission.Modify;
            this.contextMenuEditPaymentType.Visible = permission.Modify;
            this.ButtonPaymentTypeDelete.Visible = permission.Remove;
            this.contextMenuDeletePaymentType.Visible = permission.Remove;
        }

        /// <summary>
        /// Loads the grid control.
        /// </summary>
        private void LoadGridControl()
        {
            this.repository.PaymentType.List(this.GridControlPaymentType);
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
            pmenu.Items.Add(contextMenuNewPaymentType);
            pmenu.Items.Add(contextMenuEditPaymentType);
            pmenu.Items.Add(contextMenuDeletePaymentType);
            e.Menu = pmenu;
        }

        private void GridViewItem_RowClick(object sender, RowClickEventArgs e)
        {
            this.selectedPayType = new PaymentTypeModel();
            this.selectedPayType = this.GridViewPaymentType.GetRow(e.RowHandle) as PaymentTypeModel;
        }

        private void ButtonPaymentTypeNew_Click(object sender, EventArgs e)
        {
            PaymentTypeEdit paymentTypeEdit = new PaymentTypeEdit();
            paymentTypeEdit.Show();
        }

        private void ButtonPaymentTypeEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedPayType == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                PaymentTypeEdit paymentTypeEdit = new PaymentTypeEdit(selectedPayType);
                paymentTypeEdit.ShowDialog();
                if (paymentTypeEdit.DialogResult == DialogResult.OK)
                {
                    paymentTypeEdit.Dispose();
                    this.LoadGridControl();
                }
            }
            
        }

        private void ButtonPaymentTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPayType == null)
            {
                MessageBox.Show("آیتمی انتخاب نشده است");
            }
            else
            {
                this.repository.PaymentType.Delete(this.selectedPayType);
                this.LoadGridControl();
            }
           
        }

        private void ButtonItemRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGridControl();
        }

        private void TextBoxSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.repository.PaymentType.Search( this.TextBoxSearch.Text,this.GridControlPaymentType);
        }
    }
}
