using KarimiApp.Workstation.Client.Repository.Class;
using KarimiApp.Workstation.Client.Repository.Interface;

namespace KarimiApp.Workstation.Client.Repository
{
    public class WorkStationUnitOfWork
    {
        private IWorkstationPanel _workstationPanelRepository;
        public IWorkstationPanel WorkstationPanel
        {
            get
            {
                if (_workstationPanelRepository == null)
                {
                    _workstationPanelRepository = new WorkstationPanelRepository();
                }
                return _workstationPanelRepository;
            }
        }
    }
}
