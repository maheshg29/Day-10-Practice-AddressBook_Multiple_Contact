using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Practice_AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public object Firstname { get; internal set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
