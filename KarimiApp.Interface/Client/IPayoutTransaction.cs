using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IPayoutTransaction:IBaseTransaction<PayoutTransactionModel>
    {
        List<PayoutTransactionModel> List(PayoutTransactionModel payoutTransaction);
        void List(GridControl gridControl,PayoutTransactionModel payoutTransaction);
    }
}
