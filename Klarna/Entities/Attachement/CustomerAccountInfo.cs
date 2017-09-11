using System;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class CustomerAccountInfo
    {
        [JsonProperty(PropertyName = "unique_account_identifier")]
        public string UniqueAccountIdentifier;
        [JsonProperty(PropertyName = "account_registration_date")]
        public DateTime AccountRegistrationDate;
        [JsonProperty(PropertyName = "account_last_modified")]
        public DateTime AccountLastModified;
    }
}
