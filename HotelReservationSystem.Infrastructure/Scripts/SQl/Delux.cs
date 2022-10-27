using HotelReservationSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Infrastructure.Scripts.SQl
{
    public class RoomCount
    {
        public void DeluxRoom()
        {
            HotelReservationSystem.Infrastructure.Data.HotelReservationContext _context = new();
            var rooms = _context.Rooms.FromSqlRaw("select COUNT(Type) from Rooms where Type = 'delux'").ToList();
            //return view(rooms);
        }
    }
    
}
