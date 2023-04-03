using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PaymentTypeRepository : MainRepository<PaymentTypeModel>,IPaymentType
    {
        public PaymentTypeRepository(IPaymentType repository) : base(repository)
        {
        }
    }
}
