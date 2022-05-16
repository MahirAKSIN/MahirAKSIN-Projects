using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICommentService
    {

        void CategoryAdd(Comment comment);
     //   void CategoryUpdate(Category category);
       // void CategoryDelete(Category category);
        List<Comment> GetList(int id);
       // Category GetById(int id);
        //List<Category> GetCategoryWithBlog();
    }
}
