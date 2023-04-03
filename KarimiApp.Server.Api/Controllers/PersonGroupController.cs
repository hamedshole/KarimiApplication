using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PersonGroupController : ApiController
    {

        readonly UnitOfWork unitOfWork;
        public PersonGroupController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PersonGroupModel personGroup)
        {
            return Ok(unitOfWork.PersonGroup.Insert(personGroup));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]PersonGroupModel personGroup)
        {
            return Ok(unitOfWork.PersonGroup.Update(personGroup));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PersonGroupModel personGroup)
        {
            return Ok(unitOfWork.PersonGroup.Delete(personGroup));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.PersonGroup.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string personGroup)
        {
            try
            {
                return Ok(unitOfWork.PersonGroup.Get(personGroup));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Search([FromBody] string text)
        {
            try
            {
                return Ok(unitOfWork.PersonGroup.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
