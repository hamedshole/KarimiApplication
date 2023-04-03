using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class InventoryManagementController:ApiController
    {
        UnitOfWork unitOfWork;

        public InventoryManagementController()
        {
            this.unitOfWork = new UnitOfWork();
        }

        [HttpPost]
        public IHttpActionResult AddItem([FromBody]InventoryLogModel item)
        {
            try
            {
                return Ok(this.unitOfWork.InventoryManagement.AddItem(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpPost]
        public IHttpActionResult GetItemLog([FromBody]ItemModel item)
        {
            try
            {
                return Ok(this.unitOfWork.InventoryManagement.GetItemLog(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpPost]
        public IHttpActionResult GetItemStock([FromBody] ItemModel item)
        {
            try
            {
                return Ok(this.unitOfWork.InventoryManagement.GetItemStock(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
