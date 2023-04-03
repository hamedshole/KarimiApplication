using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PaymentTransactionRepository : IPaymentTransaction
    {
        private HttpClientAccess httpClient;
        private string _route = "paymenttransaction";
        public PaymentTransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        void IBaseTransaction<PaymentTransactionModel>.Delete(PaymentTransactionModel model)
        {
            throw new System.NotImplementedException();
        }

        string IBaseTransaction<PaymentTransactionModel>.Insert(PaymentTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<PaymentTransactionModel>(model, _route + "/post")).Result;
            System.Windows.Forms.MessageBox.Show(res);
            return res;
        }

        List<PaymentTransactionModel> IPaymentTransaction.List()
        {
            return this.ListResult();
        }

        private List<PaymentTransactionModel> ListResult()
        {
            return Task.Run(async () => await this.httpClient.Get<List<PaymentTransactionModel>>(_route + "/getall")).Result;
        }

        void IPaymentTransaction.List(GridControl gridControl)
        {
            gridControl.DataSource = this.ListResult();
        }

        void IBaseTransaction<PaymentTransactionModel>.Search(GridControl gridControl, string model)
        {
            gridControl.DataSource = this.SearchResult(model);
        }
        private List<PaymentTransactionModel> SearchResult(string text)
        {
            return Task.Run(async () => await this.httpClient.Post<string, List<PaymentTransactionModel>>(text, _route + "/getall")).Result;
        }
    }
}
