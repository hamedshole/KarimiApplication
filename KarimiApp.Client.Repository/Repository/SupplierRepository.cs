using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class SupplierRepository : MainRepository<SupplierAgentModel>, ISupplier
    {
        public SupplierRepository(HttpClientAccess httpClient) : base("supplier", httpClient)
        {
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var result = this.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Name));
        }
    }
}
