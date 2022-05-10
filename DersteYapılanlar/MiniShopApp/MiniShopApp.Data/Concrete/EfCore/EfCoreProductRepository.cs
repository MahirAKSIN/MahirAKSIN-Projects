using MiniShopApp.Data.Abstract;
using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EFCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {
        public List<Product> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
