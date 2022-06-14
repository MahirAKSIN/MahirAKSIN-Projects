using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using (Context c=new Context())
            {
                return c.Blogs.Include(i => i.Category).ToList();

            }
        }
        public List<Blog> GetListWithComment()
        {
            using (Context c = new Context())
            {
                return c.Blogs.Include(i => i.Comment).ToList();

            }
        }

        public List<Blog> GetLListWithCategoryByWriter(int id)
        {
            using (Context c = new Context())
            {
                return c.Blogs.Include(i => i.Category).Where(x=>x.WriterId==id).ToList();

            }
        }
    }
}
