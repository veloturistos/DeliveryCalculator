using DeliveryCalculator.Library.Concrete;
using DeliveryCalculator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Test
{
    [TestClass]
    public class ParcelCostCalculatorTest
    {
        [TestMethod]
        public void CalculateParcelCostTest()
        {
            var smallParcel = new Parcel(5, 6, 7, 1);
            var mediumParcel = new Parcel(15, 26, 37, 3);
            var largeParcel = new Parcel(55, 16, 7, 6);
            var xlParcel = new Parcel(123, 34, 56, 10);

            var sizeCalculator = new ParcelCategoryBySizeCalculator();
            var costCalculator = new ParcelCostCalculator();

            Assert.AreEqual(3, costCalculator.CalculateCost(sizeCalculator.CalculateCategory(smallParcel)));
            Assert.AreEqual(8, costCalculator.CalculateCost(sizeCalculator.CalculateCategory(mediumParcel)));
            Assert.AreEqual(15, costCalculator.CalculateCost(sizeCalculator.CalculateCategory(largeParcel)));
            Assert.AreEqual(25, costCalculator.CalculateCost(sizeCalculator.CalculateCategory(xlParcel)));
        }

    }
}
