using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SallonAppointment.Data;
using SallonAppointment.Models;

namespace SallonAppointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppoinmentsController : ControllerBase
    {
        private readonly SallonContext _context;

        public AppoinmentsController(SallonContext context)
        {
            _context = context;
        }

        // GET: api/Appoinments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appoinment>>> GetAppointments()
        {
            return await _context.Appointments.ToListAsync();
        }

        // GET: api/Appoinments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appoinment>> GetAppoinment(int id)
        {
            var appoinment = await _context.Appointments.FindAsync(id);

            if (appoinment == null)
            {
                return NotFound();
            }

            return appoinment;
        }

        // PUT: api/Appoinments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppoinment(int id, Appoinment appoinment)
        {
            if (id != appoinment.AppoinmentId)
            {
                return BadRequest();
            }

            _context.Entry(appoinment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppoinmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Appoinments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Appoinment>> PostAppoinment(Appoinment appoinment)
        {
            _context.Appointments.Add(appoinment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppoinment", new { id = appoinment.AppoinmentId }, appoinment);
        }

        // DELETE: api/Appoinments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Appoinment>> DeleteAppoinment(int id)
        {
            var appoinment = await _context.Appointments.FindAsync(id);
            if (appoinment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appoinment);
            await _context.SaveChangesAsync();

            return appoinment;
        }

        private bool AppoinmentExists(int id)
        {
            return _context.Appointments.Any(e => e.AppoinmentId == id);
        }
    }
}
