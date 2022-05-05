using GetLesson.Models.Abstract;
using GetLesson.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Models.Concrete.DAL.Ef
{
    public class EfDepartmanRepos:BaseRepository<Departman>,IDepartmanRepo
    {
    }
}
