using System;
using Klarna.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlarnaTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void MustCalculateAgeCorrectly()
        {
            var cust = new Customer();
            cust.DateOfBirth = DateTime.Now.Subtract(new TimeSpan(1095, 0, 0, 0));
            Assert.AreEqual(cust.Age, 3);
        }

        [TestMethod]
        public void MustCalculateAgeCorrectOnTheDay()
        {
            var cust = new Customer();
            cust.DateOfBirth = DateTime.Now.Subtract(new TimeSpan(1094, 0, 0, 0));
            Assert.AreEqual(cust.Age, 2);
        }
    }
}
