using KarimiApp.Model;
using KarimiApp.Workstation.ModelFactory.Interface;
using System;
using WorkStation = Arvin.Net.Workstation;

namespace KarimiApp.Workstation.ModelFactory.Class
{

    internal class WorkStationConvertor : IWorkStationConverter
    {
        WorkStation IWorkStationConverter.Start(WorkstationModel workStation)
        {
            WorkStation result = new WorkStation();
            result.Start(workStation.IpAddress, Convert.ToInt32(workStation.PortNumber));
            return result;
        }
    }
}
