using System.Collections.Generic;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class TransportReservationDetails: BaseReservationDetails
    {
        [JsonProperty(PropertyName = "itinerary")]
        public Itinerary Itinerary;
        [JsonProperty(PropertyName = "passengers")]
        public List<Person> Passengers;
    }
}
