using GyakorloFeladatsor.BookModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GyakorloFeladatsor.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public FunnyDatabaseContext context = new FunnyDatabaseContext();
        // GET: api/books
        [HttpGet]
        public IActionResult Get()
        {
            var konyvek = context.Books.ToList();
            if (konyvek.Count > 0) 
                return Ok(konyvek);
            else 
                return NotFound();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var keresettKonyv = (from b in context.Books
                         where b.Id == id
                         select b).FirstOrDefault();
            if (keresettKonyv == null) 
                return NotFound("Nincs ilyen azonosito");
            else 
                return Ok(keresettKonyv);
        }

        // POST api/books
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            context.Books.Add(value);
            context.SaveChanges();
        }

        // PUT api/books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/books/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var torlendoKonyv = (from b in context.Books
                                 where b.Id == id
                                 select b).FirstOrDefault();
            if (torlendoKonyv == null)
                return NotFound("Nincs ilyen azonosito");
            else
            {
                context.Books.Remove(torlendoKonyv);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
