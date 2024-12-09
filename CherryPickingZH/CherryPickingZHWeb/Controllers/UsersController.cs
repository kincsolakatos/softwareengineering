using CherryPickingZHWeb.Data;
using CherryPickingZHWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CherryPickingZHWeb.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        CarSharingDbContext context = new CarSharingDbContext();
        // GET: api/users
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Users.ToList());
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var selectedUser = (from u in context.Users
                                where u.UserId == id
                                select u).FirstOrDefault();
            if (selectedUser == null) 
                return NotFound("nincs ilyen azonosito");
            return Ok(selectedUser);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] Users value)
        {
            context.Users.Add(value);
            context.SaveChanges();
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
            var selectedUser = (from u in context.Users
                                where u.UserId == id
                                select u).FirstOrDefault();
            if (selectedUser == null)
                return NotFound("nincs ilyen azonosito");
            context.Users.Remove(selectedUser);
            context.SaveChanges();
            return Ok(selectedUser);
        }
    }
}
