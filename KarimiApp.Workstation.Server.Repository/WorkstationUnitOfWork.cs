using KarimiApp.Workstation.Server.Repository.Class;
using KarimiApp.Workstation.Server.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArvinWorkstation = Arvin.Net.Workstation;

namespace KarimiApp.Workstation.Server.Repository
{
   public class WorkstationUnitOfWork
    {
        IWorkstation _workstationserverRepository;
        private List<ArvinWorkstation> loadedlist;

        public WorkstationUnitOfWork(List<ArvinWorkstation> loadedlist)
        {
            this.loadedlist = loadedlist;
        }

        public IWorkstation Workstation
        {
            get
            {
                if (_workstationserverRepository == null)
                {
                    _workstationserverRepository = new WorkstationRepository(loadedlist);
                }
                return _workstationserverRepository;
            }
        }
    }
}
