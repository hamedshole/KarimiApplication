using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class SupplierCompanyController:ApiController
    {
        private UnitOfWork unitOfWork;

        public SupplierCompanyController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok( this.unitOfWork.SupplierCompany.Insert(supplierCompany));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok(this.unitOfWork.SupplierCompany.Update(supplierCompany));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok(this.unitOfWork.SupplierCompany.Delete(supplierCompany));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(this.unitOfWork.SupplierCompany.Get(text));
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(this.unitOfWork.SupplierCompany.Search(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.SupplierCompany.List());
        }
    }
}
