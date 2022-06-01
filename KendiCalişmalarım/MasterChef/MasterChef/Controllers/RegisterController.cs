using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    public class RegisterController : Controller
    {
        WriterChefManager writerMan = new WriterChefManager(new EfWriterChefRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(WriterChef p)
        {
            WriteValidator validationRules = new WriteValidator();
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                p.WriterChefStatus = true;
                p.WriterChefAbout = "Deneme Yapabilirsiniz..";
                writerMan.WriterChefAdd(p);
                return RedirectToAction("Index", "Food");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View();
        }
    }

}
