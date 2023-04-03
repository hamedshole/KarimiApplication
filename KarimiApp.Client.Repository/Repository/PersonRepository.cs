using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PersonRepository : MainRepository<PersonModel>,IPerson
    {
      private  HttpClientAccess httpClient;
        private string _route = "person";
        public PersonRepository(HttpClientAccess httpClient) : base("person",httpClient)
        {
            this.httpClient = httpClient;
        }

        public override void List(ComboBoxEdit comboBox, string text)
        {
            var result = this.ListResult();
            result.ForEach(x => comboBox.Properties.Items.Add(x.Name));
        }

        void IPerson.Settle(PersonModel person)
        {
            string result = Task.Run(async () => await this.httpClient.PostReturnString(person, _route + "/settle")).Result;
            MessageBox.Show(result);
        }
    }
}
