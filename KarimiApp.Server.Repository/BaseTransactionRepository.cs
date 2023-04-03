using KarimiApp.Interface.Server;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository
{
    internal class BaseTransactionRepository<TModel> : IBaseTransaction<TModel>
    {
        private IBaseTransaction<TModel> baseTransactionRepository;

        public BaseTransactionRepository(IBaseTransaction<TModel> baseTransactionRepository)
        {
            this.baseTransactionRepository = baseTransactionRepository;
        }

        string IBaseTransaction<TModel>.Insert(TModel model)
        {
           return baseTransactionRepository.Insert(model);
        }

        List<TModel> IBaseTransaction<TModel>.Read()
        {
           return this.baseTransactionRepository.Read();
        }

        List<TModel> IBaseTransaction<TModel>.Search(TModel model)
        {
            return this.baseTransactionRepository.Search(model);
        }
    }
}
