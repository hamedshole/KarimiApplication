using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IItem:IMainRepository<ItemModel>
    {
        void FilterByDepartment(GridControl grid, string department);
        List<ItemModel> FilterByDepartment(string department);
        void SearchFilterByDepartment(GridControl grid, ItemModel item);
        List<ItemModel> SearchFilterByDepartment(ItemModel item);
        ReceiptEntryModel GetByBarcode(string barcode);
    }
}
