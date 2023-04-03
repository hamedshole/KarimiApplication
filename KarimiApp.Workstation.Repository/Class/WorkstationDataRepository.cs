using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Workstation.Repository.Class
{
    internal class WorkstationDataRepository : IWorkstationData
    {
        private IWorkstationData workstationrepository;

        public WorkstationDataRepository(IWorkstationData workstationrepository)
        {
            this.workstationrepository = workstationrepository;
        }

        long IWorkstationData.TotalReceiptAmount(string workstation)
        {
           return workstationrepository.TotalReceiptAmount(workstation);
        }

        long IWorkstationData.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return workstationrepository.TotalReceiptAmountForDate(receipt);
        }

        int IWorkstationData.TotalReceiptCount(string workstation)
        {
            return workstationrepository.TotalReceiptCount(workstation);
        }

        int IWorkstationData.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return workstationrepository.TotalReceiptCountForDate(receipt);
        }
    }
}
