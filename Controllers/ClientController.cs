using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeleHealth_API.Models;
using Microsoft.AspNetCore.Authorization;


namespace TeleHealth_API.Controllers
{
    /*
    Client Controller is made to handle incoming requests involving clients, 
    which are sent to the API via either the Windows Form application or the Web Client.
    The Controller is currently capable of handling Get requests (for the Web Client) as well
    as Post Requests that the Windows Form will use to pass new client information.

    The Controller requires Basic authorization in order for the requests to work as intended.
    */
    [Authorize]
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientContext _context;

        public ClientController(ClientContext context)
        {
            _context = context;
        }

        // GET: api/client
        // Request will return the list of clients stored upon authentication
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientItems()
        {   
            return await _context.ClientItems.ToListAsync();
        }


        // PUT: api/Client/5
        // For future use within the Windows Form application in the situation that updates need to be applied.
        // Will make use of either the id parameter or a separate search filter in order to correctly identify the client.
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutClient(long id, [FromBody] Client client)
        // {
        //     if (id != client.ID)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(client).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!ClientExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: api/Client
        // Adds a new client once the request is authenticated.
        // id parameter is generated locally before the new information is added.
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client client)
        {
            client.ID = Guid.NewGuid();
            _context.ClientItems.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.ID }, client);
        }

        // DELETE: api/Client/:id
        // For future use either by an automated system or in the web client.
        // Request will pass the id or a seperate parameter to the API in order to identify and then remove client.
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteClient(long id)
        // {
        //     var client = await _context.ClientItems.FindAsync(id);
        //     if (client == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.ClientItems.Remove(client);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        private bool ClientExists(Guid id)
        {
            return _context.ClientItems.Any(e => e.ID == id);
        }
    }
}
