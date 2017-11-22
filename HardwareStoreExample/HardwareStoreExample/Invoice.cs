using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    public class Invoice
    {
        private int quantity;
        private decimal price;

        public string PartNumber
        {
            get; set;
        }

        public string PartDescription
        {
            get; set;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public Invoice(string partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public decimal GetInvoiceAmount()
        {
            return price * quantity;
        }
    }
}
