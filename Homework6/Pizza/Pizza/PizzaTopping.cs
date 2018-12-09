using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaTopping
    {
        public PizzaTopping(string name)
        {
            this.Name = name;
            this.Cost = Cost;
        }
        public string Name { get; set; }

        public double Cost { get; set; }

        public string Print()
        {
            return "\t" + this.Name + " ($" + this.Cost + ")";
        }
    }
}
