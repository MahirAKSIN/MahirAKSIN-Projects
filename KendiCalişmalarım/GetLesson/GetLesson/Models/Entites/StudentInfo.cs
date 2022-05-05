using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Entites
{
    public class StudentInfo
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }

        public DateTime StudentBirtday { get; set; }

        public DateTime StudentRegistration { get; set; }

        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public List<TakeLesson> TakeLessons { get; set; }




    }
}
