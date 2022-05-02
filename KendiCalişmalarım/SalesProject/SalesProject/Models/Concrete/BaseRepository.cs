using SalesProject.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            var _context = new ProductDbContext();
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var _context = new ProductDbContext();
            _context.Remove(entity);
            _context.SaveChanges();

        }

        public T Get(T entity)
        {
            var _context = new ProductDbContext();
            return _context.Set<T>().SingleOrDefault();
        }

        public List<T> GetAll()
        {
            var _context = new ProductDbContext();
            return _context.Set<T>().ToList();

        }
        public void Update(T entity)
        {
            var _context = new ProductDbContext();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
