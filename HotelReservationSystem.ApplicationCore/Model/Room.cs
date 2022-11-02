
using System.ComponentModel.DataAnnotations;


namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Room
    {
        public int Id { get; set; }

        public RoomType RoomType { get; set; }//this eill give room type id

       // public string TypeOfRoom { get; set; }

        public bool? Avilability { get; set; }=true;

        public int? BookingId { get; set; }
        
        public  Booking? booking { get; set; }


    }
}
