using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class ItemController : ApiController
    {

        private readonly UnitOfWork unitOfWork;
        public ItemController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]ItemModel item)
        {
            return Ok(unitOfWork.Item.Insert(item));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]ItemModel item)
        {
            return Ok(unitOfWork.Item.Update(item));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]ItemModel item)
        {
            return Ok(unitOfWork.Item.Delete(item));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            //try
            //{
            return Ok(unitOfWork.Item.List());
            //}
            //catch (Exception e)
            //{

            //    return Ok(e.Message + e.StackTrace);
            //}

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string item)
        {
            try
            {
                return Ok(unitOfWork.Item.Get(item));
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
                return Ok(unitOfWork.Item.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

        [HttpPost]
        public IHttpActionResult FilterByDepartment([FromBody] string item)
        {
            try
            {
                return Ok(unitOfWork.Item.FilterByDepartment(item));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }
        }
        [HttpPost]
        public IHttpActionResult SearchFilterByDepartment([FromBody] ItemModel item)
        {
            try
            {
                return Ok(unitOfWork.Item.SearchFilterByDepartment(item));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }
        }

        [HttpPost]
        public IHttpActionResult GetByBarcode([FromBody] string barcode)
        {
            try
            {
                return Ok(unitOfWork.Item.GetByBarcode(barcode));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
