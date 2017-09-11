using System;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class CarRentalItinerary:BaseReservationDetails
    {
        [JsonProperty(PropertyName = "rental_company")]
        public string RentalCompany;
        [JsonProperty(PropertyName = "drivers_id")]
        public int[] DriversId;
        [JsonProperty(PropertyName = "pick_up_location")]
        public Location PickUpLocation;
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime;
        [JsonProperty(PropertyName = "drop_off_location")]
        public DateTime EndTime;
        [JsonProperty(PropertyName = "end_time")]
        public Location DropOffLocation;
        [JsonProperty(PropertyName = "car_price")]
        public int CarPrice;
        [JsonProperty(PropertyName = "class")]
        public string Class;
    }
}
