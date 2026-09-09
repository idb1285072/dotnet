using Microsoft.AspNetCore.Mvc;

namespace Day_08_Work_02.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about-company")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact-us")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
