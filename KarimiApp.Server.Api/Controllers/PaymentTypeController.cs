using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PaymentTypeController:ApiController
    {
      private  UnitOfWork unitOfWork;

        public PaymentTypeController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this.unitOfWork.PaymentType.Insert(paymentType));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this.unitOfWork.PaymentType.Update(paymentType));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this.unitOfWork.PaymentType.Delete(paymentType));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(this.unitOfWork.PaymentType.Get(text));
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(this.unitOfWork.PaymentType.Search(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.PaymentType.List());
        }
    }
}
