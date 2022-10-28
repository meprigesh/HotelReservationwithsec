using HotelReservationSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Reservation_System.Controllers
{
    public class BookingController : Controller
    {
        private readonly HotelReservationContext context;
        public BookingController(HotelReservationContext context)
        {
            this.context = context;
        }

        public IActionResult DeluxRoomCount()
        {
            var deluxRoom = context.Rooms.FromSqlRaw("select COUNT(type) from Rooms where Type='Delxu' And Avilability='True'");
          //  if(deluxRoom = 0)//this will check if room is avilable or not
            {
            //    return NotFound();
            }
            return Ok(deluxRoom);
        }

        public IActionResult StandardRoomCount()
        {
           // var standardRoom= context.Rooms.FromSqlRaw("select COUNT(Type) from Rooms where Type='standard' And Avilability='True'");
            //if(standardRoom=0)//this will check if room is avilable or not
            {
             
                return Ok();
            }
            return Ok();
        }

    }
}
