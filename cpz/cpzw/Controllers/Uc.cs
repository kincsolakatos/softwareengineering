using cpzw.Data;
using cpzw.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cpzw.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class Uc : ControllerBase
    {
        CarSharingDbContext c = new CarSharingDbContext();
        // GET: api/users
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(c.Users.ToList());
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var su = (from u in c.Users
                      where u.UserId == id
                      select u).FirstOrDefault();
            if (su == null)
                return NotFound();
            else 
                return Ok(su);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] Users value)
        {
            c.Users.Add(value);
            c.SaveChanges();
            return Ok(value);
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var su = (from u in c.Users
                      where u.UserId == id
                      select u).FirstOrDefault();
            if (su == null)
                return NotFound();
            else
            {
                c.Users.Remove(su);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
