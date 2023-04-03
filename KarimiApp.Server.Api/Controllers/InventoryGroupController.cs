using System;
using System.Web.Http;
using KarimiApp.Model;
using KarimiApp.Server.Repository;

namespace KarimiApp.Server.Api.Controllers
{
    public class InventoryGroupController : ApiController
    {

        private readonly UnitOfWork unitOfWork;
        public InventoryGroupController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(unitOfWork.InventoryGroup.Insert(inventoryGroup));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(unitOfWork.InventoryGroup.Update(inventoryGroup));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(unitOfWork.InventoryGroup.Delete(inventoryGroup));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.InventoryGroup.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string inventoryGroup)
        {
            try
            {
                return Ok(unitOfWork.InventoryGroup.Get(inventoryGroup));
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
                return Ok(unitOfWork.InventoryGroup.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
