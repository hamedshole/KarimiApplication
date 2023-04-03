using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class WorkstationController:ApiController
    {
        private UnitOfWork unitOfWork;

        public WorkstationController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] WorkstationModel workstation)
        {
            return Ok(this.unitOfWork.Workstation.Insert(workstation));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody] WorkstationModel workstation)
        {
            return Ok(this.unitOfWork.Workstation.Update(workstation));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody] WorkstationModel workstation)
        {
            return Ok(this.unitOfWork.Workstation.Delete(workstation));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string workstation)
        {
            return Ok(this.unitOfWork.Workstation.Get(workstation));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.Workstation.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(this.unitOfWork.Workstation.Search(text));
        }
        [HttpPost]
        public IHttpActionResult TotalReceiptAmount([FromBody]string workstation)
        {
            return Ok(this.unitOfWork.Workstation.TotalReceiptAmount(workstation));
        }
        [HttpPost]
        public IHttpActionResult TotalReceiptAmountForDate([FromBody] ReceiptModel receipt)
        {
            return Ok(this.unitOfWork.Workstation.TotalReceiptAmountForDate(receipt));
        }
        [HttpPost]
        public IHttpActionResult TotalReceiptCount([FromBody]string workstation)
        {
            return Ok(this.unitOfWork.Workstation.TotalReceiptCount(workstation));
        }
        [HttpPost]
        public IHttpActionResult TotalReceiptCountForDate([FromBody]ReceiptModel receipt)
        {
            return Ok(this.unitOfWork.Workstation.TotalReceiptCountForDate(receipt));
        }

    }
}
