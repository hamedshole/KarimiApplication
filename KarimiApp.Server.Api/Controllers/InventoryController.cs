using System;
using KarimiApp.Model;
using System.Web.Http;
using KarimiApp.Server.Repository;

namespace KarimiApp.Server.Api.Controllers
{
    public class InventoryController : ApiController
    {

        private readonly UnitOfWork unitOfWork;
        public InventoryController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]InventoryModel inventory)
        {
            return Ok(unitOfWork.Inventory.Insert(inventory));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]InventoryModel inventory)
        {
            return Ok(unitOfWork.Inventory.Update(inventory));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]InventoryModel inventory)
        {
            return Ok(unitOfWork.Inventory.Delete(inventory));
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.Inventory.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string text)
        {
            try
            {
                return Ok(unitOfWork.Inventory.Get(text));
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
                return Ok(unitOfWork.Inventory.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
