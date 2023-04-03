using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface ITransactionRepo:ITransaction
    {
        void InsertItem(TransactionEntryModel transactionEntry,int transaction);
        List<TransactionEntryModel> TransactionEntriesRead(int transactionid);
        void UpdateReceiptTransaction(int receipt, int transaction);
    }
}
