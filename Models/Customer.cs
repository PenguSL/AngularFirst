using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SallonAppointment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public int MobileNo { get; set; }
        public string Email { get; set; }
        public int AppointmentId { get; set; } //Fk
        public ICollection <Appoinment> Appoinments { get; set; }





    }
}
