using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Abstract
{
    public interface IRepository<T> where T : class

    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T Get(T entity);
        T GetByID(int id);


    }
}
