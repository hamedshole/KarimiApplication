using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class PayoutTransactionRepository :  IPayoutTransaction
    {
        private HttpClientAccess httpClient;
        private string _route = "payouttransaction";
        public PayoutTransactionRepository(HttpClientAccess httpClient) 
        {
            this.httpClient = httpClient;
        }

        string IBaseTransaction<PayoutTransactionModel>.Insert(PayoutTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<PayoutTransactionModel>(model, _route + "/post")).Result;
            System.Windows.Forms.MessageBox.Show(res);
            return res;
        }

        List<PayoutTransactionModel> IPayoutTransaction.List(PayoutTransactionModel payoutTransaction)
        {
            return ListResult(payoutTransaction);
        }

        private List<PayoutTransactionModel> ListResult(PayoutTransactionModel payoutTransaction)
        {
            return Task.Run(async () => await this.httpClient.Post<PayoutTransactionModel,List<PayoutTransactionModel>>(payoutTransaction,_route + "/getall")).Result;
        }

        void IPayoutTransaction.List(GridControl gridControl,PayoutTransactionModel payoutTransaction)
        {
            gridControl.DataSource = this.ListResult(payoutTransaction);
        }

        void IBaseTransaction<PayoutTransactionModel>.Search(GridControl gridControl, string model)
        {
            gridControl.DataSource = this.SearchResult(model);
        }
        private List<PayoutTransactionModel> SearchResult(string text)
        {
            return Task.Run(async () => await this.httpClient.Post<string,List<PayoutTransactionModel>>(text,_route + "/getall")).Result;
        }

        void IBaseTransaction<PayoutTransactionModel>.Delete(PayoutTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString(model, _route + "/delete")).Result;
            System.Windows.Forms.MessageBox.Show(res);
        }
    }
}
