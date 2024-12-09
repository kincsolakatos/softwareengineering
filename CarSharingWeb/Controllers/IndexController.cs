using CarSharingWeb.Data;
using CarSharingWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarSharingWeb.Controllers
{
    [Route("api/index")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        CarSharingDbContext context = new CarSharingDbContext();
        // GET: api/index
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Users.ToList());
        }

        // GET api/index/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var selectedUser = (from u in context.Users
                               where u.UserId == id
                               select u).FirstOrDefault();
            if (selectedUser == null)
                return NotFound("nincs ilyenazonosito");
            return Ok(selectedUser);
        }

        // POST api/index
        [HttpPost]
        public IActionResult Post([FromBody] Users value)
        {
            context.Users.Add(value);
            context.SaveChanges();
            return Ok(value);
        }

        // PUT api/index/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/index/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteUser = (from u in context.Users
                             where u.UserId == id
                             select u).FirstOrDefault();
            if (deleteUser == null)
                return NotFound("nincs ilyen azonosito");
            context.Users.Remove(deleteUser);
            context.SaveChanges();
            return Ok(deleteUser);
        }
    }
}
