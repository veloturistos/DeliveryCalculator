using DeliveryCalculator.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library.Concrete
{
    public class ParcelCostCalculator : IParcelCostCalculator
    {
        private readonly double smallParcelCost = 3.0;
        private readonly double mediumParcelCost = 8.0;
        private readonly double largeParcelCost = 15.0;
        private readonly double xlParcelCost = 25.0;

        private readonly double smallParcelWeight = 1.0;
        private readonly double mediumParcelWeight = 3.0;
        private readonly double largeParcelWeight = 6.0;
        private readonly double xlParcelWeight = 10.0;

        private readonly double overweightPrice = 2.0;


        public double CalculateCost([NotNull] ParcelCategory category)
        {
            
            switch (category)
            {
                case ParcelCategory.Small:
                    return smallParcelCost;
                case ParcelCategory.Medium:
                    return mediumParcelCost;
                case ParcelCategory.Large:
                    return largeParcelCost;
                case ParcelCategory.XL:
                    return xlParcelCost;
                default:
                    throw new NotSupportedException();
            }
        }

        public double CalculateCost([NotNull] ParcelCategory category, Parcel parcel)
        {
            double cost = 0;

            switch (category)
            {
                case ParcelCategory.Small:
                    cost = parcel.Weight <= smallParcelWeight ? smallParcelCost : smallParcelCost + (parcel.Weight - smallParcelWeight) * overweightPrice; 
                    break;
                case ParcelCategory.Medium:
                    cost = parcel.Weight <= mediumParcelWeight ? mediumParcelCost : mediumParcelCost + (parcel.Weight - mediumParcelWeight) * overweightPrice;
                    break;
                case ParcelCategory.Large:
                    cost = parcel.Weight <= largeParcelWeight ? largeParcelCost : largeParcelCost + (parcel.Weight - largeParcelWeight) * overweightPrice;
                    break;
                case ParcelCategory.XL:
                    cost = parcel.Weight <= xlParcelWeight ? xlParcelCost : xlParcelCost + (parcel.Weight - xlParcelWeight) * overweightPrice;
                    break;
                default:
                    throw new NotSupportedException();
            }

            return cost;
        }
    }
}
