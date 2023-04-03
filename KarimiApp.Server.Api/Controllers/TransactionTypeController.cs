using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class TransactionTypeController:ApiController
    {
        private UnitOfWork unitOfWork;

        public TransactionTypeController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] TransactionTypeModel transactionType)
        {
            return Ok(unitOfWork.TransactionType.Insert(transactionType));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]TransactionTypeModel transactionType)
        {
            return Ok(unitOfWork.TransactionType.Update(transactionType));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]TransactionTypeModel transactionType)
        {
            return Ok(unitOfWork.TransactionType.Delete(transactionType));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(unitOfWork.TransactionType.Get(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.TransactionType.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.TransactionType.Search(text));
        }
    }
}
