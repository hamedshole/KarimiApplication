namespace KarimiApp.Model
{
    public class PersonModel
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string PersonGroup { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public long Balance { get; set; }
        public long TotalSales { get; set; }
        public int TotalVisits { get; set; }
        public PersonModel()
        {

        }

        /// <summary>
        /// constructor to create new person
        /// </summary>
        /// <param name="personGroup"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="email"></param>
        public PersonModel(string name, string mobileNumber,string address, string personGroup = "")
        {

            this.Address = address;
            PersonGroup = personGroup;
            this.Name = name;
            MobileNumber = mobileNumber;
            Address = address;
        }

        /// <summary>
        /// constructor to update person
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personGroup"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="email"></param>
        public PersonModel(int id, string name,  string mobileNumber,string address,string personGroup= "")
        {
            this.Address = address;
            Id = id;
            PersonGroup = personGroup;
            MobileNumber = mobileNumber;
            this.Name = name;
        }

        /// <summary>
        /// constructor to read all datas from database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <param name="personGroup"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="birthday"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="email"></param>
        public PersonModel( int id, string code,string name, string mobileNumber,string address,long balance, string personGroup = "")
        {
            this.Name = name;
            this.Address = address;
            this.Balance = balance;
            Id = id;
            Code = code;
            PersonGroup = personGroup;
            MobileNumber = mobileNumber;
        }
        public PersonModel( int id, string code, string name,string mobileNumber,string address, string personGroup = "")
        {
            this.Address = address;
            Id = id;
            Code = code;
            PersonGroup = personGroup;
            this.Name = name;
            MobileNumber = mobileNumber;
        }

        public PersonModel(long balance, int id, string code, long totalsales, int totalvisits, string personGroup, string name,string mobileNumber,string address)
        {
            Balance = balance;
            Id = id;
            Code = code;
            TotalSales = totalsales;
            TotalVisits = totalvisits;
            PersonGroup = personGroup;
            MobileNumber = mobileNumber;
            Address = address;
            this.Name = name;
        }
    }
}
