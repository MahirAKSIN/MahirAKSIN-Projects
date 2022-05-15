using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IBlogService
    {

        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> ListGetBlog();
        Blog Blog(Blog blog);
        Blog GetByBlog(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetByBlogId(int id);
    }
}
