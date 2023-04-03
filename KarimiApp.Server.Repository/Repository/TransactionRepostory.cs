using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class TransactionRepostory : BaseTransactionRepository<TransactionModel>,ITransaction
    {
        public TransactionRepostory(IBaseTransaction<TransactionModel> baseTransactionRepository) : base(baseTransactionRepository)
        {
        }
    }
}
