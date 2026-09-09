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
            if (id == null)
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

        [Route("person-with-product")]
        public IActionResult Product()
        {
            Person person = new Person() { Id = 1, Name = "Raj", PersonGender = Gender.Male, DateOfBirth = Convert.ToDateTime("2004-01-14") };
            Product product = new Product() { Id = 1, Name = "Product 1" };

            PersonAndProductWrapperModel model = new PersonAndProductWrapperModel() { PersonData = person, ProductData = product };
            return View("PersonWithProduct", model);
        }

        [Route("all")]
        public IActionResult All()
        {
            return View();
        }
    }
}
