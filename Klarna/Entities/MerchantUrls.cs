using System;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class MerchantUrls
    {
        [JsonProperty(PropertyName = "confirmation")]
        public Uri Confirmation;
        [JsonProperty(PropertyName = "notification")]
        public Uri Notification;
        [JsonProperty(PropertyName = "push")]
        public Uri Push;
        [JsonProperty(PropertyName = "status_update")]
        public Uri StatusUpdate;
        [JsonProperty(PropertyName = "terms")]
        public Uri Terms;
        [JsonProperty(PropertyName = "checkout")]
        public Uri CheckoutUri;
    }
}
