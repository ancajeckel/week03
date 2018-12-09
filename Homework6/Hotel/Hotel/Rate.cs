using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Rate
    {
        public int Amount { get; set; }

        public string Currency { get; set; }

        public string Print()
        {
            return this.Amount + this.Currency;
        }
    }
}
