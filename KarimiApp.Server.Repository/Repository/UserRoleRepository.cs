using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class UserRoleRepository : MainRepository<UserRoleModel>, IUserRole
    {
        public UserRoleRepository(IUserRole repository) : base(repository)
        {
        }
    }
}
