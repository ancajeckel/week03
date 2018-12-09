using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Name { get; set; }

        public Author Author { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string Print()
        {
            return "Book " + this.Name + " by " + this.Author.Name + " (" + this.Year + "), price $" + this.Price;
        }
    }
}
