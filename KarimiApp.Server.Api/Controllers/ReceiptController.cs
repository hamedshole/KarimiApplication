using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class ReceiptController:ApiController
    {
        UnitOfWork unitOfWork;

        public ReceiptController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]ReceiptModel receipt)
        {
            return Ok(unitOfWork.Receipt.Insert(receipt));
        }
        [HttpPost]
        public HttpResponseMessage Get([FromBody]string barcode)
        {
            try
            {
                return Request.CreateResponse(statusCode:HttpStatusCode.OK, unitOfWork.Receipt.Get(barcode));
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse<string>(HttpStatusCode.NotFound, e.Message);
            }
           
        }
        [HttpPost]
        public IHttpActionResult List([FromBody]WorkstationReceiptFilterModel workstationReceiptFilter)
        {
            return Ok(unitOfWork.Receipt.List(workstationReceiptFilter));
        }
        [HttpGet]
        public IHttpActionResult CashierList()
        {
            return Ok(unitOfWork.Receipt.CashierList());
        }
        [HttpPost]
        public IHttpActionResult GetTransaction([FromBody]TransactionModel transaction)
        {
            return Ok(this.unitOfWork.Receipt.GetTransaction(transaction.Id));
        }
    }
}
