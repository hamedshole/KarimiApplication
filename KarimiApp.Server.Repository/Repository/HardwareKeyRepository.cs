using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    internal class HardwareKeyRepository : IHardwareKey
    {
       private readonly IHardwareKey repository;

        public HardwareKeyRepository(IHardwareKey repository)
        {
          
            this.repository = repository;
        }

        public ItemModel ItemGetByMemory(int memory)
        {
            return repository.ItemGetByMemory(memory);
        }

        string IHardwareKey.Delete(HardwareKeyModel model)
        {
            return repository.Delete(model);
        }

        string IHardwareKey.Insert(HardwareKeyModel model)
        {
            var res = repository.Insert(model);
            return res;
        }

        List<HardwareKeyModel> IHardwareKey.List(HardwareKeyModel model)
        {
            var res = repository.List(model);
            res.ForEach(x => x.Item = repository.ItemGetByMemory(x.ItemMemory));
            return res;
        }
    }
}
