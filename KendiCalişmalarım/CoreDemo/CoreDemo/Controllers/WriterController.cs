using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterEmail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterFooter()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfil()
        {
            var val = writerManager.TGetById(1);

            return View(val);
        }
        [HttpPost]
        public IActionResult WriterEditProfil(Writer p)
        {
            WriterValidator wV = new WriterValidator();
            ValidationResult result = wV.Validate(p);
            if (result.IsValid)
            {
                writerManager.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");

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
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfilImage p)
        {
            Writer writer = new Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                writer.WriterImage = newimagename;

            }
            writer.WriterMail = p.WriterMail;
            writer.WriterName = p.WriterName;
            writer.WriterPassword = p.WriterPassword;
            writer.WriterStatus = p.WriterStatus;
            writer.WriterAbout = p.WriterAbout;

            writerManager.TAdd(writer);

            return RedirectToAction("Index","Dashboard");


        }
    }
}
