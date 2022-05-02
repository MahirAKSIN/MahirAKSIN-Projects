using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.Entities
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
    }
}
