using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string ReturnUrl=null)
        {

           return View(
               new LoginModel() { 
               
                   ReturUrl=ReturnUrl






               }
               
               
               );
        }



    }
}
