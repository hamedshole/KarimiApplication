using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    internal class OrderTransactionRepository : IOrder
    {
        IOrder repository;

        public OrderTransactionRepository(IOrder repository)
        {
            this.repository = repository;
        }

        string IOrder.Insert(OrderTransactionModel order)
        {
            return repository.Insert(order);
        }

        List<OrderTransactionModel> IOrder.List()
        {
            return repository.List();
        }

        string IOrder.Pay(OrderTransactionModel order)
        {
            return repository.Pay(order);
        }
    }
}
