using ASPMVCWebAPI.Context;
using ASPMVCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCWebAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            User user = FakeDB.Users.Where(x => x.Id == id).SingleOrDefault();


            if (user == null)
            {
                return View("NotFound");
            }

            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserCreateViewModel createViewModel)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Super formulaire valid toosa toosa");
                return RedirectToAction("Index");
            }
            Console.WriteLine("Aaaaah mec... Pas ouf...");
            return View(createViewModel);
        }
    }
}
