using KarimiApp.Model;

namespace KarimiApp.Client.View.Util.Pos
{
    public interface ISamanPos
    {
        bool PosPurchase(TransactionModel transaction,string gridMemoryComboValue,long discountvalue=0);
    }
}