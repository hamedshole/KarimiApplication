using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class ItemCategoryRepository : MainRepository<ItemCategoryModel>,IItemCategory
    {
        public ItemCategoryRepository(IItemCategory repository) : base(repository)
        {
        }
    }
}
