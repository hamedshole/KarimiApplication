using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarimiApp.Model
{
   public class PersonCreditHeaderModel
    {
        public string Name { get; set; }
        public long TotalValue { get; set; }
        public int TotalVisit { get; set; }
        public long Balance { get; set; }
        public List<PersonCreditLogModel> Log { get; set; }
    }
}
