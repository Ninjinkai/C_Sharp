using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAppUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestApp.MathOperations.Double(10);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(20, TestApp.MathOperations.Double(10));
            Assert.AreEqual(30, TestApp.MathOperations.Triple(10));
            Assert.AreEqual(0, TestApp.MathOperations.Double(0));
        }
    }
}
