using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCalculator.Library.Abstract;

namespace DeliveryCalculator.Library
{
    public class DeliveryCalculator
    {
        private readonly IParcelCostCalculator parcelCostCalculator;
        private readonly IParcelCategoryCalculator parcelCategoryCalculator;
        private readonly int speedyMultiplier = 2;

        public DeliveryCalculator(IParcelCostCalculator parcelCostCalculator, IParcelCategoryCalculator parcelCategoryCalculator)
        {
            this.parcelCostCalculator = parcelCostCalculator ?? throw new ArgumentNullException(nameof(parcelCostCalculator));
            this.parcelCategoryCalculator = parcelCategoryCalculator ?? throw new ArgumentNullException( nameof(parcelCategoryCalculator));

        }


        public DeliveryInvoice CalulateDelivery(IEnumerable<Parcel> parcels)
        {
            DeliveryInvoice deliveryInvoice = new DeliveryInvoice();
            double total = 0;
            foreach (var parcel in parcels)
            {
                ParcelCategory category = parcelCategoryCalculator.CalculateCategory(parcel);
                double price = parcelCostCalculator.CalculateCost(category,parcel);
                total += price;
                DeliveryItem item = new DeliveryItem(category, price);
                deliveryInvoice.AddInvoiceItem(item);
            }

            deliveryInvoice.TotalPrice = total;

            return deliveryInvoice;
        }

        public DeliveryInvoice CalulateDelivery(IEnumerable<Parcel> parcels, bool speedy)
        {
            DeliveryInvoice deliveryInvoice = CalulateDelivery(parcels);
            if(speedy)
                deliveryInvoice.SpeedyTotalPrice = deliveryInvoice.TotalPrice * speedyMultiplier ;

            return deliveryInvoice;
        }
    }
}
