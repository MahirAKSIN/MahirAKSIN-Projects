using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        #region Methods
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
        T GetById(int id);
        T GetSingle(T t);
        List<T> GetAllList(Expression<Func<T, bool>> filter);

        #endregion
    }
}
