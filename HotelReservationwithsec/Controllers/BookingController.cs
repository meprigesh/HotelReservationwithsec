using HotelReservationSystem.ApplicationCore.Model;
using HotelReservationSystem.Infrastructure.Data;
//using HotelReservationSystem.Infrastructure.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Hotel_Reservation_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly HotelReservationContext context;
        public BookingController(HotelReservationContext context)
        {
            this.context = context;
        }

        public IActionResult DeluxRoomCount(int count)
        {
            string deluxRoom = "select COUNT(type) from Rooms where Type='Delxu' And Avilability='True'";
            count = 0;

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


        public IActionResult StandardRoomCount(int count)
        {
            string standardRoom = "select COUNT(type) from Rooms where Type='Standard' And Avilability='True'";
            count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=HootelReservationDb1"))
            {
                using (SqlCommand cmdCount = new SqlCommand(standardRoom, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
                return Ok(count);
            }
            {
                return Ok();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddBooking(Booking booking)
        {
            if(StandardRoomCount||DeluxRoomCount >=0)
            {
                await context.Bookings.AddAsync(booking);
                context.SaveChanges();
                return Ok();
            }
            return Ok();
        }

    }
}
