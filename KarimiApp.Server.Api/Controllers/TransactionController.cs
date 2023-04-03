using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class TransactionController:ApiController
    {
        UnitOfWork unitOfWork;

        public TransactionController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpGet]
        public IHttpActionResult LastCode()
        {
            return Ok(this.unitOfWork.Transaction.LastCode());
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]TransactionModel model)
        {
            return Ok(unitOfWork.Transaction.Insert(model));
        }

        [HttpGet]
        public IHttpActionResult LastValue()
        {
            return Ok(unitOfWork.Transaction.LastValue());
        }

    }
}
