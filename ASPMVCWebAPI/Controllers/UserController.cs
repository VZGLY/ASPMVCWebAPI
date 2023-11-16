using ASPMVCWebAPI.Context;
using ASPMVCWebAPI.Mapper;
using ASPMVCWebAPI.Models;
using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.Forms;
using BLL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCWebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetAll().ToList());
        }

        public IActionResult Details(int id)
        {
            UserViewModel user = _userService.GetById(id);


            if (user is null)
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
        public IActionResult Create(CreateUserForm form)
        {
            if (ModelState.IsValid)
            {
                _userService.Create(form);
                return RedirectToAction("Index");
            }
            Console.WriteLine("Aaaaah mec... Pas ouf...");
            return View(form);
        }



        public IActionResult Edit(int id)
        {
            UpdateUserForm form = _userService.GetById(id).ToUpdateForm();

            if (form == null)
            {
                return View("NotFound");
            }

            return View(form);

        }

        [HttpPost]
        public IActionResult Edit(int id, UpdateUserForm form)
        {
            if (ModelState.IsValid)
            {

                if(_userService.Update(form))
                {
                    Console.WriteLine("Reussi");
                    return RedirectToAction("Details", new {id = form.Id});
                }
                return View("NotFound");
            }

            return View(form);
        }
    }
}
