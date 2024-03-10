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
    public class CostCalculatorTest
    {
        [TestMethod]
        public void CalculateTotalCostTest()
        {
            var parcels = new List<Parcel>
            {
                new Parcel(5, 6, 7),
                new Parcel(15, 26, 37),
                new Parcel(55, 16, 7),
                new Parcel(123, 34, 56)
            };

           
            var parcelCategoryCalculator = new ParcelCategoryBySizeCalculator();
            var parcelCostCalculator = new ParcelCostCalculator();
            var costCalculator = new Library.DeliveryCalculator(parcelCostCalculator, parcelCategoryCalculator);
            var deliveryInvoice = costCalculator.CalulateDelivery(parcels);

            Assert.AreEqual(51, deliveryInvoice.TotalPrice);
            Assert.AreEqual(102, deliveryInvoice.SpeedyTotalPrice);

            var deliveryItem_0 = deliveryInvoice.GetInvoiceItem(0);
            Assert.AreEqual(ParcelCategory.Small, deliveryItem_0.Category);
            Assert.AreEqual(3, deliveryItem_0.Price);

            var deliveryItem_1 = deliveryInvoice.GetInvoiceItem(1);
            Assert.AreEqual(ParcelCategory.Medium, deliveryItem_1.Category);
            Assert.AreEqual(8, deliveryItem_1.Price);

            var deliveryItem_2 = deliveryInvoice.GetInvoiceItem(2);
            Assert.AreEqual(ParcelCategory.Large, deliveryItem_2.Category);
            Assert.AreEqual(15, deliveryItem_2.Price);

            var deliveryItem_3 = deliveryInvoice.GetInvoiceItem(3);
            Assert.AreEqual(ParcelCategory.XL, deliveryItem_3.Category);
            Assert.AreEqual(25, deliveryItem_3.Price);


        }
    }
}
