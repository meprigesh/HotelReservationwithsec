using HotelReservationSystem.ApplicationCore.Model;
using HotelReservationSystem.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hotel_Reservation_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly CustomerRepository customerRepository;
        private readonly RoomRepository roomRepository;
        private readonly IWebHostEnvironment hostEnvironment;
        public CustomerController(CustomerRepository customerRepository, RoomRepository roomRepository, IWebHostEnvironment hostEnvironment)
        {
            this.customerRepository = customerRepository;
            this.roomRepository = roomRepository;
            this.hostEnvironment = hostEnvironment;
        }


        [HttpGet]
        public async Task<IActionResult>AddCustomer()
        {
            var rooms = await roomRepository.ListAll();
            /*ViewData["rooms"] = rooms.Select(r => new SelectListItem
            {
                Text = r.RoomType,
                Value = r.Id.ToString(),
            }).ToList();*/
            return View();        
        }

        [HttpPost]
        public async Task<IActionResult>AddCustomer(Customer customer)
        {
            await customerRepository.InsertAsync(customer);
            return Ok();
        }
    }
}
