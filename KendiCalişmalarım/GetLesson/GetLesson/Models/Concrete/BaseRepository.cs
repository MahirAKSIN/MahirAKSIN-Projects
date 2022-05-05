using GetLesson.Models.Abstract;
using GetLesson.Models.Concrete.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            var _context = new GetLessonContextDb();
            _context.Add(entity);
            _context.SaveChanges();
        }

       

        public void Delete(T entity)
        {
            var _context = new GetLessonContextDb();
            _context.Remove(entity);
            _context.SaveChanges(); 

        }

        public T Get(T entity)
        {
            var _context = new GetLessonContextDb();
            return _context.Set<T>().SingleOrDefault();
        }

        public List<T> GetAll()
        {
            var _context = new GetLessonContextDb();
            return _context.Set<T>().ToList();

        }

     

        public T GetByID(int id)
        {
             var _context = new GetLessonContextDb();
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            var _context = new GetLessonContextDb();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
