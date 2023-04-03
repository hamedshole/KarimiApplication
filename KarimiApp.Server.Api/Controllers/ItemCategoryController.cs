using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System;
using System.Web.Http;

namespace KarimiApp.Server.Api.Controllers
{
    public class ItemCategoryController : ApiController
    {
        readonly UnitOfWork unitOfWork;
        public ItemCategoryController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(unitOfWork.ItemCategory.Insert(itemCategory));
        }
        [HttpPost]
        public IHttpActionResult Put([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(unitOfWork.ItemCategory.Update(itemCategory));
        }
        [HttpPost]
        public IHttpActionResult Delete([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(unitOfWork.ItemCategory.Delete(itemCategory));
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(unitOfWork.ItemCategory.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost]
        public IHttpActionResult Get([FromBody] string itemCategory)
        {
            try
            {
                return Ok(unitOfWork.ItemCategory.Get(itemCategory));
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
                return Ok(unitOfWork.ItemCategory.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
    }
}
