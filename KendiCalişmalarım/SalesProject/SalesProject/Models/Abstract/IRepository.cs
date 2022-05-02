using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.Abstract
{
    interface IRepository<T> where T : class
    {

        void Add(T entity);
        List<T> GetAll();
        T Get(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
