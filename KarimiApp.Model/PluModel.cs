namespace KarimiApp.Model
{
    public class PluModel
    {

        public int Id { get; set; }
        public int Memory { get; set; }
      
        public string Workstation { get; set; }
        public ItemModel Item { get; set; }
        public PluModel()
        {

        }

        public void SetMemory(int memory)
        {
            this.Memory = memory;
        }


        public PluModel(ItemModel item, string workstation, int id = 0, int memory = 0)
        {
            this.Id = id;
            this.Memory = memory;
            Item = item;
            Workstation = workstation;
        }

        public PluModel(string workstation)
        {
            Workstation = workstation;
        }

        public PluModel(int memory)
        {
            this.Memory = memory;
        }
    }
}
