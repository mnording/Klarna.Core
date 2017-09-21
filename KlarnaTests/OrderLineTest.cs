using System;
using Klarna.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlarnaTests
{
    [TestClass]
    public class OrderLineTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MustNotAcceptNegativeVat()
        {
            new OrderLine("test", 2, 10000, -100);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MustNotAcceptNegativeQuantity()
        {
            new OrderLine("test", -2, 10000, 100);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MustNotAcceptEmptyName()
        {
           new OrderLine("", 2, 10000, -100);

        }
        
       
       
    }
}
