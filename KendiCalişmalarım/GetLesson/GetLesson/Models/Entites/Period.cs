using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Entites
{
    public class Period
    {
        [Key]
        public int PeriodId { get; set; }
        public int  PeriodNumber { get; set; }

        public List<Lesson > Lessons { get; set; }
        public List<StudentInfo >StudentInfos { get; set; }
    }
}
