using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface ITransaction:IBaseTransaction<TransactionModel>
    {
        List<TransactionModel> Read();
        string LastCode();
        long LastValue();
    }
}
