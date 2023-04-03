using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IItem : IMain<ItemModel>
    {
        List<ItemModel> FilterByDepartment(string department);
        List<ItemModel> SearchFilterByDepartment(ItemModel item);
        ReceiptEntryModel GetByBarcode(string barcode);
    }
}
