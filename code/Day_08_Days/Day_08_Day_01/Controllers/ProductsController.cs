using Microsoft.AspNetCore.Mvc;

namespace Day_08_Day_01.Controllers
{
    public class ProductsController : Controller
    {
        [Route("product/all")]
        public IActionResult All()
        {
            return View();
        }
    }
}
