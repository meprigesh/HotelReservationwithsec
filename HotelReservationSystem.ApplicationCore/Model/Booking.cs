

using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public DateTime ChecKIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get;set; }

        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //public string Contact { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        public RoomType RoomType { get; set; }
        //public int RoomTypeId { get; set; }

     
    }
}
