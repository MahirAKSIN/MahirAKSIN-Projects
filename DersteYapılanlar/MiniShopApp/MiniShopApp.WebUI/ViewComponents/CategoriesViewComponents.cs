using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponents:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesViewComponents(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetAll());
        }
    }
}
