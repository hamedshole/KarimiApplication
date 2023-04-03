using DevExpress.XtraGrid;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public  interface IBaseTransaction<TModel>
    {
        string Insert(TModel model);
        void Search(GridControl gridControl,string text);
        void Delete(TModel model);
    }
}
