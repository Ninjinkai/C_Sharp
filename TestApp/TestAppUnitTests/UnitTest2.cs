using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAppUnitTests
{
    [TestClass]
    public class FibTests
    {
        [TestMethod]
        public void TestRecursiveFibNegatives()
        {
            Assert.AreEqual(-1, TestApp.Fib.RecursiveFib(-1));
            Assert.AreEqual(-1, TestApp.Fib.RecursiveFib(-100));
        }

        [TestMethod]
        public void TestRecursiveFibBases()
        {
            Assert.AreEqual(0, TestApp.Fib.RecursiveFib(0));
            Assert.AreEqual(1, TestApp.Fib.RecursiveFib(1));
            Assert.AreEqual(1, TestApp.Fib.RecursiveFib(2));
        }

        [TestMethod]
        public void TestRecursiveFib()
        {
            Assert.AreEqual(3, TestApp.Fib.RecursiveFib(4));
            Assert.AreEqual(5, TestApp.Fib.RecursiveFib(5));
            Assert.AreEqual(8, TestApp.Fib.RecursiveFib(6));
        }
    }
}
