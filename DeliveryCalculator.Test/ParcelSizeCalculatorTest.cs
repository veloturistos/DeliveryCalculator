using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCalculator.Library;
using DeliveryCalculator.Library.Concrete;

namespace DeliveryCalculator.Test
{
    [TestClass]
    public class ParcelSizeCalculatorTest 
    {

        [TestMethod]
        public void CalculateParcelSizeTest()
        {
            var smallParcel = new Parcel(5, 6, 7, 1);
            var mediumParcel = new Parcel(15, 26, 37, 3);
            var largeParcel = new Parcel(55, 16, 7, 6);
            var xlParcel = new Parcel(123, 34, 56, 10);

            var calculator = new ParcelCategoryBySizeCalculator();

            Assert.AreEqual(ParcelCategory.Small, calculator.CalculateCategory(smallParcel));
            Assert.AreEqual(ParcelCategory.Medium, calculator.CalculateCategory(mediumParcel));
            Assert.AreEqual(ParcelCategory.Large, calculator.CalculateCategory(largeParcel));
            Assert.AreEqual(ParcelCategory.XL, calculator.CalculateCategory(xlParcel));
        }
    }
}
