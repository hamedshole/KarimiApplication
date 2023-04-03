using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PluRepository : MainRepository<PluModel>, IPlu
    {
        public PluRepository(IPlu repository) : base(repository)
        {
        }
    }
}
