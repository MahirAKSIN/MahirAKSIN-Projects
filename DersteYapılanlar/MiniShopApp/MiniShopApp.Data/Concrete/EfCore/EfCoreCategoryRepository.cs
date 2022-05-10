using MiniShopApp.Data.Abstract;
using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    class EfCoreCategoryRepository : EFCoreGenericRepository<Category, MiniShopContext>, ICategoryRepository
    {
        public Category GetByIdWithCategories(int CategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
