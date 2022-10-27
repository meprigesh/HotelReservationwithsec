
using System.ComponentModel.DataAnnotations;


namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Price { get; set; }

        public bool? Avilability { get; set; }=true;

        public int? BookingId { get; set; }
        
        public  Booking? booking { get; set; }


    }
}
