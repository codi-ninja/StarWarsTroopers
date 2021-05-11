using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StarWarsTroopers.Context;
using StarWarsTroopers.Model;

namespace StarWarsTroopers.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConnectionsController(AppDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Connections
        [HttpGet]
        public async Task<ActionResult<TrooperCon>> findHomeworld(string homeworld)
        {
            var prev = ""; var next = "";

            // retrieve worlds 
            var worlds = _context.Troopers.Select(a => a.homeworld).Distinct<String>().ToList();
            if (homeworld != null)
            {
                for (var i = 0; i < (worlds.Count - 1); i++)
                {
                    if (worlds[i] == homeworld)
                    {
                        prev = (i > 0) ? worlds[i - 1] : null;
                        next = (i < (worlds.Count - 1)) ? worlds[i + 1] : null;
                        break;
                    }
                }
            }
            else
            {
                next = (worlds.Count > 0) ? worlds[0] : "";
            }

            // retrieve users 
            var users = _context.Troopers.Where(a => a.homeworld == homeworld).Select(a => a.name).ToList();
            //
            TrooperCon result = new TrooperCon();
            result.count = users.Count;
            result.previous = prev;
            result.next = next;
            result.results = users;

            return result;
        }

    }
}
