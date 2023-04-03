using KarimiApp.Client.Repository.Interface;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.Repository.Repository
{
    public class WorkstationPanelRepository : IWorkstationPanel
    {
        private HttpClientAccess httpClient;
        private string _route = "workstationserver";

        public WorkstationPanelRepository()
        {
            this.httpClient = new HttpClientAccess();
        }

        void IWorkstationPanel.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workstationHardKey, "/sendhardkey")).Result;
            MessageBox.Show(message);
        }

        void IWorkstationPanel.SendMessage(WorkStationMessageModel workStationMessage)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workStationMessage, "/sendmessage")).Result;
            MessageBox.Show(message);
        }

        void IWorkstationPanel.SendPlu(WorkstationPluModel workstationPlu)
        {
            string message = Task.Run(async () => await this.httpClient.PostReturnString(workstationPlu, "/sendplu")).Result;
            MessageBox.Show(message);
        }

        long IWorkstationPanel.TotalReceiptAmount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel, long>(new WorkstationModel { Title=workstation}, "/totalreceiptamount")).Result;

        }

        long IWorkstationPanel.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, long>(receipt, "/totalreceiptamountfordate")).Result;
        }

        int IWorkstationPanel.TotalReceiptCount(string workstation)
        {
            return Task.Run(async () => await this.httpClient.Post<WorkstationModel, int>(new WorkstationModel { Title=workstation}, "/totalreceiptcount")).Result;
        }

        int IWorkstationPanel.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return Task.Run(async () => await this.httpClient.Post<ReceiptModel, int>(receipt, "/totalreceiptcountfordate")).Result;
        }
    }
}
