using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IBatch
    {
        void Delete(BatchModel batch);
        void List(GridControl grid);
        List<BatchModel> List();
    }
}
