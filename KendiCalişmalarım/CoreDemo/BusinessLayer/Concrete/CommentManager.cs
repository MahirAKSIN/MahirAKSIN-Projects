using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class CommentManager : ICommentService
    {


        ICommentDAL commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            this.commentDAL = commentDAL;
        }

        public void CategoryAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

       

        public List<Comment> GetList(int id)
        {

            return commentDAL.GetAllList(i=>i.BlogID==id);
        }
    }
}
