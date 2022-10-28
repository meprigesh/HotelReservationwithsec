using HotelReservationSystem.ApplicationCore.Model;
using HotelReservationSystem.Infrastructure.Data;
using HotelReservationSystem.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Reservation_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly HotelReservationContext context;
        private readonly RoomRepository roomRepository;
        public RoomController(HotelReservationContext context,RoomRepository roomRepository)
        {
            this.context = context;
            this.roomRepository = roomRepository;
        }

        

        //Controller to display the list of rooms
        public async Task<IActionResult>ListRoom()
        {
            var rooms = await roomRepository.ListAll();
            return View(rooms);
        }


        //code to accces in view
        [HttpGet]
        public async Task<IActionResult> AddRoom()
        {
            return View();
        }

        //code to addd new room
        [HttpPost]
        public async Task<IActionResult> AddRoom([Bind("Type,Price,Avilability")] Room room)
        {
            if(ModelState.IsValid)
            {
                roomRepository.InsertAsync(room);
                await context.SaveChangesAsync();
                return RedirectToAction("ListRoom"); 
            }
            return View(room);
        }


        //code to edit room details
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || context.Rooms==null)
            {
                return NotFound();
            }

            var rooms = await context.Rooms.FindAsync(id);
            if(rooms==null)
            {
                return NotFound();
            }
            return View(rooms);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, [Bind("Type,Price,Avilability")]Room room)
        {
            if(id!=room.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    roomRepository.Update(room);
                    await context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!ProgramExists(room.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListRoom));
            }
            return View(room);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var room= context.Rooms.Find(id);
            return View(room);
        }

        [HttpPost]
        public IActionResult Delete(Room room)
        {
            room= context.Rooms.Find(room.Id);
            context.Rooms.Remove(room);
            context.SaveChanges();
            return RedirectToAction(nameof(ListRoom));
        }




        private bool ProgramExists(int id)
        {
            return context.Rooms.Any(e => e.Id == id);
        }


        /*public IActionResult DeluxRoom()
        {
            var rooms = _context.Rooms.FromSqlRaw("select COUNT(Type) from Rooms where Type = 'delux'").ToList();
            return Ok(rooms); 
        }*/
        
    }
}
