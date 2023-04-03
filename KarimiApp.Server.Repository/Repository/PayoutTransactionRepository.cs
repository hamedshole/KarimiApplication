using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PayoutTransactionRepository : IPayoutTransaction
    {
        IPayoutTransaction repository;

        public PayoutTransactionRepository(IPayoutTransaction repository)
        {
            this.repository = repository;
        }

        string IBaseTransaction<PayoutTransactionModel>.Delete(PayoutTransactionModel model)
        {
            return this.repository.Delete(model);
        }

        string IBaseTransaction<PayoutTransactionModel>.Insert(PayoutTransactionModel model)
        {
            return repository.Insert(model);
        }

        List<PayoutTransactionModel> IPayoutTransaction.Read(PayoutTransactionModel payoutTransaction)
        {
            return repository.Read(payoutTransaction);
        }

        List<PayoutTransactionModel> IBaseTransaction<PayoutTransactionModel>.Search(PayoutTransactionModel model)
        {
            return repository.Search(model);
        }
    }
}
