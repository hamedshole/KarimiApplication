using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Client.Repository.Repository
{
    internal class InventoryRepository : MainRepository<InventoryModel>,IInventory
    {
        public InventoryRepository(HttpClientAccess httpClient) : base("inventory",httpClient)
        {

        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var res = base.ListResult();
            res.ForEach(x => comboBox.Properties.Items.Add(x.Title));
            
        }
    }
}
