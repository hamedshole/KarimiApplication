using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IOrder
    {
        string Insert(OrderTransactionModel order);
        string Pay(OrderTransactionModel order);
        List<OrderTransactionModel> List();
    }
}
