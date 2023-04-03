using KarimiApp.Model;
using KarimiApp.Workstation.ModelFactory.Interface;
using System.Collections.Generic;

namespace KarimiApp.Workstation.ModelFactory.Class
{
    public class HardKeyConveror : IHardKeyConverter
    {
        List<int> IHardKeyConverter.HardKeyToNet(List<HardwareKeyModel> hardwareKeys)
        {
            List<int> result = new List<int>(70);
            foreach (var item in hardwareKeys)
            {
                result.Add(item.Item.Memory);
            }
            return result;
        }
    }
}
