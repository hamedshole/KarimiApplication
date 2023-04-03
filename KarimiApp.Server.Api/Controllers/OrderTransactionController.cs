using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class OrderTransactionController:ApiController
    {
        UnitOfWork unitOfWork;

        public OrderTransactionController()
        {
            this.unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]OrderTransactionModel order)
        {
            return Ok(this.unitOfWork.Order.Insert(order));
        }
        [HttpPost]
        public IHttpActionResult Pay([FromBody]OrderTransactionModel order)
        {
            return Ok(this.unitOfWork.Order.Pay(order));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.Order.List());
        }
    }
}
