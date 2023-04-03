using System;
using System.Web.Http;
using KarimiApp.Model;
using KarimiApp.Server.Repository;

namespace KarimiApp.Server.Api.Controllers
{
  public  class UserRoleController : ApiController
    {
        private readonly UnitOfWork unitOfWork;
        public UserRoleController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserRoleModel userRole)
        {
            return Ok(unitOfWork.UserRole.Insert(userRole));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]UserRoleModel userRole)
        {
            return Ok(unitOfWork.UserRole.Update(userRole));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]UserRoleModel userRole)
        {
            return Ok(unitOfWork.UserRole.Delete(userRole));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.UserRole.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

        [HttpPost]
        public IHttpActionResult Get([FromBody] string userRole)
        {
            try
            {
                return Ok(unitOfWork.UserRole.Get(userRole));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
