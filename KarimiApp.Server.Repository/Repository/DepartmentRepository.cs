using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class DepartmentRepository : MainRepository<DepartmentModel>,IDepartment
    {
        public DepartmentRepository(IDepartment repository) : base(repository)
        {
           
        }
    }
}
