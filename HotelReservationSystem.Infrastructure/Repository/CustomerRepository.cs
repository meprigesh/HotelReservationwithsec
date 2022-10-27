using HotelReservationSystem.ApplicationCore.Model;
using HotelReservationSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HotelReservationSystem.Infrastructure.Repository
{
    public class CustomerRepository
    {
        private readonly HotelReservationContext db;
        public CustomerRepository(HotelReservationContext db)
        {
            this.db = db;
        }

        public async Task<int>InsertAsync(Customer customer)
        {
            await db.Customers.AddAsync(customer);
            var rowaffected = db.SaveChanges();
            return rowaffected;
        }

        public int Update(Customer customer)
        {
            db.Customers.Update(customer);
            var rowaffected=db.SaveChanges();
            return rowaffected;
        }

        public async Task<List<Customer>>AllAsync()
        {
            var customer = await db.Customers.ToListAsync();
            return customer;
        }


    }
}
