using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class CategoryRepository : ICategoryDAL
    {

        ContextDb c = new ContextDb();
        DbSet<Category> obj;

        public void Delete(Category p)
        {
            obj.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Category p)
        {
            return obj.SingleOrDefault();

        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            obj.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return obj.ToList();

        }

        public List<Category> list(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category TekGetir()
        {

            return obj.SingleOrDefault();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
