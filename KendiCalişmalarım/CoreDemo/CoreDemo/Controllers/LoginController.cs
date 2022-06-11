using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {

            using (Context c = new Context())
            {
                var val = c.Writers.FirstOrDefault(i => i.WriterMail == p.WriterMail && i.WriterPassword == p.WriterPassword);

                if (val != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,p.WriterMail)
                    };
                    var useridentity = new ClaimsIdentity(claims,"a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity );
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Writer");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}
