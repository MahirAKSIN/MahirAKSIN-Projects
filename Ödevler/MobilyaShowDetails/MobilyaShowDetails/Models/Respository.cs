using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowDetails.Models
{
    public static class Respository
    {
        public static List<Product> AllProduct()
        {

            var products = new List<Product>
            {
                new Product{ID=540,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 1",Price=4500},
                new Product{ID=545,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 2",Price=5500},
                new Product{ID=640,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 3",Price=6500},
                new Product{ID=440,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 4",Price=7500},
                new Product{ID=510,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 5",Price=8500},
                new Product{ID=590,ProductName="Sürgülü Dolap1",ProductDetail="Sürgülü Rayli Aynali Dolap 6",Price=9500}

            };
            return products;
        }
    }
}
