using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class UserRepository : MainRepository<UserModel>,IUser
    {
        public UserRepository(HttpClientAccess httpClient) : base("user",httpClient)
        {
        }

        public override void List(ComboBoxEdit comboBox,string text)
        {
            base.ListResult().ForEach(x => comboBox.Properties.Items.Add(x.Name));
        }

    }
}
