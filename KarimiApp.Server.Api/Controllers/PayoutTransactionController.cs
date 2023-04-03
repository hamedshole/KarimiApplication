using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
   public class PayoutTransactionController:ApiController
    {
        UnitOfWork unitOfWork;

        public PayoutTransactionController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PayoutTransactionModel model)
        {
            return Ok(unitOfWork.PayoutTransaction.Insert(model));
        }
        [HttpPost]
        public IHttpActionResult GetAll([FromBody] PayoutTransactionModel payoutTransaction)
        {
            var res = unitOfWork.PayoutTransaction.Read(payoutTransaction);
            return Ok(res);
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PayoutTransactionModel payoutTransaction)
        {
            return Ok(unitOfWork.PayoutTransaction.Delete(payoutTransaction));
        }
    }
}
