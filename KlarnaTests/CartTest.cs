using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klarna.Entities;

namespace KlarnaTests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotAddNegativeProduct()
        {
            var cart = new Cart();
            cart.addProduct(new CartRow("test", "testname", 22, -200, 25));
        }
        [TestMethod]
        public void CanAddDiscout()
        {
            var cart = new Cart();
            cart.addDiscount(new CartRow("test", "testname", 22, -200, 25));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotAddPositiveDiscount()
        {
            var cart = new Cart();
            cart.addDiscount(new CartRow("test", "testname", 22, 200, 25));
        }
    }
}
