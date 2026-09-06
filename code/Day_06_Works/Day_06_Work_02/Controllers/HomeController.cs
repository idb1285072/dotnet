// IActionResult
using Microsoft.AspNetCore.Mvc;

namespace Day_06_Work_02.Controllers
{
    public class HomeController : Controller
    {
        // GET: book?bookid=1&isLoggedIn=true
        [Route("book")]
        public IActionResult Index()
        {
            if (!Request.Query.ContainsKey("bookId"))
            {
                return Content("Book id is not supplied");
            }

            // BookId cannot be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookId"])))
            {
                return Content("Book Id cannot be null or empty");
            }

            //int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookId"]);
            int bookId = Convert.ToInt32(Request.Query["bookId"]);

            if (bookId <= 0)
            {
                //Response.StatusCode = 400;
                //return Content("Book id cannot be less than or equal zero");

                //return new BadRequestObjectResult("Book id cannot be less than or equal zero");
                return BadRequest("Book id cannot be less than or equal zero");
            }
            if (bookId > 1000)
            {
                //Response.StatusCode = 400; 
                //return Content("Book id cannot be greater than zero");

                return BadRequest("Book id cannot be greater than zero");
            }

            if (!Convert.ToBoolean(Request.Query["isLoggedIn"]))
            {
                //Response.StatusCode = 401;
                //return Content("User must be authenticated");

                return Unauthorized("User must be authenticated");
            }
            return File("masjid.jpg", "image/jpg");
        }
    }
}
