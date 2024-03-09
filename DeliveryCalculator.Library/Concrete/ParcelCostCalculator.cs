﻿using DeliveryCalculator.Library.Abstract;
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
    }
}
