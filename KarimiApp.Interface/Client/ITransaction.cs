using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface ITransaction:IBaseTransaction<TransactionModel>
    {
        List<TransactionModel> List();
        void List(GridControl gridControl);
        string LastCode();
        long LastValue();
    }
}
