using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimiApp.Model;
using KarimiApp.Interface.Client;
using KarimiApp.Client.Repository.Util;
using DevExpress.XtraEditors;

namespace KarimiApp.Client.Repository.Repository
{
    internal class RegisterRepository : MainRepository<RegisterModel>, IRegister
    {
        public RegisterRepository( HttpClientAccess httpClient) : base("register", httpClient)
        {
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var result = this.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Title));
        }
    }
}
