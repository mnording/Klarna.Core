using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
   public class Location
    {
        [JsonProperty(PropertyName = "street_address")]
         public string StreetAddress;
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode;
        [JsonProperty(PropertyName = "city")]
        public string City;
        [JsonProperty(PropertyName = "country")]
        public string Country;
    }
}
