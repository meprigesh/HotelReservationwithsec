using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Customer
    {
        public int Id { get; set; }

        //[Required]
        [MinLength(1,ErrorMessage ="*")]
        public string? FirstName { get; set; }

        //[Required]
        [MinLength(1,ErrorMessage ="*")]
        public string? LastName { get; set; }

        //[Required]
        [MinLength(1, ErrorMessage = "*")]
        public string? Address { get; set; }


        //[Required(ErrorMessage ="*")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        //[Required(ErrorMessage ="*")]
        public string? Gender { get; set; }

        //[Required]
        [MinLength(10, ErrorMessage = "*")]
        //[Display(Name ="Number should be 10 digit")]
        [DataType(DataType.PhoneNumber)]
        public string? Contact { get; set; }


        //[Required(ErrorMessage = "*")]
        public RoomType? RoomType { get; set; }

        public Booking? booking { get; set; }


        //[Required(ErrorMessage = "*")]
        //public int NumberOfRoom { get; set; }

        //[Required]
        //public DateTime CheckIn { get; set; }

        //[Required]
        //public DateTime CheckOut { get; set; }


        public string? Photo { get; set; }
        //public int RoomId { get; set; }
       // public Room Room { get; set; }

        
    }
}
