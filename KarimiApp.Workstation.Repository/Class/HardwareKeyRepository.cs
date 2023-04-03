using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Workstation.Repository.Class
{
    internal class HardwareKeyRepository : IHardwareKey
    {
       private readonly IHardwareKey repository;

        public HardwareKeyRepository(IHardwareKey repository)
        {
          
            this.repository = repository;
        }

        string IHardwareKey.Insert(HardwareKeyModel model)
        {
            var res = repository.Insert(model);
            return res;
        }

        List<HardwareKeyModel> IHardwareKey.List(HardwareKeyModel model)
        {
            var res = repository.List(model);
            return res;
        }
    }
}
