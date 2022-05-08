using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
    public interface IRepository<T>
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> GetAll();
        public T Get(T p);

        public List<T> list(Expression<Func<T,bool>> filter);

    }
}
