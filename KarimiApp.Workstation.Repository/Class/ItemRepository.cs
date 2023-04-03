using KarimiApp.Interface.Server;
using KarimiApp.Model;
using KarimiApp.Server.Repository;
using System.Collections.Generic;

namespace KarimiApp.Workstation.Repository.Repository
{
    internal class ItemRepository : MainRepository<ItemModel>,IItem
    {
        IItem repository;
        public ItemRepository(IItem repository) : base(repository)
        {
            this.repository = repository;
        }

        List<ItemModel> IItem.FilterByDepartment(string department)
        {
            return repository.FilterByDepartment(department);
        }

        List<ItemModel> IItem.SearchFilterByDepartment(ItemModel item)
        {
            return repository.SearchFilterByDepartment(item);
        }
    }
}
