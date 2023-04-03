using KarimiApp.DataAccess;
using KarimiApp.Interface.Server;
using KarimiApp.Workstation.Repository.Class;

namespace KarimiApp.Workstation.Repository
{
    public class UnitOfWork
    {
        private DbAccess dbAccess;
        private IWorkstationData _workstationData;
        public IWorkstationData WorkstationData
        {
            get
            {
                if (_workstationData == null)
                {
                    _workstationData = new WorkstationDataRepository(dbAccess);
                }
                return _workstationData;
            }
        }
    }
}
