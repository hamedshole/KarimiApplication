using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IInventoryManagement
    {
        string AddItem(InventoryLogModel itemlog);
        List<InventoryLogModel> GetItemLog(ItemModel item);
        void GetItemLog(ItemModel item, GridControl grid);
        decimal GetItemStock(ItemModel item);
    }
}
