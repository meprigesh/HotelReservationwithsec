using HotelReservationSystem.ApplicationCore.Model;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_System.ViewModel
{
    public class CustomerViewModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "*")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "*")]
        public string LastName { get; set; }

        public string Name { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "*")]
        public string Address { get; set; }


        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "*")]
        //[Display(Name ="Number should be 10 digit")]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }


        [Required(ErrorMessage = "*")]
        public string? RoomType { get; set; }


        [Required(ErrorMessage = "*")]
        public int NumberOfRoom { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }


        public string? Photo { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
