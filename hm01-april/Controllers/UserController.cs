using hm01_april.Models;
using Microsoft.AspNetCore.Mvc;

namespace hm01_april.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var NewUser = new UserModel
            {
                Name = "John Doe",
                Age = 30
            };

            ViewBag.Name = NewUser.Name;
            ViewBag.Age = NewUser.Age;

            ViewData["Name"] = NewUser.Name;
            ViewData["Age"] = NewUser.Age;

            return View(NewUser);
        }
    }
}
