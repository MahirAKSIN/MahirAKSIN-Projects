using DataAccessLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {


        ContextDb c = new ContextDb();
        DbSet<T> _obj;

        public GenericRepository()
        {
            _obj = c.Set<T>();
        }

        public void Delete(T p)
        {
            _obj.Remove(p);
            c.SaveChanges();
        }

        public T Get(T p)
        {
            return _obj.SingleOrDefault();
        }

        public List<T> GetAll()
        {
            return _obj.ToList();
        }

        public void Insert(T p)
        {
            _obj.Add(p);
            c.SaveChanges();
        }

        public List<T> list(Expression<Func<T, bool>> filter)
        {
            return _obj.Where(filter).ToList();
        }

        public void Update(T p)
        {
        }
    }
}
