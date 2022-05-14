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
    public class EfBlogRepository : GenericRepository<Blog>,IBlogDAL
    { 
        public List<Blog > GetListWithCategory()
        {
            using (Context c=new Context())
            {
                return c.Blogs.Include(i => i.Category).ToList();
            }
        }

    }
}
