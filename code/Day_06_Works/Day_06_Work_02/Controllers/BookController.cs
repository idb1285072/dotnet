using Microsoft.AspNetCore.Mvc;

namespace Day_06_Work_02.Controllers
{
    public class BookController : Controller
    {
        [Route("bookstore")]
        public IActionResult Index()
        {
            // 302 - Found - RedirectToActionResult
            //return new RedirectToActionResult("Books", "Store", new { }); // 302 - Found
            //return RedirectToAction("Books", "Store", new {});

            // 301 - Moved Permanently - RedirectToActionResult
            //return new RedirectToActionResult("Books", "Store", new { }, true); // 301 - Moved Permanently
            //return RedirectToActionPermanent("Books", "Store", new {});

            // 302 - Found - LocalRedirectResult
            //return new LocalRedirectResult("store/books");
            //return LocalRedirect("store/books");

            // 301 - Moved Permanently - LocalRedirectResult
            //return new LocalRedirectResult("store/books", true);
            //return LocalRedirectPermanent("store/books");

            // 302 - Found - RedirectResult
            //return new RedirectResult("store/books");
            //return Redirect("store/books");

            // 301 - Moved Permanently - RedirectResult
            //return new RedirectResult("store/books", true);
            return RedirectPermanent("store/books");
        }
    }
}
