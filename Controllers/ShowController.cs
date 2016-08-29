using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Show.Models;

namespace yoapi.Controllers
{
    [Route("api/[controller]")]
    public class ShowController : Controller
    {
        private ShowContext _context;
        public ShowController(ShowContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Shows> Get()
        {
            return _context.Shows;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Shows Get(int id)
        {
            return _context.Shows.Single(s => s.ShowId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Shows Show)
        {
            _context.Shows.Add(Show);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Shows newShows)
        {
            var shows = Get(id);
            shows.Band = newShows.Band;
            shows.Visitors = newShows.Visitors;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var shows = Get(id);
             _context.Shows.Remove(shows);
        }
    }
}
