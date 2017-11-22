using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

            Console.WriteLine($"Part Number: {invoice1.PartNumber}");
            Console.WriteLine($"Part Description: {invoice1.PartDescription}");
            Console.WriteLine($"Quantity: {invoice1.Quantity}");
            Console.WriteLine($"Price: {invoice1.Price.ToString("C")}");

            Console.WriteLine($"Invoice Amount: {invoice1.GetInvoiceAmount().ToString("C")}");
        }
    }
}
