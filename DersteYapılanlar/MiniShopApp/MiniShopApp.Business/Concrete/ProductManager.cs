using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //Burada ürünlerin listelenmesi sağlanıyor.
            //Fakat ürün listeleme yapan metot çalıştırılmadan önce
            //Burada çeşitli iş kuralları uygulanacak.(Validation vb.)
            //Bunu daha sonra yazacağız.
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string name)
        {
          return   _productRepository.GetProductsByCategory(name);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
