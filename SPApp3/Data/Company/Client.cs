using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPApp3.Data.Company
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
    }
}
