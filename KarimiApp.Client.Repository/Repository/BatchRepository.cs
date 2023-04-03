using DevExpress.XtraGrid;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.Repository.Repository
{

    internal class BatchRepository : IBatch
    {
        private HttpClientAccess httpClient;
        private string _route = "batch";

        public BatchRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        void IBatch.Delete(BatchModel batch)
        {
            var res = Task.Run(async () => await this.httpClient.PostReturnString<BatchModel>(batch, _route + "/Close")).Result;
            MessageBox.Show(res);
        }

        void IBatch.List(GridControl grid)
        {
            List<BatchModel> batches = new List<BatchModel>();
            batches =  this.ListMethod();
            if (grid != null)
            {
                if (grid.IsHandleCreated)
                {
                    // if (that.InvokeRequired)
                    grid.BeginInvoke((MethodInvoker)delegate
                    {
                        grid.DataSource = batches;
                    });

                    // else
                    // action.Invoke();
                }
                else
                {
                    grid.Tag = batches;
                    grid.HandleCreated += this.Grid_HandleCreated;
                }
            }
        }

        List<BatchModel> IBatch.List()
        {
            return ListMethod();
        }

        private List<BatchModel> ListMethod()
        {
            return Task.Run(async () => await this.httpClient.Get<List<BatchModel>>(_route + "/getall")).Result;
        }
        private void Grid_HandleCreated(object sender, EventArgs e)
        {
            List<BatchModel> batches = (sender as GridControl).Tag as List<BatchModel>;
            (sender as GridControl).BeginInvoke((MethodInvoker)delegate
            {
                (sender as GridControl).DataSource = batches;
            });
        }
    }
}
