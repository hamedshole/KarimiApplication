using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IInventoryManagement
    {
        string AddItem(InventoryLogModel item);
        List<InventoryLogModel> GetItemLog(ItemModel item);
        decimal GetItemStock(ItemModel item);
    }
}
