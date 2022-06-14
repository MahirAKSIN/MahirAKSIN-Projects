using Microsoft.AspNetCore.Mvc;
using System;
using BusinessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using EntityLayer;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {

        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CommentManager CommentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var blogVAlues = blogManager.GetBlogListWithCategory();

            return View(blogVAlues);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var val = blogManager.GetByBlogId(id);
            return View(val);
        }
        public IActionResult GetCommentId(int id)
        {

            //var val = blogManager.GetBlogListWithComment();
            //return View(val);

            var val = CommentManager.GetList(id);

            return View(val);

        }
        public IActionResult BlogListWithWriter()
        {
            var val = blogManager.GetListWithCategoryByWriterBm(1);

            return View(val);
        }




        [HttpGet]
        public IActionResult BlogAdd()
        {

            CategoryManager cW = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryVal = (from x in cW.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryId.ToString()
                                                }).ToList();
            ViewBag.cw = categoryVal;

            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bV = new BlogValidator();
            ValidationResult result = bV.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                blogManager.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
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

        public IActionResult DeleteBlog(int id)
        {
            var val = blogManager.TGetById(id);
            blogManager.TDelete(val);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

    }
}
