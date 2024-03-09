using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library
{
    public class DeliveryItem
    {
        public DeliveryItem(ParcelCategory category, double price)
        {
            Category = category;
            Price = price;
        }

        public ParcelCategory Category { get; }

        public double Price { get; }
    }
}
