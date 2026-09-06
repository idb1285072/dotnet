using Day_07_Work_02.CustomModelBinders;
using Day_07_Work_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_07_Work_02.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        // [Bind(nameof(Person.PersonName), nameof(Person.Email), nameof(Person.ConfirmPassword))]

        // [ModelBinder(BinderType = typeof(PersonModelBinder))]
        public IActionResult Index(Person person, [FromHeader(Name = "User-Agent")]string userAgent)
        {
            if (!ModelState.IsValid)
            {
                //List<string> errors = new List<string>();
                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errors.Add(error.ErrorMessage);
                //    }
                //}
                //return BadRequest(errors);

                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(error => error.ErrorMessage));    
                return BadRequest(errors);
            }
            return Content($"{person}, {userAgent}");
        }
    }
}
