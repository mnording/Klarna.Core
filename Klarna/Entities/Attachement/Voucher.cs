using System;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class Voucher
    {
        [JsonProperty(PropertyName = "voucher_name")]
        public string VoucherName;
        [JsonProperty(PropertyName = "voucher_company")]
        public string VoucherCompany;
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime;
        [JsonProperty(PropertyName = "end_time")]
        public DateTime EndTime;
        [JsonProperty(PropertyName = "affiliate_name")]
        public string AffiliateName;
    }
}
