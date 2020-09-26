using System;
using System.Collections.Generic;

namespace HungryPizza.Data.Models
{
    public partial class PizzaValue
    {
        public Guid Id { get; set; }
        public Guid PizzaFlavourId { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
        public string Note { get; set; }

        public PizzaFlavor PizzaFlavour { get; set; }
    }
}
