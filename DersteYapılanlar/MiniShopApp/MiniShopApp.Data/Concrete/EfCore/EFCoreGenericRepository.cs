using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EFCoreGenericRepository<TEntity, Tcontext> : IRepository<TEntity> where TEntity : class where Tcontext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            using (var context = new Tcontext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GEtById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        internal interface ICategoryRepository<T>
        {
        }
    }
}
