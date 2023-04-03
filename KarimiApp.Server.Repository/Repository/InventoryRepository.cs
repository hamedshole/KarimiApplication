using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class InventoryRepository : MainRepository<InventoryModel>,IInventory
    {
        public InventoryRepository(IInventory repository) : base(repository)
        {
        }
    }
}
