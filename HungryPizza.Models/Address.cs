using System;
using System.Collections.Generic;
using System.Text;

namespace HungryPizza.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
    }
}
