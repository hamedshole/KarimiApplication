using KarimiApp.Model;

namespace KarimiApp.Client.PosRepository.Interface
{
    public interface ISamanPos
    {
        bool PosPurchase(TransactionModel transaction);
    }
}
