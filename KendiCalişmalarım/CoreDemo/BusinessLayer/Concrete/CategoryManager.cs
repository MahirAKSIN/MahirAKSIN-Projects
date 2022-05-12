using BusinessLayer.Abstract;
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

        GenericRepository<Category> genericRepository = new GenericRepository<Category>();

        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
                efCategoryRepository=new EfCategoryRepository();
        }

        public List<Category> Category()
        {
          return   efCategoryRepository.GetAllList();

            //return genericRepository.GetAllList();
            //using (var c = new Context())
            //{
            //    return c.Set<Category>().ToList();

            //}
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Add(category);

            //genericRepository.Add(category);
            //using (var c = new Context())
            //{
            //    c.Add(category);
            //    c.SaveChanges();
            //}
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);

            //genericRepository.Delete(category);
            //using (var c = new Context())
            //{
            //    c.Remove(category);
            //    c.SaveChanges();

            //}
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);

            //genericRepository.Update(category);
            //using (var c = new Context())
            //{
            //    c.Update(category);
            //    c.SaveChanges();
            //}
        }

        public Category GetById(int id)
        {
           return  efCategoryRepository.GetById(id);

            //return genericRepository.GetById(id);
            //using (var c = new Context())
            //{
            //    return c.Set<Category>().Find(id);
            //}
        }
    }
}
