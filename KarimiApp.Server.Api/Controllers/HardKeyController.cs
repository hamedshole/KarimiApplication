using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class HardKeyController:ApiController
    {
        private readonly UnitOfWork unitOfWork;
        public HardKeyController()
        {
            unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] HardwareKeyModel hardwareKey)
        {
            return Ok(this.unitOfWork.HardWarekey.Insert(hardwareKey));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] HardwareKeyModel hardwareKey)
        {
            return Ok(this.unitOfWork.HardWarekey.List(hardwareKey));
        }
    }
}
