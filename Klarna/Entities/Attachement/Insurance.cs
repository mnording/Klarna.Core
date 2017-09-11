using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class Insurance
    {
        [JsonProperty(PropertyName = "insurance_company")]
        public string InsuranceCompany;
        [JsonProperty(PropertyName = "insurance_type")]
        public string InsuranceType;
        [JsonProperty(PropertyName = "insurance_price")]
        public int InsurancePrice;

    }
}
