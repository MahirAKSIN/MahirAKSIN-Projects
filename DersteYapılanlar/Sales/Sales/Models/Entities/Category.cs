using System.Collections.Generic;

namespace Sales.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }


        public List<Product> Products { get; set; }
    }



}
