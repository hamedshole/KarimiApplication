using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.Repository.Repository
{
    internal class BaseTransactionRepository<TModel> : IBaseTransaction<TModel> where TModel:class,new()
    {
        private HttpClientAccess httpClient;
        private readonly string _route = "";

        public BaseTransactionRepository(HttpClientAccess httpClient, string route)
        {
            this.httpClient = httpClient;
            _route = route;
        }

        void IBaseTransaction<TModel>.Insert(TModel model)
        {
          string res= Task.Run(async()=>await httpClient.PostReturnString(model, _route + "/post")).Result;
            MessageBox.Show(res);
        }

        List<TModel> IBaseTransaction<TModel>.List()
        {
            throw new NotImplementedException();
        }

        void IBaseTransaction<TModel>.List(GridControl gridControl)
        {
            throw new NotImplementedException();
        }

        void IBaseTransaction<TModel>.Search(GridControl gridControl, TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
