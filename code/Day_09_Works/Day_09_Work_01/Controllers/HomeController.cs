using Microsoft.AspNetCore.Mvc;

namespace Day_09_Work_01.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/about-company")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/contact-us")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
