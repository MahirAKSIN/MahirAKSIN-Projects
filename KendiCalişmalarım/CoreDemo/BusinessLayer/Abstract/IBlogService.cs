using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IBlogService : IGenericService<Blog>
    {

       
        
       
      
        List<Blog> GetByBlogId(int id);
        List<Blog> GetBlogListByWriter(int id);



        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWithComment();

    }
}
