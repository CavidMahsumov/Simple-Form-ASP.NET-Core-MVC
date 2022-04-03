using FormASP.NET_Core.Entities;
using FormASP.NET_Core.Helpers;
using FormASP.NET_Core.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FormASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {

        private readonly IWebHostEnvironment _webhost;

        public HomeController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }
        FakeRepo.UsersRepo usersRepo = new FakeRepo.UsersRepo();
        
        [HttpGet]

     

        public IActionResult Index()
        {
          
            return View(usersRepo.getAllUsers());
        }
        public IActionResult Register()
        {
            UserViewModel userViewModel = new UserViewModel
            {
                User = new User()
            };

            return View(userViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            var helper = new ImageHelper(_webhost);
            model.User.ImagePath = await helper.SaveFile(model.File);
            FakeRepo.UsersRepo.Users.Add(model.User);
            return RedirectToAction("Index");
        }



    }
}
