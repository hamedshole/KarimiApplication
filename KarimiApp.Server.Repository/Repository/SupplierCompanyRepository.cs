using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class SupplierCompanyRepository : MainRepository<SupplierCompanyModel>, ISupplierCompany
    {
        public SupplierCompanyRepository(ISupplierCompany repository) : base(repository)
        {
        }
    }
}
