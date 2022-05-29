using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cM = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
          

            var Val = cM.GetList(id);
            return View(Val);
        }
    }
}
