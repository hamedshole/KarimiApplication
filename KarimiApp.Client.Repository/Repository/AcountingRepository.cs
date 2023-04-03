using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Model;
using KarimiApp.Interface.Client;
namespace KarimiApp.Client.Repository.Repository
{
    internal class AcountingRepository : IAcounting
    {
       private HttpClientAccess httpClient;
        private string _route="acounting/";

        public AcountingRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        void IAcounting.PayoutList(DateTime date, GridControl grid)
        {
            var result = Task.Run(async()=>await this.httpClient.Post<DateTime,List<PayoutTransactionModel>>(date,_route + "PayoutList")).Result;
            grid.DataSource = result;
        }

        private List<PersonCreditHeaderModel> CreditListResult()
        {
            return Task.Run(async () => await this.httpClient.Get<List<PersonCreditHeaderModel>>(_route + "PersonCreditList")).Result;
        }

        void IAcounting.PersonCreditList(GridControl grid)
        {
            var result = this.CreditListResult();
            grid.DataSource = result;
        }
    }
}
