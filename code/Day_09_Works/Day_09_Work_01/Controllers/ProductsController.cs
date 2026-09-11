using Microsoft.AspNetCore.Mvc;

namespace Day_09_Work_01.Controllers
{
    public class ProductsController : Controller
    {
        [Route("products")]
        public IActionResult Index()
        {
            return View("Product");
        }
        [Route("search-product")]
        public IActionResult Search()
        {
            return View();
        }
        [Route("order-product")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
