using Arvin.Model;
using KarimiApp.Model;
using System.Collections.Generic;
using WorkStation = Arvin.Net.Workstation;


namespace KarimiApp.Workstation.ModelFactory.Interface
{
    public interface IPluConverter
    {
        List<PluModel> ToDb(List<netPLU> netPLUs, WorkStation workStation);
        List<netPLU> ItemToArvinPlu(List<ItemModel> items);
    }
}
