using Day_07_Work_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_07_Work_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: bookstore/7/true?bookId=3
        // GET: bookstore?bookId=3
        // GET: bookstore/5/true?bookId=3&isLoggedIn=true
        [Route("bookstore/{bookId?}/{isLoggedIn?}")]
        public IActionResult Index([FromQuery] int? bookId, [FromRoute] bool? isLoggedIn, Book book)
        {
            if (!bookId.HasValue)
            {
                return BadRequest("Book id is not supplied or empty");
            }

            return Content($"<h1>In Book - {bookId} and {isLoggedIn??false}</h1>");
        }
    }
}
