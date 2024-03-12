using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vente_consoles.Data;
using Vente_consoles.Models;

namespace Vente_consoles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsoleModelsController : ControllerBase
    {
        private readonly Vente_consolesContext _context;

        public ConsoleModelsController(Vente_consolesContext context)
        {
            _context = context;
        }

        // GET: api/ConsoleModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsoleModel>>> GetConsole()
        {
            return await _context.Console.ToListAsync();
        }

        // GET: api/ConsoleModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsoleModel>> GetConsoleModel(int id)
        {
            var consoleModel = await _context.Console.FindAsync(id);

            if (consoleModel == null)
            {
                return NotFound();
            }

            return consoleModel;
        }

        // PUT: api/ConsoleModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsoleModel(int id, ConsoleModel consoleModel)
        {
            if (id != consoleModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(consoleModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsoleModelExists(id))
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

        // POST: api/ConsoleModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsoleModel>> PostConsoleModel(ConsoleModel consoleModel)
        {
            _context.Console.Add(consoleModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsoleModel", new { id = consoleModel.Id }, consoleModel);
        }

        // DELETE: api/ConsoleModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsoleModel(int id)
        {
            var consoleModel = await _context.Console.FindAsync(id);
            if (consoleModel == null)
            {
                return NotFound();
            }

            _context.Console.Remove(consoleModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsoleModelExists(int id)
        {
            return _context.Console.Any(e => e.Id == id);
        }
    }
}
