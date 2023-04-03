using DevExpress.XtraGrid;
using KarimiApp.Model;

namespace KarimiApp.Interface.Client
{
    public interface IReceipt
    {
        ReceiptModel Get(string barcode);
        string Insert(ReceiptModel receipt);
        void List(WorkstationReceiptFilterModel workstationReceiptFilter, GridControl grid);
        void List(GridControl grid);
        TransactionModel GetTransaction(int id);
    }
}
