using GyakorloFeladatsor.BookModels;
using Microsoft.AspNetCore.Mvc;
namespace GyakorloFeladatsor.Controllers
{
    [Route("api/index")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        public FunnyDatabaseContext _context = new FunnyDatabaseContext();
        // GET: api/index
        [HttpGet]
        public IActionResult Get() => Ok(_context.Books.ToList());
        // GET api/index/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            return book == null ? NotFound($"Könyv #{id} nem található") : Ok(book);
        }
        // POST api/index
        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }
        // DELETE api/index/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound($"Könyv #{id} nem található");
            _context.Books.Remove(book);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
