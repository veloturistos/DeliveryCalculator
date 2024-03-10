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
                new Parcel(5, 6, 7, 1),
                new Parcel(15, 26, 37, 3),
                new Parcel(55, 16, 7, 6),
                new Parcel(123, 34, 56, 10)               
            };

           
            var parcelCategoryCalculator = new ParcelCategoryBySizeCalculator();
            var parcelCostCalculator = new ParcelCostCalculator();
            var costCalculator = new Library.DeliveryCalculator(parcelCostCalculator, parcelCategoryCalculator);
            var deliveryInvoice = costCalculator.CalulateDelivery(parcels);
            var deliverySpeedyInvoice = costCalculator.CalulateDelivery(parcels,true);

            Assert.AreEqual(51, deliveryInvoice.TotalPrice);
            Assert.AreEqual(102, deliverySpeedyInvoice.SpeedyTotalPrice);

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

            var overweightParcels = new List<Parcel>
            {
                new Parcel(5, 6, 7, 3),
                new Parcel(15, 26, 37, 5),
                new Parcel(55, 16, 7, 8),
                new Parcel(123, 34, 56, 12)
            };

            var deliveryWeightInvoice = costCalculator.CalulateDelivery(overweightParcels);
            var deliveryWeightSpeedyInvoice = costCalculator.CalulateDelivery(overweightParcels, true);

            Assert.AreEqual(67, deliveryWeightInvoice.TotalPrice);
            Assert.AreEqual(134, deliveryWeightSpeedyInvoice.SpeedyTotalPrice);

            var deliveryWeightItem_0 = deliveryWeightInvoice.GetInvoiceItem(0);
            Assert.AreEqual(ParcelCategory.Small, deliveryWeightItem_0.Category);
            Assert.AreEqual(7, deliveryWeightItem_0.Price);

            var deliveryWeightItem_1 = deliveryWeightInvoice.GetInvoiceItem(1);
            Assert.AreEqual(ParcelCategory.Medium, deliveryWeightItem_1.Category);
            Assert.AreEqual(12, deliveryWeightItem_1.Price);

            var deliveryWeightItem_2 = deliveryWeightInvoice.GetInvoiceItem(2);
            Assert.AreEqual(ParcelCategory.Large, deliveryWeightItem_2.Category);
            Assert.AreEqual(19, deliveryWeightItem_2.Price);

            var deliveryWeightItem_3 = deliveryWeightInvoice.GetInvoiceItem(3);
            Assert.AreEqual(ParcelCategory.XL, deliveryWeightItem_3.Category);
            Assert.AreEqual(29, deliveryWeightItem_3.Price);
        }
    }
}
