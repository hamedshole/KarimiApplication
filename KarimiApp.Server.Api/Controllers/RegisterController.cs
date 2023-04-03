using KarimiApp.Interface.Client;
using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class RegisterController:ApiController
    {
        UnitOfWork unitOfWork;

        public RegisterController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]RegisterModel register)
        {
            return Ok(unitOfWork.Register.Insert(register));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody] RegisterModel register)
        {
            return Ok(unitOfWork.Register.Update(register));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]RegisterModel register)
        {
            return Ok(unitOfWork.Register.Delete(register));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(unitOfWork.Register.Get(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.Register.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.Register.Search(text));
        }
        
    }
}
