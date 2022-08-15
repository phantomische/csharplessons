using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_11._6
{
    public class Consultant
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Patronomic { get; }
        public string PhoneNumber { get; set; }
        public string PassportDetails { get; } = string.Format("******************");
            
     }
}
