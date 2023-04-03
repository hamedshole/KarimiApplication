using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class OrderTransactionRepository : IOrder
    {
        private HttpClientAccess httpClient;
        private string _route = "ordertransaction";

        public OrderTransactionRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        void IBaseTransaction<OrderTransactionModel>.Delete(OrderTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<OrderTransactionModel>.Insert(OrderTransactionModel model)
        {
            string res = Task.Run(async () => await this.httpClient.PostReturnString<OrderTransactionModel>(model, _route + "/post")).Result;
            System.Windows.Forms.MessageBox.Show(res);
            return res;
        }

     

        void IBaseTransaction<OrderTransactionModel>.Search(GridControl gridControl, string model)
        {
            throw new NotImplementedException();
        }
    }
}
