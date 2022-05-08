using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class WriterRepository : IWriterDAL
    {

        ContextDb c = new ContextDb();
        DbSet<Writer> _obj;
      
        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> list(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
