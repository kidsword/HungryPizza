using System;
using System.Collections.Generic;

namespace HungryPizza.Data.Models
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public bool? Active { get; set; }
        public string Note { get; set; }

        public Customers Customer { get; set; }
    }
}
