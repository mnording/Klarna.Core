using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class Address
    {
        [JsonProperty(PropertyName = "city")]
        public string City;
        [JsonProperty(PropertyName = "country")]
        public string Country;
        [JsonProperty(PropertyName = "email")]
        public string Email;
        [JsonProperty(PropertyName = "family_name")]
        public string FamilyName;
        [JsonProperty(PropertyName = "given_name")]
        public string GivenName;
        [JsonProperty(PropertyName = "phone")]
        public string Phone;
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode;
        [JsonProperty(PropertyName = "region")]
        public string Region;
        [JsonProperty(PropertyName = "street_address")]
        public string StreetAddress;
        [JsonProperty(PropertyName = "street_address2")]
        public string StreetAddress2;
        [JsonProperty(PropertyName = "title")]
        public string Title;
    }
}
