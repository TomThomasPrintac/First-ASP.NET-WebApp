using Microsoft.AspNetCore.Mvc;
using MyWebApplication2.Models;

namespace MyWebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person() { Name = "Tom", City = "Ness Ziona" };
            return View(person);
        }
    }
}
