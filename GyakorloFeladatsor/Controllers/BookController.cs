using GyakorloFeladatsor.BookModels;
using Microsoft.AspNetCore.Mvc;

namespace GyakorloFeladatsor.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly FunnyDatabaseContext _context;
        public BookController(FunnyDatabaseContext context)
        {
            _context = context;
        }
        // GET: api/books
        [HttpGet]
        public IActionResult Get() => Ok(_context.Books.ToList());
        // GET api/books/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            return book == null ? NotFound($"Könyv #{id} nem található") : Ok(book);
        }
        // POST api/books
        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new
            {
                id = newBook.Id
            }, newBook);
        }
        // DELETE api/books/5
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
