using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSDIntegrationApp.API.Data;
using CSDIntegrationApp.API.Models;

namespace CSDIntegrationApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationLogController : ControllerBase
    {
        private readonly DataContext _context;

        public IntegrationLogController(DataContext context)
        {
            _context = context;
        }

        // GET: api/IntegrationLog
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntegrationRec>>> GetIntegrationLog()
        {
            return await _context.IntegrationLog.Take(10).ToListAsync();
        }

        // GET: api/IntegrationLog/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IntegrationRec>> GetIntegrationLog(int id)
        {
            var integrationLog = await _context.IntegrationLog.FindAsync(id);

            if (integrationLog == null)
            {
                return NotFound();
            }

            return integrationLog;
        }

        // PUT: api/IntegrationLog/5
 /*        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntegrationLog(int id, IntegrationRec integrationLog)
        {
            if (id != integrationLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(integrationLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IntegrationLogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        } */

/*         // POST: api/IntegrationLog
        [HttpPost]
        public async Task<ActionResult<IntegrationRec>> PostIntegrationLog(IntegrationRec integrationLog)
        {
            _context.IntegrationLog.Add(integrationLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntegrationLog", new { id = integrationLog.Id }, integrationLog);
        }

        // DELETE: api/IntegrationLog/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IntegrationRec>> DeleteIntegrationLog(int id)
        {
            var integrationLog = await _context.IntegrationLog.FindAsync(id);
            if (integrationLog == null)
            {
                return NotFound();
            }

            _context.IntegrationLog.Remove(integrationLog);
            await _context.SaveChangesAsync();

            return integrationLog;
        }
 */
        private bool IntegrationLogExists(int id)
        {
            return _context.IntegrationLog.Any(e => e.Id == id);
        }
    }
}
