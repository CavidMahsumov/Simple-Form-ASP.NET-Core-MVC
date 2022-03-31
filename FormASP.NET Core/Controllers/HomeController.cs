using FormASP.NET_Core.Entities;
using FormASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
        //problem burdadi
        List<User> users = new List<User>
            {
                new User{ Id=1, ImagePath="~/img/nerbala.jpg", Name="Nerbala", Surname="Xaladenliq Ustasi", Age=49},
                new User{ Id=1, Name="John", Surname="Cena", ImagePath="~/img/jhon.jpg", Age=47}
            };
        [HttpGet]
        
        public IActionResult Index()
        {
          
            return View(users);
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
        public IActionResult Register(User user)
        {
            users.Add(user);

            return RedirectToAction("Index");
        }

    }
}
