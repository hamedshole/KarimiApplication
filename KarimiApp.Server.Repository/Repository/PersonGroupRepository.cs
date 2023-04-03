using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PersonGroupRepository : MainRepository<PersonGroupModel>,IPersonGroup
    {
        public PersonGroupRepository(IPersonGroup repository) : base(repository)
        {
        }
    }
}
