using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {

        CategoryManager cM = new CategoryManager(new EfCategoryRepository());



        public IViewComponentResult Invoke()
        {

            var val = cM.GetList();

            return View(val);
        }
    }
}
