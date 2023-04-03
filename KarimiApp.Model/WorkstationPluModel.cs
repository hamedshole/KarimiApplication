using Newtonsoft.Json;
using System.Collections.Generic;

namespace KarimiApp.Model
{
    public class WorkstationPluModel
    {
        public string Ip { get; set; }
        public List<ItemModel> Items { get; set; }
        public string PlusString { get; set; }

        public WorkstationPluModel()
        {
        }

        public WorkstationPluModel(string ip, List<ItemModel> items)
        {
            Ip = ip;
            this.Items = items;
            PlusString = JsonConvert.SerializeObject(items);
        }
    }
}
