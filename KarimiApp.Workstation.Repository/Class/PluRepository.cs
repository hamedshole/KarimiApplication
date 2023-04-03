using KarimiApp.Interface.Server;
using KarimiApp.Model;
using KarimiApp.Server.Repository;

namespace KarimiApp.Workstation.Repository.Class
{
    internal class PluRepository : MainRepository<PluModel>, IPlu
    {
        public PluRepository(IPlu repository) : base(repository)
        {
        }
    }
}
