using Microsoft.AspNetCore.Mvc;
using Day_06_Work_01.Models;

namespace Day_06_Work_01.Controllers
{
    public class HomeController : Controller
    {
        // attribute routing
        [Route("/")]
        [Route("home")]
        //public string Home()
        //{
        //    return "Hello from Home";
        //}
        //public ContentResult Home()
        //{
        //    return new ContentResult() 
        //    {
        //        Content = "Hello from Index",
        //        ContentType = "text/plain" 
        //    };
        //}
        public ContentResult Home()
        {
            //return Content("Hello from Index", "text/plain");
            return Content("<h1>Welcome</h1><h2>Hello from Index</h2>", "text/html");
        }
        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id=Guid.NewGuid(), 
                FirstName= "Raj",
                LastName= "Khan", 
                Age= 43
            };
            //return new JsonResult(person);
            return Json(person);
        }

        [Route("about")]
        public string About()
        {
            return "Hello from About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{11}}$)}")]
        public string Contact()
        {
            return "Hello from Contact Us";
        }

        [Route("file-download1")]
        public VirtualFileResult FileDownload1()
        {
            //return new VirtualFileResult("/masjid.jpg", "image/jpg");
            return File("/masjid.jpg", "image/jpg");
        }

        [Route("file-download2")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult(@"C:/Users/HP/Downloads/masjid.jpg", "image/jpg");
            return PhysicalFile(@"C:/Users/HP/Downloads/masjid.jpg", "image/jpg");
        }

        [Route("file-download3")]
        public FileContentResult FileDownload3()
        {
           byte[] bytes = System.IO.File.ReadAllBytes(@"C:/Users/HP/Downloads/masjid.jpg");
            //return new FileContentResult(bytes, "image/jpg");
            return File(bytes, "image/jpg");
        }
    }
}
