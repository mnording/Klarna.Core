using System.Collections.Generic;
using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class AttacementBody
    {
        [JsonProperty(PropertyName = "voucher")]
        public List<Voucher> Voucher;
        [JsonProperty(PropertyName = "customer_account_info")]
        public List<CustomerAccountInfo> CustomerAccountInfo;
        [JsonProperty(PropertyName = "air_reservation_details")]
        public List<TransportReservationDetails> AirReservationDetails;
        [JsonProperty(PropertyName = "bus_reservation_details")]
        public List<TransportReservationDetails> BusReservationDetails;
        [JsonProperty(PropertyName = "train_reservation_details")]
        public List<TransportReservationDetails> TrainReservationDetails;
        [JsonProperty(PropertyName = "ferry_reservation_details")]
        public List<TransportReservationDetails> FerryReservationDetails;
        [JsonProperty(PropertyName = "hotel_reservation_details")]
        public List<HotelReservationDetails> HotelReservationDetails;

        public void AddVoucher(Voucher v)
        {
            if (Voucher == null)
            {
                Voucher = new List<Voucher>();
            }
            Voucher.Add(v);
        }

        public void AddCustomerAccountInfo(CustomerAccountInfo acc)
        {
            if (CustomerAccountInfo == null)
            {
                CustomerAccountInfo = new List<CustomerAccountInfo>();
            }
            CustomerAccountInfo.Add(acc);
        }

        public void AddAirReservationDetails(TransportReservationDetails transport)
        {
            if (AirReservationDetails == null)
            {
                AirReservationDetails = new List<TransportReservationDetails>();
            }
            AirReservationDetails.Add(transport);
        }
    }
}
