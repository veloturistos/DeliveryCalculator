using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library.Abstract
{
    public interface IParcelCostCalculator
    {
        double CalculateCost(ParcelCategory category);

        double CalculateCost(ParcelCategory category, Parcel parcel);
    }
}
