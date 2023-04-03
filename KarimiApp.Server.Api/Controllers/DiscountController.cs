using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class DiscountController:ApiController
    {
        private UnitOfWork unitOfWork;

        public DiscountController()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public IHttpActionResult Post([FromBody]DiscountModel discount)
        {
            return Ok( this.unitOfWork.Discount.Insert(discount));
        }
        public IHttpActionResult Pu([FromBody]DiscountModel discount)
        {
            return Ok(this.unitOfWork.Discount.Update(discount));
        }
        public IHttpActionResult Delete([FromBody]DiscountModel discount)
        {
            return Ok(this.unitOfWork.Discount.Delete(discount));
        }
        public IHttpActionResult Get([FromBody]string title)
        {
            return Ok( this.unitOfWork.Discount.Get(title));
        }
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.Discount.List());
        }
        public IHttpActionResult Search(string text)
        {
            return Ok(this.unitOfWork.Discount.Search(text));
        }
    }
}
