using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class SupplierController:ApiController
    {
        private UnitOfWork unitOfWork;

        public SupplierController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]SupplierAgentModel supplier)
        {
            return Ok(unitOfWork.Supplier.Insert(supplier));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]SupplierAgentModel supplier)
        {
            return Ok(unitOfWork.Supplier.Update(supplier));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]SupplierAgentModel supplier)
        {
            return Ok(unitOfWork.Supplier.Delete(supplier));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string text)
        {
            return Ok(unitOfWork.Supplier.Get(text));
        }
        [HttpPost]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.Supplier.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.Supplier.Search(text));
        }
    }
}
