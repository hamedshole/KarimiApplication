using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PaymentMethodRepository :  MainRepository<PaymentMethodModel>,IPaymentMethod
    {
        public PaymentMethodRepository(IPaymentMethod repository) : base(repository)
        {
        }
    }
}
