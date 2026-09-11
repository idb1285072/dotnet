using Day_10_Work_01.Modals;
using Microsoft.AspNetCore.Mvc;

namespace Day_10_Work_01.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "Dhaka",
                "Khulna"
            };
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("programming-languages")]
        public IActionResult ProgrammingLanguages()
        {
            ListModal listModal = new ListModal()
            {
                ListTitle = "Programming Languages List",
                ListItems = new List<string>()
                {
                    "Python",
                    "Java",
                    "C#"
                }
            };
            return PartialView("_ListPartialView", listModal);
        }
    }
}
