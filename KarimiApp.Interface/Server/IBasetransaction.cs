using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public  interface IBaseTransaction<TModel>
    {
        List<TModel> Search(TModel model);
        string Insert(TModel model);
        string Delete(TModel model);
    }
}
