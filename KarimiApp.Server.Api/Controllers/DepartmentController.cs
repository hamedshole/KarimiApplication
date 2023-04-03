using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class DepartmentController : ApiController
    {

       private readonly UnitOfWork unitOfWork;
        public DepartmentController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]DepartmentModel department)
        {
            return Ok(unitOfWork.Department.Insert(department));
        }

        [HttpPost]
        public IHttpActionResult Put([FromBody]DepartmentModel department)
        {
            return Ok(unitOfWork.Department.Update(department));
        }

        [HttpPost]
        public IHttpActionResult Delete([FromBody]DepartmentModel department    )
        {
            return Ok(unitOfWork.Department.Delete(department));
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.Department.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string department)
        {
            try
            {
                return Ok(unitOfWork.Department.Get(department));
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
                return Ok(unitOfWork.Department.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
    }

}
