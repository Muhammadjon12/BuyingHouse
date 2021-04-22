using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying_a_house
{
    class House
    {
        private decimal Area  { get; set; }
        private decimal Price { get; set; }

        public House(decimal area, decimal price)
        {
            Area = area;
            Price = price;
        }

        public decimal  final_price(decimal discount)
        {
            return Price-discount;
        }
    }
}
