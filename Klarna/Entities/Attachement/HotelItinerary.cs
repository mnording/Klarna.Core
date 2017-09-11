using System;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class HotelItinerary : BaseReservationDetails
    {
        [JsonProperty(PropertyName = "hotel_name")]
        public string HotelName;
        [JsonProperty(PropertyName = "address")]
        public Location Address;
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime;
        [JsonProperty(PropertyName = "end_time")]
        public DateTime EndTime;
        [JsonProperty(PropertyName = "number_of_rooms")]
        public int NumberOfRooms;
        [JsonProperty(PropertyName = "passenger_id")]
        public int[] PassengerId;
        [JsonProperty(PropertyName = "ticket_delivery_method")]
        public string TicketDeliveryMethod;
        [JsonProperty(PropertyName = "ticket_delivery_recipient")]
        public string TicketDeliveryRecipient;
        [JsonProperty(PropertyName = "hotel_price")]
        public int HotelPrice;
        [JsonProperty(PropertyName = "class")]
        public string Class;

    }
}
