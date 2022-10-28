using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.ApplicationCore.Model
{
    public class Invoice
    {
        [Key]
        public int InvoiceNo { get; set; }

        public DateTime IssueDate { get; set; }

        public Customer customer { get; set; }

        public int Amount { get; set; }



    }
}
