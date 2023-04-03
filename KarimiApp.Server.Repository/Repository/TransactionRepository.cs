using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    public class TransactionRepository : ITransaction
    {
        ITransactionRepo repository;

        public TransactionRepository(ITransactionRepo repository)
        {
            this.repository = repository;
        }

        public long LastValue()
        {
            return repository.LastValue();
        }

        string IBaseTransaction<TransactionModel>.Delete(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<TransactionModel>.Insert(TransactionModel model)
        {
            var msg = repository.Insert(model);
            model.Entries.ForEach(x => repository.InsertItem(x,model.Id));
            model.Receipts.ForEach(x => this.repository.UpdateReceiptTransaction(x, model.Id));
            return msg;
        }

        string ITransaction.LastCode()
        {
            return this.repository.LastCode();
        }

        List<TransactionModel> ITransaction.Read()
        {
            List<TransactionModel> transactions = repository.Read();
            transactions.ForEach(x => x.SetEntries(repository.TransactionEntriesRead(x.Id)));
            return transactions;
        }

        List<TransactionModel> IBaseTransaction<TransactionModel>.Search(TransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
