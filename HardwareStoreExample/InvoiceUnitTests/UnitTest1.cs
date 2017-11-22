using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStoreExample;

namespace InvoiceUnitTests
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void GetInvoiceAmount_Test()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

            Assert.AreEqual(31.90M, invoice1.GetInvoiceAmount());
        }

        [TestMethod]
        public void Constructor_Test()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

            Assert.AreEqual("1234", invoice1.PartNumber);
            Assert.AreEqual("Hammer", invoice1.PartDescription);
            Assert.AreEqual(2, invoice1.Quantity);
            Assert.AreEqual(15.95M, invoice1.Price);

            invoice1.Quantity = -100;
            invoice1.Price = -100M;
            Assert.AreEqual(2, invoice1.Quantity);
            Assert.AreEqual(15.95M, invoice1.Price);
        }
    }
}
