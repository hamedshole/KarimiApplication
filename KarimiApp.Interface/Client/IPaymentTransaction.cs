using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IPaymentTransaction:IBaseTransaction<PaymentTransactionModel>
    {
        List<PaymentTransactionModel> List();
        void List(GridControl gridControl);
    }
}
