using Klarna.Entities;
using Klarna.Entities.Attachement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KlarnaTests
{
    [TestClass]
    public class AttachementTest
    {
        [TestMethod]
        public void MustBeAbleToAddCustomerAccountInfo()
        {
            var att = new Attachment();
            var customer = new CustomerAccountInfo();
            att.Body.AddCustomerAccountInfo(customer);
            JsonSerializer jsonWriter = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            JObject ob = JObject.FromObject(att, jsonWriter);
            Assert.AreEqual(true, ob.ToString().Contains("account_last_modified"));
        }
        [TestMethod]
        public void MustBeAbleToAddVoucher()
        {
            var att = new Attachment();
            var voucher = new Voucher();
            voucher.VoucherCompany = "TestCompany";
            att.Body.AddVoucher(voucher);
            JsonSerializer jsonWriter = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            JObject ob = JObject.FromObject(att, jsonWriter);
            Assert.AreEqual(true, ob.ToString().Contains("TestCompany"));
        }
        [TestMethod]
        public void MustBeAbleToAddAirReservationDetails()
        {
            var att = new Attachment();
            var flight = new TransportReservationDetails();
            flight.Pnr = "mybookingID";
            att.Body.AddAirReservationDetails(flight);
            JsonSerializer jsonWriter = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            JObject ob = JObject.FromObject(att, jsonWriter);
            Assert.AreEqual(true, ob.ToString().Contains("mybookingID"));
        }
    }
}
