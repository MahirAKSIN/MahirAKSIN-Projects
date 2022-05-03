using SalesProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.Concrete
{
    public class ProductDAL:BaseRepository<Product>
    {
        //hocadan

        public ProductDAL()
        {
        }
        //private readonly ProductDbContext _context;

        //public ProductDAL(ProductDbContext context)
        //{
        //    _context = context;
        //}
    }
}
