using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Models
{
    public class FoodModel
    {

        [Key]
        public int FoodId { get; set; }
        public string FoodTitle { get; set; }
        public string FoodContent { get; set; }
        public string FoodThumbnailImage { get; set; }
        public string FoodImage { get; set; }
        public DateTime FoodCreateDate { get; set; }
        public bool FoodStatus { get; set; }
        public int CategoryId { get; set; }
        public List<Category>  Category { get; set; }
        public List<Comment> Comment { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }

    }
}
