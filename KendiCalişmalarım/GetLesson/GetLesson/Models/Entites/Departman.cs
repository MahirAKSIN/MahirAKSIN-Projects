using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Entites
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanName { get; set; }
        public string DepartmanMaganer { get; set; }
        public List<StudentInfo> StudentInfos { get; set; }
    }
}
