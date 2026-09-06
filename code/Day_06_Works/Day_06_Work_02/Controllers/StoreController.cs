using Microsoft.AspNetCore.Mvc;

namespace Day_06_Work_02.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/book")]
        public IActionResult Books()
        {
            return Content("Book Store");
        }
    }
}
