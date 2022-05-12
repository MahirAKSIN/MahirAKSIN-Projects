using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CommentRepository<T> : IGenericDAL<Comment> where T : class
    {
        public void Add(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
