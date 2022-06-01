using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        #region FullMethods
        public void Add(T t)
        {
            using (var c = new ContextDb())
            {
                c.Add(t);
                c.SaveChanges();
            }
        }
        public void Delete(T t)
        {
            using (var c = new ContextDb())
            {
                c.Remove(t);
                c.SaveChanges();

            }
        }
        public List<T> GetAll()
        {
            using (var c = new ContextDb())
            {
                return c.Set<T>().ToList();

            }
        }

        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            using (ContextDb c=new ContextDb())
            {
                return c.Set<T>().Where(filter).ToList();
            }
        }

      

        public T GetById(int id)
        {
            using (var c = new ContextDb())
            {
                return c.Set<T>().Find(id);
            }
        }
        public T GetSingle(T t)
        {
            using (var c = new ContextDb())
            {
                return c.Set<T>().SingleOrDefault();

            }
        }
        public void Update(T t)
        {
            using (var c = new ContextDb())
            {
                c.Update(t);
                c.SaveChanges();
            }
        }
    }
    #endregion

}
