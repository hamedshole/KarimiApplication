using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class InventoryGroupRepository : MainRepository<InventoryGroupModel>,IInventoryGroup
    {
        public InventoryGroupRepository(IInventoryGroup repository) : base(repository)
        {
        }
    }
}
