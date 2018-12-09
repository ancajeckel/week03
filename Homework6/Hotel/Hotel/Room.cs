using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Room
    {
        public Room(string name)
        {
            this.Name = name;
            this.Rate = null;
            this.Adults = 0;
            this.Children = 0;
        }

        public string Name { get; set; }

        public Rate Rate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPriceForDays (int numberOfDays)
        {
            return numberOfDays * this.Rate.Amount;
        }

        public string Print()
        {
            return "Room " + this.Name + " for " + this.Adults + "adult(s) and " + this.Children + "child(ren) (" + this.Rate.Print() + ")";
        }

    }
}
