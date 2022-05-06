using GetLesson.Models.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Concrete.DAL
{
    public class GetLessonContextDb : DbContext
    {
        public GetLessonContextDb()
        {

        }
        public GetLessonContextDb(DbContextOptions<GetLessonContextDb> options) : base(options)
        {

        }


        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<TakeLesson> TakeLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-LOIGVJB;Database=GetLessonDb;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=GetLessonDb;Trusted_Connection=true;");
        }


    }
}
