using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{

    internal class ReceiptRepository : IReceipt
    {
        private HttpClientAccess httpClient;
        private string _route = "receipt";

        public ReceiptRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        ReceiptModel IReceipt.Get(string barcode)
        {
            try
            {
                ReceiptModel result = Task.Run(async () => await this.httpClient.Post<string, ReceiptModel>(barcode, _route + "/get")).Result;
                return result;
            }
            catch (System.Exception e)
            {

                throw e.InnerException;
            }
           
        }

        string IReceipt.Insert(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.PostReturnString(receipt, _route + "/post")).Result;
        }

        void IReceipt.List(WorkstationReceiptFilterModel workstationReceiptFilter, GridControl grid)
        {
            var result = this.ListResult(workstationReceiptFilter);
            grid.DataSource = result;
            
        }

        void IReceipt.List(GridControl grid)
        {
            var result = this.CashierListResult();
            grid.DataSource = result;

        }

        private List<ReceiptModel> CashierListResult()
        {
            return Task.Run(async () => await this.httpClient.Get<List<ReceiptModel>>( _route + "/CashierList").ConfigureAwait(false)).Result;
        }

        private List<ReceiptModel> ListResult(WorkstationReceiptFilterModel workstationReceiptFilter)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationReceiptFilterModel,List<ReceiptModel>>(workstationReceiptFilter,_route + "/list").ConfigureAwait(false)).Result;
        }

        TransactionModel IReceipt.GetTransaction(int id)
        {
            return Task.Run(async () => await this.httpClient.Post<TransactionModel, TransactionModel>(new TransactionModel { Id=id}, _route + "/GetTransaction").ConfigureAwait(false)).Result;
        }
    }
}
