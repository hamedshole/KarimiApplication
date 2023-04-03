using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    public class InventoryManagementRepository : IInventoryManagement
    {
        HttpClientAccess httpClient;
        private string _route = "inventorymanagement/";

        public InventoryManagementRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        string IInventoryManagement.AddItem(InventoryLogModel item)
        {
            return Task.Run(async () => await this.httpClient.PostReturnString(item, _route + "additem")).Result;
        }

        List<InventoryLogModel> IInventoryManagement.GetItemLog(ItemModel item)
        {
            return this.GetItemLogList(item);
        }

        private List<InventoryLogModel> GetItemLogList(ItemModel item)
        {
            return Task.Run(async () => await this.httpClient.Post<ItemModel, List<InventoryLogModel>>(item, _route + "getitemlog")).Result;
        }

        void IInventoryManagement.GetItemLog(ItemModel item, GridControl grid)
        {
            var list = this.GetItemLogList(item);
            grid.DataSource = list;
        }

        decimal IInventoryManagement.GetItemStock(ItemModel item)
        {
            return Task.Run(async () => await this.httpClient.Post<ItemModel, Decimal>(item, _route + "getitemstock")).Result;
        }
    }
}
