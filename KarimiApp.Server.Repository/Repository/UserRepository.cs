using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class UserRepository : MainRepository<UserModel>, IUser
    {
        public UserRepository(IUser repository) : base(repository)
        {
        }
    }
}
