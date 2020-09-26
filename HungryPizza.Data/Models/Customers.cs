using System;
using System.Collections.Generic;

namespace HungryPizza.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Address = new HashSet<Address>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime InitDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public ICollection<Address> Address { get; set; }
    }
}
