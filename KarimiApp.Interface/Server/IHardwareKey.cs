using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimiApp.Model;

namespace KarimiApp.Interface.Server
{
    public interface IHardwareKey

    {
        ItemModel ItemGetByMemory(int memory);
        string Insert(HardwareKeyModel model);
        List<HardwareKeyModel> List(HardwareKeyModel model);
        string Delete(HardwareKeyModel model);
    }
}
