using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfFoodRepository : GenericRepository<Food>, IFoodDAL
    {
        public List<Food> GetListWithCategorg()
        {
            using (ContextDb c = new ContextDb())
            {
                return c.Foods.Include(i => i.Category).ToList();

            }
        }
    }
}
