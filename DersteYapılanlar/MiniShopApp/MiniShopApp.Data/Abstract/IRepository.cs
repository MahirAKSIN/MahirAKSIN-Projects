using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
  public  interface IRepository<T>
    {
        T GEtById(int id);
        List<T> GetAll();
        void Update(T entity);
        void Create(T entity);
        void Delete(T entity);
    }
}
