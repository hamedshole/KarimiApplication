using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class RegisterRepository : MainRepository<RegisterModel>, IRegister
    {
        public RegisterRepository(IRegister repository) : base(repository)
        {
        }
    }
}
