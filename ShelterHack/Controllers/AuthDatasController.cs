using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterHack.Models;

namespace ShelterHack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthDatasController : ControllerBase
    {
        private readonly ShelterContext _context;

        public AuthDatasController(ShelterContext context)
        {
            _context = context;
        }

        [HttpGet("auth")]
        public async Task<ActionResult<AuthData>> GetAuthData(string login, string password)
        {
            var authData = await _context.AuthData.Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Password == password && x.Login==login);

            if (authData == null)
            {
                return NotFound();
            }

            return authData;
        }

        // PUT: api/AuthDatas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthData(int id, AuthData authData)
        {
            if (id != authData.Id)
            {
                return BadRequest();
            }

            _context.Entry(authData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthDataExists(id))
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

        // POST: api/AuthDatas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AuthData>> PostAuthData(AuthData authData)
        {
            _context.AuthData.Add(authData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthData", new { id = authData.Id }, authData);
        }

        // DELETE: api/AuthDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthData>> DeleteAuthData(int id)
        {
            var authData = await _context.AuthData.FindAsync(id);
            if (authData == null)
            {
                return NotFound();
            }

            _context.AuthData.Remove(authData);
            await _context.SaveChangesAsync();

            return authData;
        }

        private bool AuthDataExists(int id)
        {
            return _context.AuthData.Any(e => e.Id == id);
        }
    }
}
