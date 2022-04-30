using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Abstract
{
    public interface IRepository<T> where T : class
    {


        void Add(T entity);
        List<T> GetAll();
        T GetSingle(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
