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

        public List<Blog> ListGetBlog()
        {
            return efBlogRepository.GetAllList();
        }

        public Blog Blog(Blog blog)
        {
            return efBlogRepository.GetSingle(blog);
        }

        public void BlogAdd(Blog blog)
        {
            //blogDAL.Add(blog);
            efBlogRepository.Add(blog);

        }

        public void BlogDelete(Blog blog)
        {
            efBlogRepository.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            efBlogRepository.Update(blog);
        }

        public Blog GetByBlog(int id)
        {
            return efBlogRepository.GetById(id);
        }

        public List<Blog> GetByBlogId(int id)
        {
            return efBlogRepository.GetAllList(i => i.BlogId == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return efBlogRepository.GetAllList(x => x.WriterId == id);
        }
    }
}
