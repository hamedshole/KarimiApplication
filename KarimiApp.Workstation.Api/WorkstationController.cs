using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using KarimiApp.Workstation.Repository;

namespace KarimiApp.Workstation.Api
{
    public class WorkstationController:ApiController
    {
        UnitOfWork unitOfWork;

        public WorkstationController()
        {
            unitOfWork = new UnitOfWork();
        }

    }
}
