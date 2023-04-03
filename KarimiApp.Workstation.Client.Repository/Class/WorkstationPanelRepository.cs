using KarimiApp.Model;
using KarimiApp.Workstation.Client.Repository.Interface;
using KarimiApp.Workstation.Client.Repository.Util;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Workstation.Client.Repository.Class
{
    public class WorkstationPanelRepository : IWorkstationPanel
    {
        private HttpClientAccess httpClient;
        private string _route = "WorkstationServer";

        public WorkstationPanelRepository()
        {
            this.httpClient = new HttpClientAccess();
        }

        void IWorkstationPanel.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
           string message=Task.Run(async()=>await this.httpClient.PostReturnString(workstationHardKey,_route+ "/SendHardKey")).Result;
            MessageBox.Show(message);
        }

        void IWorkstationPanel.SendMessage(WorkStationMessageModel workStationMessage)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workStationMessage,_route+ "/SendMessage")).Result;
            MessageBox.Show(message);
        }

        void IWorkstationPanel.SendPlu(WorkstationPluModel workstationPlu)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workstationPlu,_route+ "/SendPlu")).Result;
            MessageBox.Show(message);
        }

        long IWorkstationPanel.TotalReceiptAmount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel,long>(new WorkstationModel { Title = workstation },_route+ "/TotalReceiptAmount")).Result;

        }

        long IWorkstationPanel.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, long>(receipt,_route+ "/TotalReceiptAmountForDate")).Result;
        }

        int IWorkstationPanel.TotalReceiptCount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel, int>(new WorkstationModel { Title=workstation},_route+ "/TotalReceiptCount")).Result;
        }

        int IWorkstationPanel.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, int>(receipt,_route+ "/TotalReceiptCountForDate")).Result;
        }
    }
}
