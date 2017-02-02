using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klarna.Helpers;

namespace KlarnaTests
{
    [TestClass]
    public class DigestCreatorTest
    {
        [TestMethod]
        public void WillCreateCorrectOfflineDigest()
        {
            var t = new DigestCreator();
            var digest = t.CreateOffline("test","2323");
            Assert.AreEqual(digest, "dGVzdDoyMzIz");
        }
    }
}
