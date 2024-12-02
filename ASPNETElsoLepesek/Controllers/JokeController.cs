using ASPNETElsoLepesek.JokeModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNETElsoLepesek.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/jokes
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext _context = new FunnyDatabaseContext();
            return Ok(_context.Jokes.ToList());
        }

        // GET api/jokes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext _context = new FunnyDatabaseContext();
            var keresettVicc = (from x in _context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            if (keresettVicc == null)
            {
                return NotFound($"Nincs #{id} azonsoitoval vicc.");
            }
            else
            {
                return Ok(keresettVicc);
            }
        }

        // POST api/jokes
        [HttpPost]
        public void Post([FromBody] Joke ujVicc)
        {
            FunnyDatabaseContext _context = new FunnyDatabaseContext();
            _context.Jokes.Add(ujVicc);
            _context.SaveChanges();
        }

        // PUT api/<JokeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/jokes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FunnyDatabaseContext _context = new FunnyDatabaseContext();
            var torlendoVicc = (from x in _context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            _context.Remove(torlendoVicc);
            _context.SaveChanges();
        }
    }
}
