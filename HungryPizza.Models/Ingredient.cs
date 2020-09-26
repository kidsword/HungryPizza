using System;
using System.Collections.Generic;
using System.Text;

namespace HungryPizza.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MeasurementUnit { get; set; }
    }
}
