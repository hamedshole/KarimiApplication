using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class AuthenticationController:ApiController
    {
        private UnitOfWork unitOfWork;

        public AuthenticationController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult Login([FromBody]UserModel user)
        {
            var res = unitOfWork.Authentication.Login(user);
            return Ok(res);
        }
        [HttpPost]
        public IHttpActionResult GetSettings([FromBody]UserRoleModel userRole)
        {
            return Ok(unitOfWork.Authentication.GetUserSettings(userRole));
        }
    }
}
