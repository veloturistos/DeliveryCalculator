using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library.Abstract
{
    public interface IParcelCategoryCalculator
    {
        ParcelCategory CalculateCategory(Parcel parcel);
    }
}
