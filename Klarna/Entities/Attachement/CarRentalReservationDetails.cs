using System.Collections.Generic;

namespace Klarna.Entities.Attachement
{
    public class CarRentalReservationDetails:BaseReservationDetails
    {
        public CarRentalItinerary itinerary;
        public List<Person> passengers;
    }
}
