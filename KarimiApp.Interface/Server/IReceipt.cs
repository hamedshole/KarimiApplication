using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IReceipt
    {
        string Insert(ReceiptModel receipt);
        List<ReceiptModel> List(WorkstationReceiptFilterModel workstationReceiptFilterModel);
        ReceiptModel Get(string barcode);
        List<ReceiptModel> CashierList();
        TransactionModel GetTransaction(int id);
    }
}
