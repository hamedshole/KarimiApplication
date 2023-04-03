using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class TransactionTypeRepository : MainRepository<TransactionTypeModel>, ITransactionType
    {
        public TransactionTypeRepository(HttpClientAccess httpClient) : base("transactiontype", httpClient)
        {
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var result = this.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Title));
        }
    }
}
