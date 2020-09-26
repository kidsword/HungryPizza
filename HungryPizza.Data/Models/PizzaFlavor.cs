using System;
using System.Collections.Generic;

namespace HungryPizza.Data.Models
{
    public partial class PizzaFlavor
    {
        public PizzaFlavor()
        {
            PizzaValue = new HashSet<PizzaValue>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PizzaValue> PizzaValue { get; set; }
    }
}
