using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {

        DbSet<About> Abouts { get; set; }
        DbSet<Blog> Blogs{ get; set; }
        DbSet<Category > Categories{ get; set; }
        DbSet<Comment> Comments{ get; set; }
        DbSet<Contact>Contacts{ get; set; }
        DbSet<Writer>Writers{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;database=CoreDbBlog;integrated security=true;");
        }



    }
}
