using System;
using Klarna;
using Klarna.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlarnaTests
{
    [TestClass]
    public class CartRowTest
    {
        [TestMethod]
        public void CanInitRow()
        {
            var t = new CartRow("article number", "titlel", 0, 1000, VatMode.IncVat, 25);
            Assert.IsNotNull(t);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HasToBeAtleast100Cents()
        {
            var t = new CartRow("article number", "titlel", 0, 10, VatMode.IncVat, 25);
        }
        [TestMethod]
        public void CalculatesTaxCorrectly()
        {
            var t = new CartRow("article number", "titlel", 0, 1000, VatMode.IncVat, 25);
            Assert.AreEqual(t.tax_rate,2500);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanNotcreateNegativeRow()
        {
            var t = new CartRow("article number", "titlel",-10, 1000, VatMode.IncVat, 25);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanNotcreateEmptyRow()
        {
            var t = new CartRow("article number", "titlel", 0, 1000, VatMode.IncVat, 25);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanNotCreateNegativeVAT()
        {
            var t = new CartRow("article number", "titlel", 1, 1000, VatMode.IncVat, -25);
        }
    }
}
