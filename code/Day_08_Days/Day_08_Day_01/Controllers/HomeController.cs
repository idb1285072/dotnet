using Day_08_Day_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_08_Day_01.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["pageTitle"] = "Asp.Net Core Demo App";

            List<Person> people = new List<Person>()
            {
                new Person()
                {
                    Id=1,
                    Name = "John",
                    DateOfBirth = DateTime.Parse("2000-02-18"),
                    PersonGender = Gender.Male},
                new Person()
                {
                    Id=2,
                    Name = "Linda",
                    DateOfBirth = DateTime.Parse("1998-02-18"),
                    PersonGender = Gender.Female},
                new Person()
                {
                    Id=1,
                    Name = "Raju",
                    DateOfBirth = DateTime.Parse("2000-02-18"),
                    PersonGender = Gender.Male
                }
            };

            //ViewData["people"] = people;
            return View(people); // Views/Home/Index.cshtml
            //return new ViewResult() { ViewName = "Index" };
        }

        [Route("person-details/{id}")]
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return Content("Person name cannot be null");
            }

            List<Person> people = new List<Person>()
            {
                new Person()
                {
                    Id=1,
                    Name = "John",
                    DateOfBirth = DateTime.Parse("2000-02-18"),
                    PersonGender = Gender.Male},
                new Person()
                {
                    Id=2,
                    Name = "Linda",
                    DateOfBirth = DateTime.Parse("1998-02-18"),
                    PersonGender = Gender.Female},
                new Person()
                {
                    Id=1,
                    Name = "Raju",
                    DateOfBirth = DateTime.Parse("2000-02-18"),
                    PersonGender = Gender.Male
                }
            };
           Person? matchingPerson = people.FirstOrDefault(person => person.Id == id);
            return View("Details", matchingPerson);
        }
    }
}
