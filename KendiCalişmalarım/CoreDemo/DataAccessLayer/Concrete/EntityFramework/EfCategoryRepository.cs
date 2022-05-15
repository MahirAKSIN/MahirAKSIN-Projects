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
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        public List<Category> GetCategoryWithBlog()
        {
            using (Context c=new Context())
            {
                return c.Categories.Include(i=>i.Blog).ToList();
            }
        }
    }
}
