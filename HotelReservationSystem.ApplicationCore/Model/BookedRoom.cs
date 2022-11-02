using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class BookedRoom
    {
        [Key]
        public int RoomBookedId { get; set; }
        public Booking Booking { get; set; }
        
    }
}
