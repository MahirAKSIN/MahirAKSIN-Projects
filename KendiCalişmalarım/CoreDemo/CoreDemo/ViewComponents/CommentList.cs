using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var ComVAl = new List<UsersComment>
            {
                new UsersComment
                {
                    UserId=1,
                    UserName="Mahir"
                },
                new UsersComment
                {
                    UserId=2,
                    UserName="Deniz"
                },
                new UsersComment()
                {
                    UserId=3,
                    UserName="Necat"
                }
            };
                       


            return View(ComVAl);
        }

    }
}
