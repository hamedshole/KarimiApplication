using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PersonController:ApiController
    {
        UnitOfWork unitOfWork;

        public PersonController()
        {
            this.unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Insert(person));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Update(person));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Delete(person));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(unitOfWork.Person.Get(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.Person.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.Person.Search(text));
        }
        [HttpPost]
        public IHttpActionResult Settle([FromBody] PersonModel person)
        {
            return Ok(unitOfWork.Person.Settle(person));
        }
    }
}
