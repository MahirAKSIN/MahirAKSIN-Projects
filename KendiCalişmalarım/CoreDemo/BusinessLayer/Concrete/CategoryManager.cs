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

        GenericRepository<Category> genericRepository = new GenericRepository<Category>();

        ICategoryDAL _cd;


        public CategoryManager(ICategoryDAL cd)
        {
           
            _cd = cd;
           
        }

        public List<Category> GetAllCategory()
        {

            return _cd.GetAllList();

            //return efCategoryRepository.GetAllList();

            //return genericRepository.GetAllList();
            //using (var c = new Context())
            //{
            //    return c.Set<Category>().ToList();

            //}
        }

        public void CategoryAdd(Category category)
        {

            _cd.Add(category );

            //efCategoryRepository.Add(category);

            //genericRepository.Add(category);
            //using (var c = new Context())
            //{
            //    c.Add(category);
            //    c.SaveChanges();
            //}
        }

        public void CategoryDelete(Category category)
        {


            _cd.Delete(category);
            //efCategoryRepository.Delete(category);

            //genericRepository.Delete(category);
            //using (var c = new Context())
            //{
            //    c.Remove(category);
            //    c.SaveChanges();

            //}
        }

        public void CategoryUpdate(Category category)
        {
            _cd.Update(category );

            //efCategoryRepository.Update(category);

            //genericRepository.Update(category);
            //using (var c = new Context())
            //{
            //    c.Update(category);
            //    c.SaveChanges();
            //}
        }

        public Category GetById(int id)
        {

            return _cd.GetById(id);

            /*eturn efCategoryRepository.GetById(id);*/

            //return genericRepository.GetById(id);
            //using (var c = new Context())
            //{
            //    return c.Set<Category>().Find(id);
            //}
        }
    }
}
