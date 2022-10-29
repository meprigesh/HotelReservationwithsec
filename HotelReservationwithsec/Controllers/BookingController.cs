using HotelReservationSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
            string deluxRoom = "select COUNT(type) from Rooms where Type='Delxu' And Avilability='True'";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=HootelReservationDb1"))
            {
                using (SqlCommand cmdCount = new SqlCommand(deluxRoom, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
                return Ok(count);
            }
            if(count == 0)//this will check if room is avilable or not
            {
               return NotFound();
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
