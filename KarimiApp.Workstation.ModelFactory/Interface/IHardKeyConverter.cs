using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Workstation.ModelFactory.Interface
{
    public interface IHardKeyConverter
    {
        List<int> HardKeyToNet(List<HardwareKeyModel> hardwareKeys);
    }
}
