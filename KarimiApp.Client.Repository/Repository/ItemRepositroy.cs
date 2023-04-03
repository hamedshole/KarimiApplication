using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class ItemRepositroy : MainRepository<ItemModel>, IItem
    {
        HttpClientAccess httpClient;
        private readonly string _route = "item";
        public ItemRepositroy(HttpClientAccess httpClient) : base("item", httpClient)
        {
            this.httpClient = httpClient;
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var result = this.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Name));
        }

        void IItem.FilterByDepartment(GridControl grid, string department)
        {
            List<ItemModel> items = FilterByDepartment(department);
            grid.DataSource = items;
        }

        private List<ItemModel> FilterByDepartment(string department)
        {
            return Task.Run(async () => await this.httpClient.Post<string, List<ItemModel>>(department, _route + "/filterbydepartment")).Result;
        }

        void IItem.SearchFilterByDepartment(GridControl grid, ItemModel item)
        {
            List<ItemModel> items = SearchFilterByDepartment(item);
            grid.DataSource = items;
        }

        private List<ItemModel> SearchFilterByDepartment(ItemModel item)
        {
           // httpClient = new HttpClientAccess();
           // List<ItemModel> items = Task.Run(async () => await this.httpClient.Post<ItemModel, List<ItemModel>>(item, _route + "/searchfilterbydepartment")).Result;
           // httpClient
            return Task.Run(async () => await this.httpClient.Post<ItemModel, List<ItemModel>>(item, _route + "/searchfilterbydepartment")).Result;
        }

        List<ItemModel> IItem.FilterByDepartment(string department)
        {
            return FilterByDepartment(department);
        }

        List<ItemModel> IItem.SearchFilterByDepartment(ItemModel item)
        {
            return SearchFilterByDepartment(item);
        }

        ReceiptEntryModel IItem.GetByBarcode(string barcode)
        {
            return Task.Run(async () => await this.httpClient.Post<string, ReceiptEntryModel>(barcode, _route + "/getbybarcode")).Result;
        }
    }
}
