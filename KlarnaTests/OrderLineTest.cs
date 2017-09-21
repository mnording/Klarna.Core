using System;
using Klarna.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlarnaTests
{
    [TestClass]
    public class OrderLineTest
    {
        [TestMethod]
        public void MustCalculateCorrectTotalTaxAmount()
        {
            OrderLine o = new OrderLine("test",2,10000,2500);
            Assert.AreEqual(4000, o.TotalTaxAmount);
        }

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
        [TestMethod]
        public void MustBeAbleToEditAmounts()
        {
            var t = new OrderLine("test", 2, 10000, 100);
            t.TotalTaxAmount = 1;
            t.TotalAmount = 1;
            t.TotalDiscountAmount = 1;
            Assert.AreEqual(t.TotalTaxAmount,1);
        }
        [TestMethod]
        public void MustbeabletoNullAmounts()
        {
            var t = new OrderLine("test", 2, 10000, 100);
            t.TotalTaxAmount = null;
            t.TotalAmount = null;
            t.TotalDiscountAmount = null;
            Assert.AreEqual(t.TotalTaxAmount, null);
        }
    }
}
