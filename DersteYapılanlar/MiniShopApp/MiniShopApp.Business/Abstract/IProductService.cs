using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Abstract
{
    public interface IProductService
    {


        Product GEtById(int id);
        List<Product> GetAll();
        void Update(Product entity);
        void Create(Product entity);
        void Delete(Product entity);







    }
}
