using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace DataAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SymPortalUserDatasController : ControllerBase
    {
        private readonly symportalContext _context;

        public SymPortalUserDatasController(symportalContext context)
        {
            _context = context;
        }

        // GET: api/SymPortalUserDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SymPortalUserData>>> GetSymPortalUserData()
        {
            return await _context.SymPortalUserData.ToListAsync();
        }

        // GET: api/SymPortalUserDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SymPortalUserData>> GetSymPortalUserData(int id)
        {
            var symPortalUserData = await _context.SymPortalUserData.FindAsync(id);

            if (symPortalUserData == null)
            {
                return NotFound();
            }

            return symPortalUserData;
        }

        // PUT: api/SymPortalUserDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSymPortalUserData(int id, SymPortalUserData symPortalUserData)
        {
            if (id != symPortalUserData.UserId)
            {
                return BadRequest();
            }

            _context.Entry(symPortalUserData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SymPortalUserDataExists(id))
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

        // POST: api/SymPortalUserDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SymPortalUserData>> PostSymPortalUserData(SymPortalUserData symPortalUserData)
        {
            _context.SymPortalUserData.Add(symPortalUserData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSymPortalUserData", new { id = symPortalUserData.UserId }, symPortalUserData);
        }

        // DELETE: api/SymPortalUserDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SymPortalUserData>> DeleteSymPortalUserData(int id)
        {
            var symPortalUserData = await _context.SymPortalUserData.FindAsync(id);
            if (symPortalUserData == null)
            {
                return NotFound();
            }

            _context.SymPortalUserData.Remove(symPortalUserData);
            await _context.SaveChangesAsync();

            return symPortalUserData;
        }

        private bool SymPortalUserDataExists(int id)
        {
            return _context.SymPortalUserData.Any(e => e.UserId == id);
        }
    }
}
