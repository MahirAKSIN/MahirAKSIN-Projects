using MiniShopApp.Business.Abstract;
using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryService _categoryService;
        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public Category GEtById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
