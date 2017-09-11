using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public abstract class BaseReservationDetails
    {
        [JsonProperty(PropertyName = "pnr")]
        public string Pnr;
        [JsonProperty(PropertyName = "insurance")]
        public Insurance Insurance;
        [JsonProperty(PropertyName = "affiliate_name")]
        public string AffiliateName;
    }
}
