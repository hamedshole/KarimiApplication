using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PaymentMethodController:ApiController
    {
        UnitOfWork unitOfWork;

        public PaymentMethodController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this.unitOfWork.PaymentMethod.Insert(paymentMethod));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this.unitOfWork.PaymentMethod.Update(paymentMethod));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this.unitOfWork.PaymentMethod.Delete(paymentMethod));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(this.unitOfWork.PaymentMethod.Get(text));
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(this.unitOfWork.PaymentMethod.Search(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.PaymentMethod.List());
        }
    }
}
