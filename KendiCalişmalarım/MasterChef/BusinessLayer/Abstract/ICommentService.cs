using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentDelete(Comment comment);
        void CommentUpdate(Comment comment);
        List<Comment> GetAllComment();
        List<Comment> GetById(int id);
        Comment GetSingle(Comment comment);



    }
}
