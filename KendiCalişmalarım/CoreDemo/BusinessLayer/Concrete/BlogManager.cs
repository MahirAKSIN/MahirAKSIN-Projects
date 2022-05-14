using BusinessLayer.Abstract;
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
    }
}
