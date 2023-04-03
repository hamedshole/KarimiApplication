using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class BatchController:ApiController
    {
        private readonly UnitOfWork unitOfWork;
        public BatchController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult Close([FromBody]BatchModel batch)
        {
            return Ok(unitOfWork.Batch.Close(batch));
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.Batch.Getall());
        }
    }
}
