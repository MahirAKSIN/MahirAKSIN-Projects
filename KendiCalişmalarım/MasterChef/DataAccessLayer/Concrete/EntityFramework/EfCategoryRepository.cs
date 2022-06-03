using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        public Category GetByIdWithCategories(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
