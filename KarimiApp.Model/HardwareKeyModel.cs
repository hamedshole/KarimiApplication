using System;

namespace KarimiApp.Model
{
    public class HardwareKeyModel
    {
        public int Id { set; get; }
        public string Workstation { set; get; }
        public int Key { get; set; }
        public int ItemMemory { get; set; }
        public ItemModel Item { set; get; }
        public HardwareKeyModel()
        {

        }
        public HardwareKeyModel(int key, int memory)
        {
            this.Key = 0;
            this.Item = new ItemModel { Memory = memory };
        }
        public HardwareKeyModel(string workstation)
        {
            this.Workstation = workstation;
        }
        public HardwareKeyModel(string workstation, int key, ItemModel item)
        {
            Workstation = workstation;
            this.Key = key;
            this.Item = item;
        }

        public HardwareKeyModel(int id, string workstation, int key, ItemModel item)
        {
            Id = id;
            Workstation = workstation;
            this.Key = key;
            this.Item = item;
        }

        public HardwareKeyModel(int pluid, ItemModel item, string key, string workstation)
        {
            this.Item = item;
            this.Key = Convert.ToInt32(key);
            this.Workstation = workstation;
        }

        public HardwareKeyModel(int id, string workstation, int key)
        {
            Id = id;
            Workstation = workstation;
            Key = key;
        }
    }
}
