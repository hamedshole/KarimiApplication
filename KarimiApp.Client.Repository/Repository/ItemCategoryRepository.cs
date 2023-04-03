using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class ItemCategoryRepository : MainRepository<ItemCategoryModel>,IItemCategory
    {
        public ItemCategoryRepository(HttpClientAccess httpClient) : base("itemcategory",httpClient)
        {
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
           var result= base.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Title));
        }
    }
}
