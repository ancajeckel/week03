using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaBase
    {
        public PizzaBase(string name)
        {
            if (name != "Regular" && name != "Thick" && name != "Italian")
            {
                throw new Exception("Base can be: Regular / Thick / Italian");
            }
            this.Name = name;
            double BaseCost = 7;
            if (name == "Italian")
            {
                this.Cost = 1.5 * BaseCost;
            }
            else
            {
                this.Cost = BaseCost;
            }
        }
        public string Name { get; set; }

        public double Cost { get; }

        public string Print ()
        {
            return this.Name + " ($" + this.Cost + ")";
        }
    }
}
