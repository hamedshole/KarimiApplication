using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    public class InventoryManagementRepository : IInventoryManagement
    {
        IInventoryManagement dbAccess;

        public InventoryManagementRepository(IInventoryManagement dbAccess)
        {
            this.dbAccess = dbAccess;
        }

        List<InventoryLogModel> IInventoryManagement.GetItemLog(ItemModel item)
        {
            return this.dbAccess.GetItemLog(item);
        }

        decimal IInventoryManagement.GetItemStock(ItemModel item)
        {
            return dbAccess.GetItemStock(item);
        }

        string IInventoryManagement.AddItem(InventoryLogModel item)
        {
            return this.dbAccess.AddItem(item);
        }
    }
}
