using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {

        private string ConvertString(string text)
        {


            text = text.Replace("I", "i");
            text = text.Replace("İ", "i");
            text = text.Replace("ı", "i");
            text = text.ToLower();

            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            text = text.Replace("ü", "u");



            return text;
        }


        public List<Product> GetHomePageProducts()
        {
            using (var context = new MiniShopContext())
            {
                return context
                    .Products
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var context = new MiniShopContext())
            {
                return context
                    .Products
                    .Where(i => i.Url == url)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        //Burada görünmeseler de EfCoreGenericRepository classımızdaki tüm metotlar var.
        //Temel CRUD işlemlerini yapan 5 metot.
        public List<Product> GetProductsByCategory(string name)
        {
            using (var context= new MiniShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
                }
                return products.ToList();
            }

        }

        public List<Product> GetSearchResult(string searchString)
        {
            ChangeCase s = new ChangeCase();
            searchString = ConvertString(searchString);
            using (var context= new MiniShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved && (ConvertString(i.Name).Contains(searchString) || ConvertString(i.Description.ToLower()).Contains(searchString)))
                    .ToList();
                return products;
            }
        }
    }
}
