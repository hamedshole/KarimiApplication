using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class UserController:ApiController
    {
        private UnitOfWork unitOfWork;

        public UserController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserModel user)
        {
            return Ok(this.unitOfWork.User.Insert(user));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]UserModel user)
        {
            return Ok(this.unitOfWork.User.Update(user));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]UserModel user)
        {
            return Ok(this.unitOfWork.User.Delete(user));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(this.unitOfWork.User.Get(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(this.unitOfWork.User.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(this.unitOfWork.User.Search(text));
        }
    }
}
