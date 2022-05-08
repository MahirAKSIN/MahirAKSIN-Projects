using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class HeadingRepositorycs : IHeadingDAL
    {
        public void Delete(Heading p)
        {
            throw new NotImplementedException();
        }

        public Heading Get(Heading p)
        {
            throw new NotImplementedException();
        }

        public List<Heading> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Heading p)
        {
            throw new NotImplementedException();
        }

        public List<Heading> list(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Heading p)
        {
            throw new NotImplementedException();
        }
    }
}
