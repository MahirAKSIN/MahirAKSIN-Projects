using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        /*EfCategoryRepository'i kullanmamızdaki dezavantaj Entity Framework'e bağımlı olmamız. 
         * İlerde başka bir teknoloji geldiğinde projeyi ona geçirmek 
         * için neredeyse bütün katmanlardaki kodları tek tek değiştirmemiz gerekir ama interface kullanarak bu bağımlılığı yok eder ve istersek ileride daha farklı teknolojilere geçebiliriz.
         * Avantaj olaraksa kısa vadede daha az kod yazıp daha kısa sürede projeyi bitirebiliriz.*/

        //GenericRepository<Category> genericRepository = new GenericRepository<Category>();
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        ICategoryDAL _cd;
        public CategoryManager(ICategoryDAL cd)
        {

            _cd = cd;

        }
        public List<Category> GetCategoryWithBlog()
        {
            return _cd.GetCategoryWithBlog();
        }
        public void TAdd(Category t)
        {
            _cd.Add(t);
        }
        public void TDelete(Category t)
        {
            _cd.Delete(t);
        }
        public void TUpdate(Category t)
        {
            _cd.Update(t);
        }
        public Category GetById(int id)
        {
            return _cd.GetById(id);
        }
        public List<Category> GetList()
        {
            return _cd.GetAllList();
        }
    }
}
