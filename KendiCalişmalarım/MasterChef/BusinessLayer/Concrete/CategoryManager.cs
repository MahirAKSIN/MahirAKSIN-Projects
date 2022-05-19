using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDAL _cDal;
        public CategoryManager(ICategoryDAL cDal)
        {
            _cDal = cDal;
        }
        public void CategoryAdd(Category category)
        {
            _cDal.Add(category);
        }
        public void CategoryDelete(Category category)
        {
            _cDal.Delete(category);

        }
        public void CategoryUpdate(Category category)
        {
            _cDal.Update(category);
        }
        public List<Category> GetAllCategory()
        {
            return _cDal.GetAll();
        }
        public Category GetById(int id)
        {
            return _cDal.GetById(id);
        }
        public Category GetSingle(Category category)
        {
            return _cDal.GetSingle(category);
        }
    }
}
