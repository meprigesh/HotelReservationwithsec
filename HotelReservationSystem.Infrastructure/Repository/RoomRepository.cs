using HotelReservationSystem.ApplicationCore.Model;
using HotelReservationSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Infrastructure.Repository
{
    public class RoomRepository
    {
        private readonly HotelReservationContext db;
        public RoomRepository(HotelReservationContext db)
        {
            this.db = db;
        }

        public async Task<List<Room>> ListAll() 
        {
            var rooms = await db.Rooms.ToListAsync();
            return rooms;
        }
        
        
            
            
   

        public async Task<int>InsertAsync(Room room)
        {
            await db.Rooms.AddAsync(room);
            var rowaffected = db.SaveChanges();
            return rowaffected;
        }

        public int Update(Room room)
        {
            db.Rooms.Update(room);
            var rowaffected = db.SaveChanges();
            return rowaffected;
        }

        

            
    }
}
