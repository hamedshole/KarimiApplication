using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IPaymentTransaction : IBaseTransaction<PaymentTransactionModel>
    {
        List<PaymentTransactionModel> Read();
    }
}
