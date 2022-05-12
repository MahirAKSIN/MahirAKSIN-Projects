using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>,IWriterDAL
    {
    }
}
