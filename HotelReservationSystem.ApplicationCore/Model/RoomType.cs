using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Required]
        public string TypeOfRoom { get; set; }

        [Required]
        public int Price { get; set; }

        //public Room Id { get; set; }


    }
}
