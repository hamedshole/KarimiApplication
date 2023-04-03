using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class SupplierRepository : MainRepository<SupplierAgentModel>, ISupplier
    {
        public SupplierRepository(ISupplier repository) : base(repository)
        {
        }
    }
}
