using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.Repository.Repository
{
    internal class HardwareKeyRepository : IHardwareKey
    {
        private HttpClientAccess httpClientAccess;
        private readonly string _route = "hardkey";

        public HardwareKeyRepository(HttpClientAccess httpClientAccess)
        {
            this.httpClientAccess = httpClientAccess;
        }

        void IHardwareKey.Create(HardwareKeyModel model)
        {
            var res =Task.Run(async()=>await httpClientAccess.PostReturnString<HardwareKeyModel>(model, _route + "/post")).Result;
            MessageBox.Show(res);
        }

        void IHardwareKey.Delete(HardwareKeyModel model)
        {
            var res = Task.Run(async () => await httpClientAccess.PostReturnString<HardwareKeyModel>(model, _route + "/delete")).Result;
            MessageBox.Show(res);
        }

        List<HardwareKeyModel> IHardwareKey.List(HardwareKeyModel model)
        {
            return ListMethod(model);
        }

        private List<HardwareKeyModel> ListMethod(HardwareKeyModel model)
        {
            return Task.Run(async () => await httpClientAccess.Post<HardwareKeyModel, List<HardwareKeyModel>>(model, _route + "/get")).Result;
        }
        private List<HardwareKeyModel> SearchMethod(HardwareKeyModel model)
        {
            return Task.Run(async () => await httpClientAccess.Post<HardwareKeyModel, List<HardwareKeyModel>>(model, _route + "/search")).Result;
        }
        void IHardwareKey.List(HardwareKeyModel model, GridControl grid)
        {
            grid.DataSource = this.ListMethod(model);
        }

        List<HardwareKeyModel> IHardwareKey.Search(HardwareKeyModel model)
        {
           return this.SearchMethod(model);
        }

        void IHardwareKey.Search(HardwareKeyModel model, GridControl grid)
        {
            grid.DataSource = this.SearchMethod(model);
        }

        void IHardwareKey.Update(HardwareKeyModel model)
        {
            var res = Task.Run(async () => await httpClientAccess.PostReturnString<HardwareKeyModel>(model, _route + "/put")).Result;
            MessageBox.Show(res);
        }
    }
}
