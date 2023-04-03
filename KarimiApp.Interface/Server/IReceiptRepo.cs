using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IReceiptRepo:IReceipt
    {
        bool InsertItem(ReceiptEntryModel receiptEntry);
        List<ReceiptEntryModel> ReceiptItemsRead(int Receipt);
        ReceiptEntryModel ItemByBarcode(string barcode);
        TransactionModel GetTransaction(int id);
        List<TransactionEntryModel> GetTransactionItems(int id);
    }
}
