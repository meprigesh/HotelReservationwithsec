using HotelReservationSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Reservation_System.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly HotelReservationContext context;
        public InvoiceController(HotelReservationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Invoice()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Invoice()
        {

        }*/
    }
}
