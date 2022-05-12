using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    class BlogRepository : IBlogDAL
    {
        public void AddBlog(Blog blog)
        {
            using (var c=new Context())
            {
                c.Add(blog);
                c.SaveChanges();
            }
        }

        public void Delete(Blog blog)
        {
            using (var c=new Context())
            {
                c.Remove(blog);
                c.SaveChanges();
            }
        }

        public Blog GetById(int id)
        {
            using (var c=new Context())
            {
                return c.Blogs.Find(id);
            }
        }

        public List<Blog> ListGetBlog()
        {
            using (var c=new Context() )
            {
                return c.Blogs.ToList();
            }
        }

        public void Update(Blog blog)
        {
            using (var c=new Context())
            {
                c.Update(blog);
                c.SaveChanges();
            }
        }
    }
}
