using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class TransactionTypeRepository : MainRepository<TransactionTypeModel>, ITransactionType
    {
        public TransactionTypeRepository(ITransactionType repository) : base(repository)
        {
        }
    }
}
