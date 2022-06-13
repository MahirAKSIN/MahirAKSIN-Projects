using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        EfBlogRepository efBlogRepository;

        //IBlogDAL blogDAL;

        //public BlogManager(IBlogDAL blogDAL)
        //{
        //    this.blogDAL = blogDAL;
        //}

        public BlogManager(EfBlogRepository efBlogRepository)
        {

            this.efBlogRepository = efBlogRepository;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return efBlogRepository.GetListWithCategory();
        }

     

     
        public List<Blog> GetLast3Blog()
        {
            return efBlogRepository.GetAllList().TakeLast(3).ToList();
                
        }
     


        public List<Blog> GetByBlogId(int id)
        {
            return efBlogRepository.GetAllList(i => i.BlogId == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return efBlogRepository.GetAllList(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListWithComment()
        {
            return efBlogRepository.GetListWithComment();
        }

        public void TAdd(Blog t)
        {
            efBlogRepository.Add(t);
        }

        public void TDelete(Blog t)
        {
            efBlogRepository.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            efBlogRepository.Update(t);
        }

        public List<Blog> GetList()
        {
            return efBlogRepository.GetAllList();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
