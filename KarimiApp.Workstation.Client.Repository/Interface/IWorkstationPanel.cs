using KarimiApp.Model;

namespace KarimiApp.Workstation.Client.Repository.Interface
{
    public interface IWorkstationPanel
    {
        void SendHardKey(WorkstationHardKeyModel workstationHardKey);
        void SendPlu(WorkstationPluModel workstationPlu);
        void SendMessage(WorkStationMessageModel workStationMessage);
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}
