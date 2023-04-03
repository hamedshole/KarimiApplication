using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class WorkstationRepository : MainRepository<WorkstationModel>, IWorkstation
    {
        IWorkstation workstationrepository;
        public WorkstationRepository(IWorkstation repository) : base(repository)
        {
            workstationrepository = repository;
        }
        long IWorkstation.TotalReceiptAmount(string workstation)
        {
            return workstationrepository.TotalReceiptAmount(workstation);
        }

        long IWorkstation.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return workstationrepository.TotalReceiptAmountForDate(receipt);
        }

        int IWorkstation.TotalReceiptCount(string workstation)
        {
            return workstationrepository.TotalReceiptCount(workstation);
        }

        int IWorkstation.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return workstationrepository.TotalReceiptCountForDate(receipt);
        }
    }
}
