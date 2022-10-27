

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }

        public int RoomId { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
