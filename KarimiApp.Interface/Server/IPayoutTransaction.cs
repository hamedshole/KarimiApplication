using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IPayoutTransaction : IBaseTransaction<PayoutTransactionModel>
    {
        List<PayoutTransactionModel> Read(PayoutTransactionModel payoutTransaction);
    }
}
