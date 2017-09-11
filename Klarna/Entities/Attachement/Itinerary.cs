using System;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class Itinerary
    {
        [JsonProperty(PropertyName = "departure_city")] public string DepartureCity;
        [JsonProperty(PropertyName = "arrival")] public string Arrival;
        [JsonProperty(PropertyName = "arrival_city")] public string ArrivalCity;
        [JsonProperty(PropertyName = "carrier")] public string Carrier;
        [JsonProperty(PropertyName = "segment_price")] public int SegmentPrice;
        [JsonProperty(PropertyName = "departure_date")] public DateTime DepartureDate;
        [JsonProperty(PropertyName = "ticket_delivery_method")] public string TicketDeliveryMethod;
        [JsonProperty(PropertyName = "ticket_delivery_recipient")] public string TicketDeliveryRecipient;
        [JsonProperty(PropertyName = "passenger_id")] public int[] PassengerId;
        [JsonProperty(PropertyName = "class")] public string Class;

    }
}
