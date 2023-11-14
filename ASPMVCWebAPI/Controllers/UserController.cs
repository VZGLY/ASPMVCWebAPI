using ASPMVCWebAPI.Context;
using ASPMVCWebAPI.Mapper;
using ASPMVCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCWebAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDB.Users);
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
        public IActionResult Create(UserFormViewModel createViewModel)
        {


            if (ModelState.IsValid)
            {
                FakeDB.Users.AddWithIdentity(createViewModel.ToUser());
                return RedirectToAction("Index");
            }
            Console.WriteLine("Aaaaah mec... Pas ouf...");
            return View(createViewModel);
        }



        public IActionResult Edit(int id)
        {
            User user = FakeDB.Users.Find(x => x.Id == id);

            if (user == null)
            {
                return View("NotFound");
            }

            ViewBag.EditedId = id;

            return View(user.ToViewModel());

        }

        [HttpPost]
        public IActionResult Edit(int id, UserFormViewModel form)
        {
            if (ModelState.IsValid)
            {
                User user = form.ToUser(id);

                if(FakeDB.Users.Update(user))
                {
                    Console.WriteLine("Reussi");
                    return RedirectToAction("Details", new {id = user.Id});
                }
                return View("NotFound");
            }

            ViewBag.EditedId = id;

            return View(form);
        }
    }
}
