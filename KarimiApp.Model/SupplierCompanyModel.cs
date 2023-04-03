namespace KarimiApp.Model
{
    public class SupplierCompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public SupplierCompanyModel()
        {

        }

        public SupplierCompanyModel(string name, bool active)
        {
            this.Name = name;
            this.Active = active;
        }

        public SupplierCompanyModel(int id, string name, bool active)
        {
            Id = id;
            Name = name;
            Active = active;
        }
    }
}
