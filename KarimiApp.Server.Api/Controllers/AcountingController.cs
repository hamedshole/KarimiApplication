using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using KarimiApp.Server.Repository;

namespace KarimiApp.Server.Api.Controllers
{
   public class AcountingController:ApiController
    {
        UnitOfWork unitOfWork;

        public AcountingController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpGet]
        public IHttpActionResult PersonCreditList()
        {
            return Ok(this.unitOfWork.Acounting.PersonCreditList());
        }
        public IHttpActionResult PayoutList([FromBody] DateTime date)
        {
            return Ok(this.unitOfWork.Acounting.PayoutList(date));
        }
    }
}
