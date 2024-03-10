using DeliveryCalculator.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library.Concrete
{
    public class ParcelCategoryBySizeCalculator : IParcelCategoryCalculator
    {
        private readonly double smallParcel = 10.0;
        private readonly double mediumParcel = 50.0;
        private readonly double largeParcel = 100.0;
        private readonly double heavyMinParcel = 23.0; // need to clarify 

        public ParcelCategory CalculateCategory(Parcel parcel)
        {
            if (parcel is null)
                throw new ArgumentNullException(nameof(parcel));

            if (parcel.Weight >= heavyMinParcel)
                return ParcelCategory.Heavy;

            if (parcel.Width < smallParcel && parcel.Length < smallParcel && parcel.Height < smallParcel)
                return ParcelCategory.Small;

            if (parcel.Width < mediumParcel && parcel.Length < mediumParcel && parcel.Height < mediumParcel)
                return ParcelCategory.Medium;

            if (parcel.Width < largeParcel && parcel.Length < largeParcel && parcel.Height < largeParcel)
                return ParcelCategory.Large;

            return ParcelCategory.XL;
        }
    }
}
