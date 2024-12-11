using Cseresznye_IASR1J_Web.Data;
using Cseresznye_IASR1J_Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_IASR1J_Web.Controllers
{
    [Route("api/hozott")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        CarSharingDbContext carSharingDbContext = new CarSharingDbContext();
        // GET: api/hozott
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(carSharingDbContext.Users.ToList());
        }

        // GET api/hozott/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var selectedUser = (from u in carSharingDbContext.Users
                                where u.UserId == id
                                select u).FirstOrDefault();
            if (selectedUser == null)
            {
                return NotFound();
            }
            return Ok(selectedUser);
        }

        // POST api/hozott
        [HttpPost]
        public IActionResult Post([FromBody] Users value)
        {
            carSharingDbContext.Users.Add(value);
            carSharingDbContext.SaveChanges();
            return Ok(value);
        }

        // PUT api/hozott/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/hozott/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var selectedUser = (from u in carSharingDbContext.Users
                                where u.UserId == id
                                select u).FirstOrDefault();
            if (selectedUser == null)
            {
                return NotFound();
            }
            carSharingDbContext.Remove(selectedUser);
            carSharingDbContext.SaveChanges();
            return Ok(selectedUser);
        }
    }
}
