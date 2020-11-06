using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SallonAppointment.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public String ServiceName { get; set; }
        public Decimal Price { get; set; }
        //public int AppointmentId { get; set; }
        //public int Quantity { get; set; }
        //public decimal Total { get; set; }
        //public Appoinment Appoinment { get; set; }

    }
}
