using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PosInfoRepository : MainRepository<PosInfoModel>, IPosInfo
    {
        public PosInfoRepository(IPosInfo repository) : base(repository)
        {
        }
    }
}
