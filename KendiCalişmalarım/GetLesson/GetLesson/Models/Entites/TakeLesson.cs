using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Entites
{
    public class TakeLesson
    {
        [Key]
        public int TakeLessonId  { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
