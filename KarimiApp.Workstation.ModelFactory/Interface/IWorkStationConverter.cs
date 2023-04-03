using KarimiApp.Model;
using WorkStation = Arvin.Net.Workstation;

namespace KarimiApp.Workstation.ModelFactory.Interface
{
    public interface IWorkStationConverter
    {
        WorkStation Start(WorkstationModel workStation);
    }
}
