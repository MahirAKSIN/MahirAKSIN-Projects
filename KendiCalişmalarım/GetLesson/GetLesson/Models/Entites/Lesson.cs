using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Entites
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonTeacher { get; set; }
        public int Credit { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }

        public List<TakeLesson> TakeLessons { get; set; }
    }
}
