using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    public class DiscountRepository : MainRepository<DiscountModel>, IDiscount
    {
        public DiscountRepository(IDiscount repository) : base(repository)
        {
        }
    }
}
