using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SallonAppointment.Models;

namespace SallonAppointment.Data
{
    public class SallonContext :DbContext
    {
        public SallonContext(DbContextOptions<SallonContext> options) : base(options)
        {
        }
        // Database table for the appointments
        public DbSet<Appoinment> Appointments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }

    }

}
