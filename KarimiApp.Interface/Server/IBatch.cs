using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IBatch
    {
        string Close(BatchModel model);
        List<BatchModel> Getall();
    }
}
