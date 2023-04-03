using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class PosInfoController:ApiController
    {
        UnitOfWork unitOfWork;

        public PosInfoController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]PosInfoModel posInfo)
        {
            return Ok(unitOfWork.PosInfo.Insert(posInfo));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]PosInfoModel posInfo)
        {
            return Ok(unitOfWork.PosInfo.Update(posInfo));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PosInfoModel posInfo)
        {
            return Ok(unitOfWork.PosInfo.Delete(posInfo));
        }
        [HttpPost]
        public IHttpActionResult Get([FromBody]string text)
        {
            return Ok(unitOfWork.PosInfo.Get(text));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(unitOfWork.PosInfo.List());
        }
        [HttpPost]
        public IHttpActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.PosInfo.Search(text));
        }
    }
}
