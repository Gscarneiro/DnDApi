using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDProject.Data;
using DnDProject.Models;

namespace DnDProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly Context _context;

        public ClassController(Context context) {
            _context = context;
        }

        // GET: api/Class
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses() {
            return await _context.Classes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(Guid id) {
            var model = await _context.Classes.FindAsync(id);

            if (model == null) {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(Guid id, Class model) {
            if (id != model.Id) {
                return BadRequest();
            }

            _context.Entry(model).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ClassExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class model) {
            _context.Classes.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass", new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(Guid id) {
            var model = await _context.Classes.FindAsync(id);
            if (model == null) {
                return NotFound();
            }

            _context.Classes.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassExists(Guid id) {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}
