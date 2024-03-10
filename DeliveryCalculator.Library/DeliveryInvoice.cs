using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Library
{
    public class DeliveryInvoice
    {
        private List<DeliveryItem> invoiceItems;
        private double totalPrice;
        private double speedyTotalPrice;
        public DeliveryInvoice()
        {
            invoiceItems = new List<DeliveryItem>();
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public double SpeedyTotalPrice
        {
            get { return speedyTotalPrice; }
            set { speedyTotalPrice = value; }
        }

        public void AddInvoiceItem(DeliveryItem item)
        {
            invoiceItems.Add(item);
        }

        public DeliveryItem GetInvoiceItem(int position)
        {
            return invoiceItems[position];
        }
    }
}
