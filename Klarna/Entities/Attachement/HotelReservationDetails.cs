using System.Collections.Generic;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class HotelReservationDetails:BaseReservationDetails
    {
        [JsonProperty(PropertyName = "itinerary")]
        public HotelItinerary Itinerary;
        [JsonProperty(PropertyName = "passengers")]
        public List<Person> Passengers;

    }
}
