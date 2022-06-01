using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }
        public void CommentAdd(Comment comment)
        {
            _commentDAL.Add(comment);
        }
        public void CommentDelete(Comment comment)
        {
            _commentDAL.Delete(comment);
        }
        public void CommentUpdate(Comment comment)
        {
            _commentDAL.Update(comment);
        }
        public List<Comment> GetAllComment()
        {
            return _commentDAL.GetAll();
        }
        public List<Comment> GetById(int id)
        {
            return _commentDAL.GetAllList(i=>i.FoodID==id);
        }
        public Comment GetSingle(Comment comment)
        {
            return _commentDAL.GetSingle(comment);
        }

      
    }
}
