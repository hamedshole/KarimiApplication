using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class TransactionRepository : ITransaction
    {
        private HttpClientAccess httpClient;
        private string _route = "/api/transaction";
        public TransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        void IBaseTransaction<TransactionModel>.Delete(TransactionModel model)
        {
            throw new System.NotImplementedException();
        }

        string  IBaseTransaction<TransactionModel>.Insert(TransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<TransactionModel>(model, _route + "/post")).Result;
            return res;
        }

        string ITransaction.LastCode()
        {
            return Task.Run(async () => await this.httpClient.GetString(_route + "/lastcode")).Result;
        }

        long ITransaction.LastValue()
        {
            return Task.Run(async () => await this.httpClient.Get<long>(_route+"/lastvalue")).Result;
        }

        List<TransactionModel> ITransaction.List()
        {
            throw new System.NotImplementedException();
        }

        void ITransaction.List(GridControl gridControl)
        {
            throw new System.NotImplementedException();
        }

        void IBaseTransaction<TransactionModel>.Search(GridControl gridControl, string model)
        {
            throw new System.NotImplementedException();
        }
    }
}
