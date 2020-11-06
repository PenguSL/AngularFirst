using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SallonAppointment.Models
{
    public class Appoinment
    {
        [Key]
        public int AppoinmentId { get; set; }
        public int AppoinmentNo { get; set; }
      //  public String Month { get; set; }
        public String Date { get; set; }
        public String Note { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }  //Fk
        public int ServiceId { get; set; }  //Fk
        public ICollection <Service> Services { get; set; }
    }
}
