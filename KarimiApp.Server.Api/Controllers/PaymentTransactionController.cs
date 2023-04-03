using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PaymentTransactionController:ApiController
    {
        UnitOfWork unitOfWork;

        public PaymentTransactionController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult Post ([FromBody]PaymentTransactionModel model)
        {
            return Ok(unitOfWork.PaymentTransaction.Insert(model));
        }
    }
}
